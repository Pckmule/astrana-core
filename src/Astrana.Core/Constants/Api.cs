/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Constants
{
    public static class Api
    {
        public const string RoutePrefix = "api";
        public const string DocsRoutePrefix = $"docs/{RoutePrefix}";

        public static class Swagger
        {
            public const string SwaggerUiDirectoryName = "swagger-ui";
        }

        public static class HeaderNames
        {
            public const string ApiVersion = "x-api-version";

            public static class Astrana
            {
                public const string TotalCount = "x-total-count";
            }
        }

        public static class AuthorizationSchemeName
        {

            public const string Bearer = "Bearer";
        }

        public static class BearerAuthorizationFormat
        {

            public const string Jwt = "JWT";
        }
    }
}
