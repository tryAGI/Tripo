#nullable enable

namespace Tripo
{
    public partial interface IThreeDGenerationClient
    {
        /// <summary>
        /// Generate a 3D model from a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> TextToModelAsync(

            global::Tripo.TextToModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> TextToModelAsResponseAsync(

            global::Tripo.TextToModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from a text prompt
        /// </summary>
        /// <param name="prompt">
        /// Text prompt, up to 1024 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Negative prompt, up to 255 characters.
        /// </param>
        /// <param name="imageSeed">
        /// Random seed for the text-to-image stage.
        /// </param>
        /// <param name="model">
        /// Required AI model version. Supported values are v3.1-20260211, v3.0-20250812, v2.5-20250123, and P1-20260311.
        /// </param>
        /// <param name="modelSeed">
        /// Random seed for geometry generation.
        /// </param>
        /// <param name="faceLimit">
        /// Maximum polycount for the output.
        /// </param>
        /// <param name="texture">
        /// Enable texture maps.
        /// </param>
        /// <param name="pbr">
        /// Enable PBR materials. When enabled, texture is forced to true.
        /// </param>
        /// <param name="textureSeed">
        /// Random seed for texture generation.
        /// </param>
        /// <param name="textureQuality">
        /// Texture quality, such as standard, detailed, or extreme. Extreme can produce 8K textures where supported.
        /// </param>
        /// <param name="geometryQuality">
        /// Geometry quality, such as standard or detailed.
        /// </param>
        /// <param name="autoSize">
        /// Automatically scale the model to real-world dimensions in meters.
        /// </param>
        /// <param name="quad">
        /// Output a quad mesh where supported.
        /// </param>
        /// <param name="smartLowPoly">
        /// Generate a low-poly model with hand-crafted topology style where supported.
        /// </param>
        /// <param name="generateParts">
        /// Generate editable segmented parts where supported.
        /// </param>
        /// <param name="compress">
        /// Compression type, such as geometry for meshopt compression.
        /// </param>
        /// <param name="exportUv">
        /// Control UV unwrapping where supported.
        /// </param>
        /// <param name="returnMultiview">
        /// Include generated multiview images in the task output.
        /// </param>
        /// <param name="renderSequence">
        /// Generate a rendered image sequence.
        /// </param>
        /// <param name="renderVideo">
        /// Generate a rendered preview video.
        /// </param>
        /// <param name="checkPrintable">
        /// Check whether the generated model is suitable for 3D printing. Requires account entitlement.
        /// </param>
        /// <param name="styleImage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> TextToModelAsync(
            string prompt,
            string model,
            string? negativePrompt = default,
            int? imageSeed = default,
            int? modelSeed = default,
            int? faceLimit = default,
            bool? texture = default,
            bool? pbr = default,
            int? textureSeed = default,
            string? textureQuality = default,
            string? geometryQuality = default,
            bool? autoSize = default,
            bool? quad = default,
            bool? smartLowPoly = default,
            bool? generateParts = default,
            string? compress = default,
            bool? exportUv = default,
            bool? returnMultiview = default,
            bool? renderSequence = default,
            bool? renderVideo = default,
            bool? checkPrintable = default,
            global::Tripo.InputSourceObject? styleImage = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}