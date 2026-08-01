
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextureModelRequest
    {
        /// <summary>
        /// Model source. Accepts task_id, file_token, or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Texture model version, v3.0-20250812 or v2.5-20250123. Defaults to v3.0-20250812.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// V2-compatible source model task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        public string? OriginalModelTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_prompt")]
        public global::Tripo.TexturePrompt? TexturePrompt { get; set; }

        /// <summary>
        /// Enable texture maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture")]
        public bool? Texture { get; set; }

        /// <summary>
        /// Random seed for texture generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_seed")]
        public int? TextureSeed { get; set; }

        /// <summary>
        /// Texture quality, such as standard, detailed, or extreme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_quality")]
        public string? TextureQuality { get; set; }

        /// <summary>
        /// Enable PBR materials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr")]
        public bool? Pbr { get; set; }

        /// <summary>
        /// Texture alignment priority, original_image or geometry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_alignment")]
        public string? TextureAlignment { get; set; }

        /// <summary>
        /// Names of segmented parts to texture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_names")]
        public global::System.Collections.Generic.IList<string>? PartNames { get; set; }

        /// <summary>
        /// Compression type, such as geometry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compress")]
        public string? Compress { get; set; }

        /// <summary>
        /// Bake advanced material effects into base textures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bake")]
        public bool? Bake { get; set; }

        /// <summary>
        /// Include generated multiview images in the task output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_multiview")]
        public bool? ReturnMultiview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureModelRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextureModelRequest(
            string? input,
            string? model,
            string? originalModelTaskId,
            global::Tripo.TexturePrompt? texturePrompt,
            bool? texture,
            int? textureSeed,
            string? textureQuality,
            bool? pbr,
            string? textureAlignment,
            global::System.Collections.Generic.IList<string>? partNames,
            string? compress,
            bool? bake,
            bool? returnMultiview)
        {
            this.Input = input;
            this.Model = model;
            this.OriginalModelTaskId = originalModelTaskId;
            this.TexturePrompt = texturePrompt;
            this.Texture = texture;
            this.TextureSeed = textureSeed;
            this.TextureQuality = textureQuality;
            this.Pbr = pbr;
            this.TextureAlignment = textureAlignment;
            this.PartNames = partNames;
            this.Compress = compress;
            this.Bake = bake;
            this.ReturnMultiview = returnMultiview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureModelRequest" /> class.
        /// </summary>
        public TextureModelRequest()
        {
        }

    }
}