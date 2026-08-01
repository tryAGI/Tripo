#nullable enable

namespace Tripo
{
    public partial interface IAnimationClient
    {
        /// <summary>
        /// Rig a 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> RigModelAsync(

            global::Tripo.RigModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rig a 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> RigModelAsResponseAsync(

            global::Tripo.RigModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rig a 3D model
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source model task ID.
        /// </param>
        /// <param name="model">
        /// Auto rigging model version, v1.0-20240301 or v2.5-20260210.
        /// </param>
        /// <param name="rigType">
        /// Rig type, such as biped, quadruped, hexapod, octopod, avian, serpentine, or aquatic.
        /// </param>
        /// <param name="spec">
        /// Rigging specification, such as tripo or mixamo.
        /// </param>
        /// <param name="outFormat">
        /// Output format, such as glb or fbx.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> RigModelAsync(
            string? input = default,
            string? originalModelTaskId = default,
            string? model = default,
            string? rigType = default,
            string? spec = default,
            string? outFormat = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}