#nullable enable

namespace Tripo
{
    public partial interface IAnimationClient
    {
        /// <summary>
        /// Apply preset animations to a rigged 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> RetargetAnimationAsync(

            global::Tripo.RetargetAnimationRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply preset animations to a rigged 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> RetargetAnimationAsResponseAsync(

            global::Tripo.RetargetAnimationRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply preset animations to a rigged 3D model
        /// </summary>
        /// <param name="input">
        /// task_id of the rigged model.
        /// </param>
        /// <param name="animation">
        /// Single preset animation identifier. Mutually exclusive with animations.
        /// </param>
        /// <param name="animations">
        /// List of multiple preset animation identifiers. Mutually exclusive with animation.
        /// </param>
        /// <param name="outFormat">
        /// Output format, such as glb or fbx.
        /// </param>
        /// <param name="bakeAnimation">
        /// Bake the animation into the model. Only effective for glb output.
        /// </param>
        /// <param name="exportWithGeometry">
        /// Export with geometry included.
        /// </param>
        /// <param name="animateInPlace">
        /// Play the animation in place without displacement.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> RetargetAnimationAsync(
            string input,
            string? animation = default,
            global::System.Collections.Generic.IList<string>? animations = default,
            string? outFormat = default,
            bool? bakeAnimation = default,
            bool? exportWithGeometry = default,
            bool? animateInPlace = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}