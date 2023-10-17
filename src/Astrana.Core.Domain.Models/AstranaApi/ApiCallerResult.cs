using Astrana.Core.Domain.Models.AstranaApi.Responses;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.AstranaApi
{
    public sealed class ApiCallerResult
    {
        private readonly HttpResponseMessage _response;

        public ApiCallerResult(HttpResponseMessage response)
        {
            _response = response;
        }

        public ApiCallerResult(Exception exception)
        {
            _response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                ReasonPhrase = exception.Message
            };
        }

        public bool IsSuccess => _response.IsSuccessStatusCode;

        public string StatusCode => _response.StatusCode.ToString();

        public string Message => _response.ReasonPhrase ?? "Success";

        public ApiHeadResponse Content
        {
            get
            {
                var headers = new Dictionary<string, string>();
                foreach (var header in _response.Headers)
                {
                    foreach (var headerValue in header.Value)
                    {
                        headers.Add(header.Key, headerValue);
                    }
                }

                return new ApiHeadResponse
                {
                    Headers = headers
                };
            }
        }
    }

    public sealed class ApiCallerResult<TData>
    {
        private readonly HttpMethod _httpMethod;
        private readonly HttpResponseMessage _response;
        private readonly string _content;

        private readonly JsonSerializerOptions _jsonDeserializerOptions;

        private readonly JsonSerializerOptions _defaultJsonSerializerOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public ApiCallerResult(HttpMethod httpMethod, HttpResponseMessage response, JsonSerializerOptions? jsonDeserializerOptions = null)
        {
            _httpMethod = httpMethod;
            _response = response;
            _content = _response.Content.ReadAsStringAsync().Result;

            _jsonDeserializerOptions = jsonDeserializerOptions ?? _defaultJsonSerializerOptions;
        }

        public ApiCallerResult(HttpMethod httpMethod, Exception exception)
        {
            _httpMethod = httpMethod;

            _response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                ReasonPhrase = exception.Message
            };

            _content = string.Empty;

            _jsonDeserializerOptions = _defaultJsonSerializerOptions;
        }

        public bool IsSuccess => _response.IsSuccessStatusCode;

        public string StatusCode => _response.StatusCode.ToString();

        public string Message => _response.ReasonPhrase ?? "Success";

        public ApiResponse<TData> GetContent()
        {
            if (_httpMethod == HttpMethod.Head)
                throw new ArgumentException("HTTP Method cannot be HEAD.");
            
            if (_httpMethod == HttpMethod.Get)
            {
                if (!_response.IsSuccessStatusCode)
                    return new ApiGetResponse<TData>();
                
                if (string.IsNullOrWhiteSpace(_content))
                    return new ApiGetResponse<TData>();

                return JsonSerializer.Deserialize<ApiGetResponse<TData>>(_content, _jsonDeserializerOptions) ?? new ApiGetResponse<TData>();
            }

            if (!_response.IsSuccessStatusCode)
                return new ApiResponse<TData>();
            
            if (string.IsNullOrWhiteSpace(_content))
                return new ApiResponse<TData>();

            return JsonSerializer.Deserialize<ApiResponse<TData>>(_content, _jsonDeserializerOptions) ?? new ApiResponse<TData>();
        }
    }
}
