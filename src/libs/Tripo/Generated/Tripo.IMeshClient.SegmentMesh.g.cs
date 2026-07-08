#nullable enable

namespace Tripo
{
    public partial interface IMeshClient
    {
        /// <summary>
        /// Perform semantic segmentation on a 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> SegmentMeshAsync(

            global::Tripo.SegmentMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform semantic segmentation on a 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> SegmentMeshAsResponseAsync(

            global::Tripo.SegmentMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform semantic segmentation on a 3D model
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id, file_token, or URL.
        /// </param>
        /// <param name="model">
        /// Segmentation model version, such as v1.0-20250506 or v2.0-20260430.
        /// </param>
        /// <param name="segmentationGranularity">
        /// v2 only. Granularity, such as simple, balanced, or detailed.
        /// </param>
        /// <param name="splitByConnectivity">
        /// v2 only. Whether to split by connected components.
        /// </param>
        /// <param name="refImage">
        /// v2 only. Reference image as file_token or URL.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> SegmentMeshAsync(
            string input,
            string? model = default,
            string? segmentationGranularity = default,
            bool? splitByConnectivity = default,
            string? refImage = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}