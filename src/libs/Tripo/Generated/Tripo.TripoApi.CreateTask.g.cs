
#nullable enable

namespace Tripo
{
    public partial class TripoApi
    {
        partial void PrepareCreateTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Tripo.OneOf<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9> request);
        partial void PrepareCreateTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Tripo.OneOf<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9> request);
        partial void ProcessCreateTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// create a task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Tripo.SuccessTask> CreateTaskAsync(
            global::Tripo.OneOf<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateTaskArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/task",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTaskRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTaskResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateTaskResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Tripo.SuccessTask.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// create a task
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Tripo.SuccessTask> CreateTaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Tripo.OneOf<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9>
            {
            };

            return await CreateTaskAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}