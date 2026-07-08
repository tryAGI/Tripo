
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertModelRequest
    {
        /// <summary>
        /// Model source. Accepts task_id or file_token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Target format, such as GLTF, USDZ, FBX, OBJ, STL, or 3MF.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// Quad remeshing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quad")]
        public bool? Quad { get; set; }

        /// <summary>
        /// Force symmetry. Only valid when quad is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_symmetry")]
        public bool? ForceSymmetry { get; set; }

        /// <summary>
        /// Maximum polycount. If omitted, the original face count is preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// Flatten bottom.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_bottom")]
        public bool? FlattenBottom { get; set; }

        /// <summary>
        /// Flattening depth threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_bottom_threshold")]
        public double? FlattenBottomThreshold { get; set; }

        /// <summary>
        /// Diffuse texture size in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_size")]
        public int? TextureSize { get; set; }

        /// <summary>
        /// Texture format, such as BMP, DPX, HDR, JPEG, PNG, TARGA, TIFF, or WEBP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_format")]
        public string? TextureFormat { get; set; }

        /// <summary>
        /// Bake advanced materials into base textures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bake")]
        public bool? Bake { get; set; }

        /// <summary>
        /// Pack all UVs into a unified layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pack_uv")]
        public bool? PackUv { get; set; }

        /// <summary>
        /// Include vertex colors. Only valid for OBJ and GLTF formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_vertex_colors")]
        public bool? ExportVertexColors { get; set; }

        /// <summary>
        /// Move the pivot to the bottom center.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pivot_to_center_bottom")]
        public bool? PivotToCenterBottom { get; set; }

        /// <summary>
        /// Scale factor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_factor")]
        public double? ScaleFactor { get; set; }

        /// <summary>
        /// Include skeleton and animation data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_animation")]
        public bool? WithAnimation { get; set; }

        /// <summary>
        /// In-place animation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animate_in_place")]
        public bool? AnimateInPlace { get; set; }

        /// <summary>
        /// Names of parts to export, from mesh/segment data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_names")]
        public global::System.Collections.Generic.IList<string>? PartNames { get; set; }

        /// <summary>
        /// Export orientation, such as -x, -y, or +y.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_orientation")]
        public string? ExportOrientation { get; set; }

        /// <summary>
        /// FBX preset for compatibility, such as blender, 3dsmax, or mixamo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fbx_preset")]
        public string? FbxPreset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertModelRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertModelRequest(
            string input,
            string format,
            bool? quad,
            bool? forceSymmetry,
            int? faceLimit,
            bool? flattenBottom,
            double? flattenBottomThreshold,
            int? textureSize,
            string? textureFormat,
            bool? bake,
            bool? packUv,
            bool? exportVertexColors,
            bool? pivotToCenterBottom,
            double? scaleFactor,
            bool? withAnimation,
            bool? animateInPlace,
            global::System.Collections.Generic.IList<string>? partNames,
            string? exportOrientation,
            string? fbxPreset)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Quad = quad;
            this.ForceSymmetry = forceSymmetry;
            this.FaceLimit = faceLimit;
            this.FlattenBottom = flattenBottom;
            this.FlattenBottomThreshold = flattenBottomThreshold;
            this.TextureSize = textureSize;
            this.TextureFormat = textureFormat;
            this.Bake = bake;
            this.PackUv = packUv;
            this.ExportVertexColors = exportVertexColors;
            this.PivotToCenterBottom = pivotToCenterBottom;
            this.ScaleFactor = scaleFactor;
            this.WithAnimation = withAnimation;
            this.AnimateInPlace = animateInPlace;
            this.PartNames = partNames;
            this.ExportOrientation = exportOrientation;
            this.FbxPreset = fbxPreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertModelRequest" /> class.
        /// </summary>
        public ConvertModelRequest()
        {
        }

    }
}