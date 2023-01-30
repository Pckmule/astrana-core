using Astrana.Core.Domain.Models.AstranaApi;

namespace Astrana.Core.Domain.AstranaApi.Services
{
    public interface IAstranaApiCaller
    {
        void SetHost(string astranaHost);

        void SetAuthorizationToken(string authorizationToken);

        Task<ApiCallerResult> HeadAsync(string controllerName, string controllerMethodName = "", IEnumerable<object>? parameters = null);

        Task<ApiCallerResult> HeadAsync(string host, string controllerName, string controllerMethodName = "", IEnumerable<object>? parameters = null);

        Task<ApiCallerResult<TData>> GetAsync<TData>(string controllerName, string controllerMethodName = "", IEnumerable<object>? parameters = null);

        Task<ApiCallerResult<TData>> GetAsync<TData>(string host, string controllerName, string controllerMethodName = "", IEnumerable<object>? parameters = null);

        Task<ApiCallerResult<TData>> PutAsync<TData>(string controllerName, string controllerMethodName = "", dynamic payload = null);

        Task<ApiCallerResult<TData>> PutAsync<TData>(string host, string controllerName, string controllerMethodName = "", dynamic payload = null);

        Task<ApiCallerResult<TData>> PostAsync<TData>(string controllerName, string controllerMethodName = "", dynamic payload = null);

        Task<ApiCallerResult<TData>> PostAsync<TData>(string host, string controllerName, string controllerMethodName = "", dynamic payload = null);
    }
}
