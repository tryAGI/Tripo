
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToImageRequest
    {
        /// <summary>
        /// Text prompt, up to 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Image model, for example seedream_v5, seedream_v4, gemini-2.5-flash, gemini-3-pro, gemini-3.1-flash, chat_image_1, chat_image_1.5, or chat_image_2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Template name, such as asset_extraction, character_completion, t_pose, head_extraction, 3d_enhance, variants, print_clay, or figure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// Convert to T-pose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("t_pose")]
        public bool? TPose { get; set; }

        /// <summary>
        /// Convert a sketch to a rendered image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sketch_to_render")]
        public bool? SketchToRender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt, up to 1024 characters.
        /// </param>
        /// <param name="model">
        /// Image model, for example seedream_v5, seedream_v4, gemini-2.5-flash, gemini-3-pro, gemini-3.1-flash, chat_image_1, chat_image_1.5, or chat_image_2.
        /// </param>
        /// <param name="template">
        /// Template name, such as asset_extraction, character_completion, t_pose, head_extraction, 3d_enhance, variants, print_clay, or figure.
        /// </param>
        /// <param name="tPose">
        /// Convert to T-pose.
        /// </param>
        /// <param name="sketchToRender">
        /// Convert a sketch to a rendered image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToImageRequest(
            string prompt,
            string? model,
            string? template,
            bool? tPose,
            bool? sketchToRender)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Template = template;
            this.TPose = tPose;
            this.SketchToRender = sketchToRender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageRequest" /> class.
        /// </summary>
        public TextToImageRequest()
        {
        }

    }
}