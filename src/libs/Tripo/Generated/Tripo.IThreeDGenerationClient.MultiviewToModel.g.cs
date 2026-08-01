#nullable enable

namespace Tripo
{
    public partial interface IThreeDGenerationClient
    {
        /// <summary>
        /// Generate a 3D model from multiview images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> MultiviewToModelAsync(

            global::Tripo.MultiviewToModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from multiview images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> MultiviewToModelAsResponseAsync(

            global::Tripo.MultiviewToModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from multiview images
        /// </summary>
        /// <param name="inputs">
        /// Multiview images. Use either view-key objects, a four item positional array, or a single task_id object.
        /// </param>
        /// <param name="originalModelTaskId">
        /// Task ID from previous multiview generation. Mutually exclusive with inputs. This is the V3 name for V2's original_task_id field.
        /// </param>
        /// <param name="files">
        /// Legacy four-slot input array in front, left, back, right order. Use empty objects for omitted views.
        /// </param>
        /// <param name="textureAlignment">
        /// Texture alignment priority, such as original_image or geometry.
        /// </param>
        /// <param name="orientation">
        /// Model orientation, such as default or align_image.
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
        /// <param name="orthographicProjection">
        /// Treat the supplied views as orthographic projections.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> MultiviewToModelAsync(
            string model,
            global::System.Collections.Generic.IList<global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>>? inputs = default,
            string? originalModelTaskId = default,
            global::System.Collections.Generic.IList<global::Tripo.InputSourceObject>? files = default,
            string? textureAlignment = default,
            string? orientation = default,
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
            bool? orthographicProjection = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}