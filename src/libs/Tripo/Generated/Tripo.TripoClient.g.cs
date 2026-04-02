
#nullable enable

namespace Tripo
{
    /// <summary>
    /// use tripo to generate 3d models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TripoClient : global::Tripo.ITripoClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.tripo3d.ai/v2/openapi";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Tripo.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Tripo.JsonConverters.TaskStatusJsonConverter(),
                    new global::Tripo.JsonConverters.TaskStatusNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant1TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant1TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant1ModelVersionJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant1ModelVersionNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant2TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant2TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant2ModelVersionJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant2ModelVersionNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant3TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant3TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant3ModeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant3ModeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant3ModelVersionJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant3ModelVersionNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant4TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant4TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant5TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant5TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant6TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant6TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant7TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant7TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant7AnimationJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant7AnimationNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant8TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant8TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant8StyleJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant8StyleNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant9TypeJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant9TypeNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant9FormatJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant9FormatNullableJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant9TextureFormatJsonConverter(),
                    new global::Tripo.JsonConverters.CreateTaskRequestVariant9TextureFormatNullableJsonConverter(),
                    new global::Tripo.JsonConverters.OneOfJsonConverter<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9>(),
                    new global::Tripo.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Creates a new instance of the TripoClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TripoClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Tripo.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Tripo.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}