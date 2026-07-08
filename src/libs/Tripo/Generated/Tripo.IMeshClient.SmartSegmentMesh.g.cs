#nullable enable

namespace Tripo
{
    public partial interface IMeshClient
    {
        /// <summary>
        /// Run the end-to-end smart segmentation pipeline
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> SmartSegmentMeshAsync(

            global::Tripo.SmartSegmentMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run the end-to-end smart segmentation pipeline
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> SmartSegmentMeshAsResponseAsync(

            global::Tripo.SmartSegmentMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run the end-to-end smart segmentation pipeline
        /// </summary>
        /// <param name="segType">
        /// Segmentation type: image or model.
        /// </param>
        /// <param name="input">
        /// Input source: file_token or public URL.
        /// </param>
        /// <param name="granularity">
        /// Segmentation granularity: coarse, medium, or fine.
        /// </param>
        /// <param name="hint">
        /// Optional hint to help identify parts to segment.
        /// </param>
        /// <param name="transform">
        /// Required when seg_type=model. Column-major 4x4 transform matrix with 16 floats.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> SmartSegmentMeshAsync(
            string segType,
            string input,
            string? granularity = default,
            string? hint = default,
            global::System.Collections.Generic.IList<double>? transform = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}