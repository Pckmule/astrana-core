using Astrana.Core.Domain.Models.AstranaApi;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.AstranaApi.Services
{
    public class AstranaApiCaller : IAstranaApiCaller
    {
        //private readonly ILogger<AstranaApiCaller> _logger;
        private string _astranaHost;
        private string _authorizationToken;

        private readonly HttpClient _httpClient;

        public const string DefaultControllerMethodName = "";

        public AstranaApiCaller(/*ILogger<AstranaApiCaller> logger*/)
        {
            //_logger = logger;
            _httpClient = new HttpClient();
            
            _astranaHost = string.Empty; 
            _authorizationToken = string.Empty;
        }

        public void SetHost(string astranaHost)
        {
            _astranaHost = astranaHost;
        }

        public void SetAuthorizationToken(string authorizationToken)
        {
            _authorizationToken = authorizationToken;
        }

        /// <summary>
        /// Makes a HTTP HEAD call to the specified endpoint.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="parameters"></param>
        public async Task<ApiCallerResult> HeadAsync(string host, string controllerName, string controllerMethodName = DefaultControllerMethodName, IEnumerable<object>? parameters = null)
        {
            if (!string.IsNullOrWhiteSpace(_authorizationToken))
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.Api.AuthorizationSchemeName.Bearer, _authorizationToken);

            using var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, BuildEndpoint(host, controllerName, controllerMethodName)));
            return new ApiCallerResult(response);
        }

        /// <summary>
        /// Makes a HTTP HEAD call to the specified endpoint.
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="parameters"></param>
        public async Task<ApiCallerResult> HeadAsync(string controllerName, string controllerMethodName = DefaultControllerMethodName, IEnumerable<object>? parameters = null)
        {
            return await HeadAsync(_astranaHost, controllerName, controllerMethodName, parameters);
        }

        /// <summary>
        /// Makes a HTTP GET call to the specified endpoint.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="parameters"></param>
        public async Task<ApiCallerResult<TData>> GetAsync<TData>(string host, string controllerName, string controllerMethodName = DefaultControllerMethodName, IEnumerable<object>? parameters = null)
        {
            AddAuthorizationHeader();

            using var response = await _httpClient.GetAsync(BuildEndpoint(host, controllerName, controllerMethodName, parameters));
            return new ApiCallerResult<TData>(HttpMethod.Get, response);
        }
        
        /// <summary>
        /// Makes a HTTP GET call to the specified endpoint.
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="parameters"></param>
        public async Task<ApiCallerResult<TData>> GetAsync<TData>(string controllerName, string controllerMethodName = DefaultControllerMethodName, IEnumerable<object>? parameters = null)
        {
            return await GetAsync<TData>(_astranaHost, controllerName, controllerMethodName, parameters);
        }

        /// <summary>
        /// Makes a HTTP PUT call to the specified endpoint.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="payload"></param>
        public async Task<ApiCallerResult<TData>> PutAsync<TData>(string host, string controllerName, string controllerMethodName = DefaultControllerMethodName, dynamic payload = null)
        {
            AddAuthorizationHeader();

            try
            {
                var endpoint = BuildEndpoint(host, controllerName, controllerMethodName);
                using var response = await _httpClient.PutAsync(endpoint, BuildRequestBody(payload));
                return new ApiCallerResult<TData>(HttpMethod.Put, response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Makes a HTTP PUT call to the specified endpoint.
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="payload"></param>
        public async Task<ApiCallerResult<TData>> PutAsync<TData>(string controllerName, string controllerMethodName = DefaultControllerMethodName, dynamic payload = null)
        {
            return await PutAsync<TData>(_astranaHost, controllerName, controllerMethodName, payload);
        }

        /// <summary>
        /// Makes a HTTP POST call to the specified endpoint.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="payload"></param>
        public async Task<ApiCallerResult<TData>> PostAsync<TData>(string host, string controllerName, string controllerMethodName = DefaultControllerMethodName, dynamic payload = null)
        {
            AddAuthorizationHeader();

            using var response = await _httpClient.PostAsync(BuildEndpoint(host, controllerName, controllerMethodName), BuildRequestBody(payload));
            return new ApiCallerResult<TData>(HttpMethod.Post, response);
        }

        /// <summary>
        /// Makes a HTTP POST call to the specified endpoint.
        /// </summary>
        /// <param name="controllerName"></param>
        /// <param name="controllerMethodName"></param>
        /// <param name="payload"></param>
        public async Task<ApiCallerResult<TData>> PostAsync<TData>(string controllerName, string controllerMethodName = DefaultControllerMethodName, dynamic payload = null)
        {
            return await PostAsync<TData>(_astranaHost, controllerName, controllerMethodName, payload);
        }

        private static Uri BuildEndpoint(string host, string controllerName, string controllerMethodName = DefaultControllerMethodName, IEnumerable<object>? parameters = null)
        {
            if (host.Contains("://"))
                host = host.Split("://")[1];

            if (string.IsNullOrWhiteSpace(host))
                throw new ArgumentException(nameof(host));

            if (string.IsNullOrWhiteSpace(controllerName))
                throw new ArgumentException(nameof(controllerName));

            var urlParts = new List<string>
            {
                $"https://{host}",
                controllerName
            };

            if (!string.IsNullOrWhiteSpace(controllerMethodName))
                urlParts.Add(controllerMethodName);

            var queryParameters = (from parameter in parameters ?? new List<object>() where string.IsNullOrWhiteSpace(parameter as string) select parameter as string).ToList();

            return new Uri($"{string.Join('/', urlParts)}{(queryParameters.Count > 0 ? $"?{string.Join('&', queryParameters)}" : "")}".ToLower());
        }

        private static StringContent BuildRequestBody(dynamic payload)
        {
            if (payload == null)
                return new StringContent("", Encoding.UTF8, "application/json");

            try
            {
                var jsonDeserializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new JsonStringEnumConverter() }
                };

                var jsonText = JsonSerializer.Serialize(payload, jsonDeserializerOptions);

                return new StringContent(jsonText, Encoding.UTF8, "application/json");
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, ex.Message);
            }

            return new StringContent("", Encoding.UTF8, "application/json");
        }

        private void AddAuthorizationHeader()
        {
            if (!string.IsNullOrWhiteSpace(_authorizationToken))
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.Api.AuthorizationSchemeName.Bearer, _authorizationToken);
        }
    }
}
