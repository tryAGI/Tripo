
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// AI model version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

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
        /// AI model version.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextureModelRequest(
            string input,
            string? model,
            int? textureSeed,
            string? textureQuality,
            bool? pbr)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.TextureSeed = textureSeed;
            this.TextureQuality = textureQuality;
            this.Pbr = pbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureModelRequest" /> class.
        /// </summary>
        public TextureModelRequest()
        {
        }

    }
}