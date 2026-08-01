#nullable enable

namespace Tripo
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Regenerate texture maps for an existing model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> TextureModelAsync(

            global::Tripo.TextureModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate texture maps for an existing model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> TextureModelAsResponseAsync(

            global::Tripo.TextureModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate texture maps for an existing model
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id, file_token, or URL.
        /// </param>
        /// <param name="model">
        /// Texture model version, v3.0-20250812 or v2.5-20250123. Defaults to v3.0-20250812.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source model task ID.
        /// </param>
        /// <param name="texturePrompt"></param>
        /// <param name="texture">
        /// Enable texture maps.
        /// </param>
        /// <param name="textureSeed">
        /// Random seed for texture generation.
        /// </param>
        /// <param name="textureQuality">
        /// Texture quality, such as standard, detailed, or extreme.
        /// </param>
        /// <param name="pbr">
        /// Enable PBR materials.
        /// </param>
        /// <param name="textureAlignment">
        /// Texture alignment priority, original_image or geometry.
        /// </param>
        /// <param name="partNames">
        /// Names of segmented parts to texture.
        /// </param>
        /// <param name="compress">
        /// Compression type, such as geometry.
        /// </param>
        /// <param name="bake">
        /// Bake advanced material effects into base textures.
        /// </param>
        /// <param name="returnMultiview">
        /// Include generated multiview images in the task output.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> TextureModelAsync(
            string? input = default,
            string? model = default,
            string? originalModelTaskId = default,
            global::Tripo.TexturePrompt? texturePrompt = default,
            bool? texture = default,
            int? textureSeed = default,
            string? textureQuality = default,
            bool? pbr = default,
            string? textureAlignment = default,
            global::System.Collections.Generic.IList<string>? partNames = default,
            string? compress = default,
            bool? bake = default,
            bool? returnMultiview = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}