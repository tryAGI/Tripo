
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToImageRequest
    {
        /// <summary>
        /// Text prompt, up to 1800 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional negative prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_image")]
        public global::Tripo.InputSourceObject? StyleImage { get; set; }

        /// <summary>
        /// Image model alias. Supported values include seedream_v5, seedream_v4, banana, banana_pro, banana2, chat_image_1, chat_image_1.5, and chat_image_2. Defaults to seedream_v4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Output image size. Supported values depend on the selected model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Output aspect ratio. Supported only by banana-family models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Output image format, png or jpeg.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Add an AI-generated content watermark where supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Template name, such as asset_extraction, character_completion, t_pose, variants, or figure.
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
        /// Text prompt, up to 1800 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Optional negative prompt.
        /// </param>
        /// <param name="styleImage"></param>
        /// <param name="model">
        /// Image model alias. Supported values include seedream_v5, seedream_v4, banana, banana_pro, banana2, chat_image_1, chat_image_1.5, and chat_image_2. Defaults to seedream_v4.
        /// </param>
        /// <param name="size">
        /// Output image size. Supported values depend on the selected model.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Supported only by banana-family models.
        /// </param>
        /// <param name="outputFormat">
        /// Output image format, png or jpeg.
        /// </param>
        /// <param name="watermark">
        /// Add an AI-generated content watermark where supported.
        /// </param>
        /// <param name="template">
        /// Template name, such as asset_extraction, character_completion, t_pose, variants, or figure.
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
            string? negativePrompt,
            global::Tripo.InputSourceObject? styleImage,
            string? model,
            string? size,
            string? aspectRatio,
            string? outputFormat,
            bool? watermark,
            string? template,
            bool? tPose,
            bool? sketchToRender)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.StyleImage = styleImage;
            this.Model = model;
            this.Size = size;
            this.AspectRatio = aspectRatio;
            this.OutputFormat = outputFormat;
            this.Watermark = watermark;
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