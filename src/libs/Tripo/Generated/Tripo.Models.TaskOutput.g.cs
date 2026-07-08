
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskOutput
    {
        /// <summary>
        /// Signed 3D model download URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_url")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// Signed 3D model download URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_urls")]
        public global::System.Collections.Generic.IList<string>? ModelUrls { get; set; }

        /// <summary>
        /// Rendered preview image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_image_url")]
        public string? RenderedImageUrl { get; set; }

        /// <summary>
        /// Generated image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Generated image URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        public global::System.Collections.Generic.IList<string>? ImageUrls { get; set; }

        /// <summary>
        /// Front-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_view_url")]
        public string? FrontViewUrl { get; set; }

        /// <summary>
        /// Left-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_view_url")]
        public string? LeftViewUrl { get; set; }

        /// <summary>
        /// Back-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_view_url")]
        public string? BackViewUrl { get; set; }

        /// <summary>
        /// Right-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_view_url")]
        public string? RightViewUrl { get; set; }

        /// <summary>
        /// Generated Gaussian Splat file URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splat_url")]
        public string? SplatUrl { get; set; }

        /// <summary>
        /// PNG semantic mask URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_url")]
        public string? MaskUrl { get; set; }

        /// <summary>
        /// Segmented GLB model URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seg_model_url")]
        public string? SegModelUrl { get; set; }

        /// <summary>
        /// Internal mesh segmentation sub-task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seg_task_id")]
        public string? SegTaskId { get; set; }

        /// <summary>
        /// Internal model generation/import sub-task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_task_id")]
        public string? ModelTaskId { get; set; }

        /// <summary>
        /// Generated prompt or labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Whether the model is riggable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("riggable")]
        public bool? Riggable { get; set; }

        /// <summary>
        /// Recommended rig type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rig_type")]
        public string? RigType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        /// <param name="modelUrl">
        /// Signed 3D model download URL.
        /// </param>
        /// <param name="modelUrls">
        /// Signed 3D model download URLs.
        /// </param>
        /// <param name="renderedImageUrl">
        /// Rendered preview image URL.
        /// </param>
        /// <param name="imageUrl">
        /// Generated image URL.
        /// </param>
        /// <param name="imageUrls">
        /// Generated image URLs.
        /// </param>
        /// <param name="frontViewUrl">
        /// Front-view image URL.
        /// </param>
        /// <param name="leftViewUrl">
        /// Left-view image URL.
        /// </param>
        /// <param name="backViewUrl">
        /// Back-view image URL.
        /// </param>
        /// <param name="rightViewUrl">
        /// Right-view image URL.
        /// </param>
        /// <param name="splatUrl">
        /// Generated Gaussian Splat file URL.
        /// </param>
        /// <param name="maskUrl">
        /// PNG semantic mask URL.
        /// </param>
        /// <param name="segModelUrl">
        /// Segmented GLB model URL.
        /// </param>
        /// <param name="segTaskId">
        /// Internal mesh segmentation sub-task ID.
        /// </param>
        /// <param name="modelTaskId">
        /// Internal model generation/import sub-task ID.
        /// </param>
        /// <param name="prompt">
        /// Generated prompt or labels.
        /// </param>
        /// <param name="riggable">
        /// Whether the model is riggable.
        /// </param>
        /// <param name="rigType">
        /// Recommended rig type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskOutput(
            string? modelUrl,
            global::System.Collections.Generic.IList<string>? modelUrls,
            string? renderedImageUrl,
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? imageUrls,
            string? frontViewUrl,
            string? leftViewUrl,
            string? backViewUrl,
            string? rightViewUrl,
            string? splatUrl,
            string? maskUrl,
            string? segModelUrl,
            string? segTaskId,
            string? modelTaskId,
            string? prompt,
            bool? riggable,
            string? rigType)
        {
            this.ModelUrl = modelUrl;
            this.ModelUrls = modelUrls;
            this.RenderedImageUrl = renderedImageUrl;
            this.ImageUrl = imageUrl;
            this.ImageUrls = imageUrls;
            this.FrontViewUrl = frontViewUrl;
            this.LeftViewUrl = leftViewUrl;
            this.BackViewUrl = backViewUrl;
            this.RightViewUrl = rightViewUrl;
            this.SplatUrl = splatUrl;
            this.MaskUrl = maskUrl;
            this.SegModelUrl = segModelUrl;
            this.SegTaskId = segTaskId;
            this.ModelTaskId = modelTaskId;
            this.Prompt = prompt;
            this.Riggable = riggable;
            this.RigType = rigType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        public TaskOutput()
        {
        }

    }
}