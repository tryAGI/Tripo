#nullable enable

namespace Tripo
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Convert a 3D model to another format
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> ConvertModelAsync(

            global::Tripo.ConvertModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a 3D model to another format
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> ConvertModelAsResponseAsync(

            global::Tripo.ConvertModelRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert a 3D model to another format
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="format">
        /// Target format, such as GLTF, USDZ, FBX, OBJ, STL, or 3MF.
        /// </param>
        /// <param name="quad">
        /// Quad remeshing.
        /// </param>
        /// <param name="forceSymmetry">
        /// Force symmetry. Only valid when quad is true.
        /// </param>
        /// <param name="faceLimit">
        /// Maximum polycount. If omitted, the original face count is preserved.
        /// </param>
        /// <param name="flattenBottom">
        /// Flatten bottom.
        /// </param>
        /// <param name="flattenBottomThreshold">
        /// Flattening depth threshold.
        /// </param>
        /// <param name="textureSize">
        /// Diffuse texture size in pixels.
        /// </param>
        /// <param name="textureFormat">
        /// Texture format, such as BMP, DPX, HDR, JPEG, PNG, TARGA, TIFF, or WEBP.
        /// </param>
        /// <param name="bake">
        /// Bake advanced materials into base textures.
        /// </param>
        /// <param name="packUv">
        /// Pack all UVs into a unified layout.
        /// </param>
        /// <param name="exportVertexColors">
        /// Include vertex colors. Only valid for OBJ and GLTF formats.
        /// </param>
        /// <param name="pivotToCenterBottom">
        /// Move the pivot to the bottom center.
        /// </param>
        /// <param name="scaleFactor">
        /// Scale factor.
        /// </param>
        /// <param name="withAnimation">
        /// Include skeleton and animation data.
        /// </param>
        /// <param name="animateInPlace">
        /// In-place animation.
        /// </param>
        /// <param name="partNames">
        /// Names of parts to export, from mesh/segment data.
        /// </param>
        /// <param name="exportOrientation">
        /// Export orientation, such as -x, -y, or +y.
        /// </param>
        /// <param name="fbxPreset">
        /// FBX preset for compatibility, such as blender, 3dsmax, or mixamo.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> ConvertModelAsync(
            string input,
            string format,
            bool? quad = default,
            bool? forceSymmetry = default,
            int? faceLimit = default,
            bool? flattenBottom = default,
            double? flattenBottomThreshold = default,
            int? textureSize = default,
            string? textureFormat = default,
            bool? bake = default,
            bool? packUv = default,
            bool? exportVertexColors = default,
            bool? pivotToCenterBottom = default,
            double? scaleFactor = default,
            bool? withAnimation = default,
            bool? animateInPlace = default,
            global::System.Collections.Generic.IList<string>? partNames = default,
            string? exportOrientation = default,
            string? fbxPreset = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}