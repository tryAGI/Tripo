
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToModelRequest
    {
        /// <summary>
        /// Text prompt, up to 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Negative prompt, up to 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Random seed for the text-to-image stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_seed")]
        public int? ImageSeed { get; set; }

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
        /// Initializes a new instance of the <see cref="TextToModelRequest" /> class.
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
        public TextToModelRequest(
            string prompt,
            string? negativePrompt,
            int? imageSeed,
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
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.ImageSeed = imageSeed;
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
        /// Initializes a new instance of the <see cref="TextToModelRequest" /> class.
        /// </summary>
        public TextToModelRequest()
        {
        }

    }
}