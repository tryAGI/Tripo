
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetargetAnimationRequest
    {
        /// <summary>
        /// task_id of the rigged model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// V2-compatible source rig task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        public string? OriginalModelTaskId { get; set; }

        /// <summary>
        /// Single preset animation identifier. Mutually exclusive with animations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        public string? Animation { get; set; }

        /// <summary>
        /// List of multiple preset animation identifiers. Mutually exclusive with animation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animations")]
        public global::System.Collections.Generic.IList<string>? Animations { get; set; }

        /// <summary>
        /// Output format, such as glb or fbx.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_format")]
        public string? OutFormat { get; set; }

        /// <summary>
        /// Bake the animation into the model. Only effective for glb output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bake_animation")]
        public bool? BakeAnimation { get; set; }

        /// <summary>
        /// Export with geometry included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_with_geometry")]
        public bool? ExportWithGeometry { get; set; }

        /// <summary>
        /// Play the animation in place without displacement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animate_in_place")]
        public bool? AnimateInPlace { get; set; }

        /// <summary>
        /// Generate a rendered animation preview video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_video")]
        public bool? RenderVideo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetargetAnimationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// task_id of the rigged model.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source rig task ID.
        /// </param>
        /// <param name="animation">
        /// Single preset animation identifier. Mutually exclusive with animations.
        /// </param>
        /// <param name="animations">
        /// List of multiple preset animation identifiers. Mutually exclusive with animation.
        /// </param>
        /// <param name="outFormat">
        /// Output format, such as glb or fbx.
        /// </param>
        /// <param name="bakeAnimation">
        /// Bake the animation into the model. Only effective for glb output.
        /// </param>
        /// <param name="exportWithGeometry">
        /// Export with geometry included.
        /// </param>
        /// <param name="animateInPlace">
        /// Play the animation in place without displacement.
        /// </param>
        /// <param name="renderVideo">
        /// Generate a rendered animation preview video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetargetAnimationRequest(
            string? input,
            string? originalModelTaskId,
            string? animation,
            global::System.Collections.Generic.IList<string>? animations,
            string? outFormat,
            bool? bakeAnimation,
            bool? exportWithGeometry,
            bool? animateInPlace,
            bool? renderVideo)
        {
            this.Input = input;
            this.OriginalModelTaskId = originalModelTaskId;
            this.Animation = animation;
            this.Animations = animations;
            this.OutFormat = outFormat;
            this.BakeAnimation = bakeAnimation;
            this.ExportWithGeometry = exportWithGeometry;
            this.AnimateInPlace = animateInPlace;
            this.RenderVideo = renderVideo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetargetAnimationRequest" /> class.
        /// </summary>
        public RetargetAnimationRequest()
        {
        }

    }
}