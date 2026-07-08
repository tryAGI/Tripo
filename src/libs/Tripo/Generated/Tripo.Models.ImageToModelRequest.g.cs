
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToModelRequest
    {
        /// <summary>
        /// Image source. Accepts a file token, URL, or task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Automatically improve low-quality input images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_image_autofix")]
        public bool? EnableImageAutofix { get; set; }

        /// <summary>
        /// Texture alignment priority, such as original_image or geometry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_alignment")]
        public string? TextureAlignment { get; set; }

        /// <summary>
        /// Model orientation, such as default or align_image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orientation")]
        public string? Orientation { get; set; }

        /// <summary>
        /// AI model version, for example tripo-p1, tripo-turbo, tripo-v3.1, tripo-v3.0, tripo-v2.5, or tripo-v2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Random seed for geometry generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_seed")]
        public int? ModelSeed { get; set; }

        /// <summary>
        /// Maximum polycount for the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// Enable texture maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture")]
        public bool? Texture { get; set; }

        /// <summary>
        /// Enable PBR materials. When enabled, texture is forced to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr")]
        public bool? Pbr { get; set; }

        /// <summary>
        /// Random seed for texture generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_seed")]
        public int? TextureSeed { get; set; }

        /// <summary>
        /// Texture quality, such as standard, detailed, or extreme. Extreme can produce 8K textures where supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_quality")]
        public string? TextureQuality { get; set; }

        /// <summary>
        /// Geometry quality, such as standard or detailed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geometry_quality")]
        public string? GeometryQuality { get; set; }

        /// <summary>
        /// Automatically scale the model to real-world dimensions in meters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_size")]
        public bool? AutoSize { get; set; }

        /// <summary>
        /// Output a quad mesh where supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quad")]
        public bool? Quad { get; set; }

        /// <summary>
        /// Generate a low-poly model with hand-crafted topology style where supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart_low_poly")]
        public bool? SmartLowPoly { get; set; }

        /// <summary>
        /// Generate editable segmented parts where supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_parts")]
        public bool? GenerateParts { get; set; }

        /// <summary>
        /// Compression type, such as geometry for meshopt compression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compress")]
        public string? Compress { get; set; }

        /// <summary>
        /// Control UV unwrapping where supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_uv")]
        public bool? ExportUv { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToModelRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Image source. Accepts a file token, URL, or task ID.
        /// </param>
        /// <param name="enableImageAutofix">
        /// Automatically improve low-quality input images.
        /// </param>
        /// <param name="textureAlignment">
        /// Texture alignment priority, such as original_image or geometry.
        /// </param>
        /// <param name="orientation">
        /// Model orientation, such as default or align_image.
        /// </param>
        /// <param name="model">
        /// AI model version, for example tripo-p1, tripo-turbo, tripo-v3.1, tripo-v3.0, tripo-v2.5, or tripo-v2.0.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToModelRequest(
            string input,
            bool? enableImageAutofix,
            string? textureAlignment,
            string? orientation,
            string? model,
            int? modelSeed,
            int? faceLimit,
            bool? texture,
            bool? pbr,
            int? textureSeed,
            string? textureQuality,
            string? geometryQuality,
            bool? autoSize,
            bool? quad,
            bool? smartLowPoly,
            bool? generateParts,
            string? compress,
            bool? exportUv)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.EnableImageAutofix = enableImageAutofix;
            this.TextureAlignment = textureAlignment;
            this.Orientation = orientation;
            this.Model = model;
            this.ModelSeed = modelSeed;
            this.FaceLimit = faceLimit;
            this.Texture = texture;
            this.Pbr = pbr;
            this.TextureSeed = textureSeed;
            this.TextureQuality = textureQuality;
            this.GeometryQuality = geometryQuality;
            this.AutoSize = autoSize;
            this.Quad = quad;
            this.SmartLowPoly = smartLowPoly;
            this.GenerateParts = generateParts;
            this.Compress = compress;
            this.ExportUv = exportUv;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToModelRequest" /> class.
        /// </summary>
        public ImageToModelRequest()
        {
        }

    }
}