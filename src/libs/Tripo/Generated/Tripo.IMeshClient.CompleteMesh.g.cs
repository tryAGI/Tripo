#nullable enable

namespace Tripo
{
    public partial interface IMeshClient
    {
        /// <summary>
        /// Complete selected mesh parts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> CompleteMeshAsync(

            global::Tripo.CompleteMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete selected mesh parts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> CompleteMeshAsResponseAsync(

            global::Tripo.CompleteMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete selected mesh parts
        /// </summary>
        /// <param name="input">
        /// task_id of a mesh/segment task.
        /// </param>
        /// <param name="model">
        /// Completion model version.
        /// </param>
        /// <param name="partNames">
        /// List of part names to complete. If omitted, all parts are completed.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source segmentation task ID.
        /// </param>
        /// <param name="completionMode">
        /// Completion mode, ai_completion or quick_cap.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> CompleteMeshAsync(
            string? input = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? partNames = default,
            string? originalModelTaskId = default,
            string? completionMode = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}