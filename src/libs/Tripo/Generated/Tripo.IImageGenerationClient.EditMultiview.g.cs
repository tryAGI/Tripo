#nullable enable

namespace Tripo
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Edit multiview images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> EditMultiviewAsync(

            global::Tripo.EditMultiviewRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit multiview images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> EditMultiviewAsResponseAsync(

            global::Tripo.EditMultiviewRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit multiview images
        /// </summary>
        /// <param name="input">
        /// Source multiview image, file token, URL, or task ID.
        /// </param>
        /// <param name="originalTaskId">
        /// Legacy task ID from a successful image-to-multiview task.
        /// </param>
        /// <param name="prompts">
        /// One to four per-view edit instructions.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> EditMultiviewAsync(
            global::System.Collections.Generic.IList<global::Tripo.MultiviewEditPrompt> prompts,
            string? input = default,
            string? originalTaskId = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}