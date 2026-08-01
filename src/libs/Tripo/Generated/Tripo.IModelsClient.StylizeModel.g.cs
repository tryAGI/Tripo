#nullable enable

namespace Tripo
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Stylize an existing model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> StylizeModelAsync(

            global::Tripo.StylizeModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stylize an existing model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> StylizeModelAsResponseAsync(

            global::Tripo.StylizeModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stylize an existing model
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source model task ID.
        /// </param>
        /// <param name="style">
        /// Style type, one of lego, voxel, voronoi, minecraft, keyring, fridge_magnet, or keycap.
        /// </param>
        /// <param name="blockSize">
        /// Grid size, range 32-128. Only valid when style is minecraft.
        /// </param>
        /// <param name="vxc">
        /// Enable VXC processing. Requires account entitlement.
        /// </param>
        /// <param name="renderImage">
        /// Generate a rendered preview image.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> StylizeModelAsync(
            string style,
            string? input = default,
            string? originalModelTaskId = default,
            int? blockSize = default,
            bool? vxc = default,
            bool? renderImage = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}