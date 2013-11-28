using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Twitch.Net.Helpers
{
    public static class DynamicExtensions
    {
        public static T FromDynamic<T, TBase>(this ExpandoObject expando) where T : class
        {
            var dictionary = expando.ToDictionary(pair => pair.Key, pair => pair.Value);
            var bindings = new List<MemberBinding>();
            foreach (var sourceProperty in typeof(T).GetProperties().Where(x => x.CanWrite))
            {
                //If we have generic arguments, see if we have a display name
                var genericArg = sourceProperty.PropertyType.GetGenericArguments();
                var displayAttribute = sourceProperty.GetCustomAttribute<DisplayNameAttribute>();
                if (displayAttribute == null && genericArg.Any())
                {
                    displayAttribute = genericArg[0].GetCustomAttribute<DisplayNameAttribute>();
                }
                
                if (displayAttribute == null)
                {
                    return dictionary as T;
                }
                var propertyName = displayAttribute.DisplayName;
                var key = dictionary.Keys.FirstOrDefault(x => x == propertyName);
                if (string.IsNullOrEmpty(key)) continue;
                var propertyValue = dictionary[key];
                if (propertyValue == null) continue;
                var type = propertyValue.GetType();
                if (type == typeof (ExpandoObject))
                {
                    var method = typeof (DynamicExtensions).GetMethod("FromDynamic");
                    var generic = method.MakeGenericMethod(sourceProperty.PropertyType, sourceProperty.PropertyType);
                    propertyValue = generic.Invoke(null, new[] {propertyValue});
                }
                else if (type == typeof (List<object>))
                {
                    var method = typeof (DynamicExtensions).GetMethod("FromDynamic");
                    var genericArgument = sourceProperty.PropertyType.GetGenericArguments()[0];
                    var generic = method.MakeGenericMethod(genericArgument, typeof(TBase));
                    var list = propertyValue as IEnumerable<object>;
                    if (list != null)
                    {
                        if (genericArgument == typeof(TBase))
                        {
                            propertyValue = list.Select(x => (TBase) generic.Invoke(null, new[] {x})).ToList();
                        }
                        else
                        {
                            var castMethod = typeof(DynamicExtensions).GetMethod("ToListOfType");
                            var genericCast = castMethod.MakeGenericMethod(genericArgument);
                            propertyValue = genericCast.Invoke(null, new[] {list.Select(x => generic.Invoke(null, new[] {x}))});
                        }
                    }
                }
                if(propertyValue != null)
                    bindings.Add(Expression.Bind(sourceProperty, Expression.Constant(propertyValue)));
            }
            Expression memberInit = Expression.MemberInit(Expression.New(typeof(T)), bindings);
            return Expression.Lambda<Func<T>>(memberInit).Compile().Invoke();
        }

        public static IEnumerable<T> ToListOfType<T>(IEnumerable<object> list)
        {
            return list.Select(x => (T) x).ToList();
        }
    }
}
