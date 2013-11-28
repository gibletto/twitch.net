using RestSharp;

namespace Twitch.Net.Helpers
{
    public static class RequestExtensions
    {
        public static void AddSafeParameter(this IRestRequest request, string parameter, object value)
        {
            if (!string.IsNullOrEmpty(parameter) && value != null)
            {
                request.AddParameter(parameter, value);
            }
        }
    }
}
