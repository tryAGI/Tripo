#nullable enable

namespace Tripo
{
    public partial interface IMeshClient
    {
        /// <summary>
        /// Decimate or retopologize a 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> DecimateMeshAsync(

            global::Tripo.DecimateMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decimate or retopologize a 3D model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> DecimateMeshAsResponseAsync(

            global::Tripo.DecimateMeshRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Decimate or retopologize a 3D model
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="model">
        /// Decimation model version.
        /// </param>
        /// <param name="faceLimit">
        /// Target polycount, in the range 1000-20000.
        /// </param>
        /// <param name="quad">
        /// Output a quad mesh.
        /// </param>
        /// <param name="partNames">
        /// List of part names to decimate.
        /// </param>
        /// <param name="bake">
        /// Bake textures onto the low-poly model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> DecimateMeshAsync(
            string input,
            string? model = default,
            int? faceLimit = default,
            bool? quad = default,
            global::System.Collections.Generic.IList<string>? partNames = default,
            bool? bake = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}