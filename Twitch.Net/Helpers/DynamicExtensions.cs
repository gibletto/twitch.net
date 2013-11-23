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
        public static T FromDynamic<T>(this ExpandoObject expando) where T : class
        {
            var dictionary = expando.ToDictionary(pair => pair.Key, pair => pair.Value);
            var bindings = new List<MemberBinding>();
            foreach (var sourceProperty in typeof(T).GetProperties().Where(x => x.CanWrite))
            {
                var displayAttribute = sourceProperty.GetCustomAttribute<DisplayNameAttribute>();
                if (displayAttribute == null)
                {
                    return dictionary as T;
                }
                var propertyName = sourceProperty.GetCustomAttribute<DisplayNameAttribute>().DisplayName;
                var key = dictionary.Keys.FirstOrDefault(x => x == propertyName);
                if (string.IsNullOrEmpty(key)) continue;
                var propertyValue = dictionary[key];
                if (propertyValue == null) continue;
                var type = propertyValue.GetType();
                if (type == typeof (ExpandoObject))
                {
                    var method = typeof (DynamicExtensions).GetMethod("FromDynamic");
                    var generic = method.MakeGenericMethod(sourceProperty.PropertyType);
                    propertyValue = generic.Invoke(null, new[] {propertyValue});
                }
                else if (type == typeof (List<object>))
                {
                    var method = typeof (DynamicExtensions).GetMethod("FromDynamic");
                    var generic = method.MakeGenericMethod(sourceProperty.PropertyType);
                    var list = propertyValue as List<object>;
                    if (list != null)
                    {
                        foreach (var o in list)
                        {
                            var result = generic.Invoke(null, new[] {o});
                            result = result;
                        }
                        var val = list.Select(x => generic.Invoke(null, new[] {x}));
                        propertyValue = val;
                    }
                }
                bindings.Add(Expression.Bind(sourceProperty, Expression.Constant(propertyValue)));
            }
            Expression memberInit = Expression.MemberInit(Expression.New(typeof(T)), bindings);
            return Expression.Lambda<Func<T>>(memberInit).Compile().Invoke();
        }



        public static dynamic ToDynamic<T>(this T obj)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                var propertyExpression = Expression.Property(Expression.Constant(obj), propertyInfo);
                var currentValue = Expression.Lambda<Func<string>>(propertyExpression).Compile().Invoke();
                expando.Add(propertyInfo.Name.ToLower(), currentValue);
            }
            return expando as ExpandoObject;
        }
    }
}
