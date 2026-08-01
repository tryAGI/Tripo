
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StylizeModelRequest
    {
        /// <summary>
        /// Model source. Accepts task_id or file_token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// V2-compatible source model task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        public string? OriginalModelTaskId { get; set; }

        /// <summary>
        /// Style type, one of lego, voxel, voronoi, minecraft, keyring, fridge_magnet, or keycap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Style { get; set; }

        /// <summary>
        /// Grid size, range 32-128. Only valid when style is minecraft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_size")]
        public int? BlockSize { get; set; }

        /// <summary>
        /// Enable VXC processing. Requires account entitlement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vxc")]
        public bool? Vxc { get; set; }

        /// <summary>
        /// Generate a rendered preview image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_image")]
        public bool? RenderImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StylizeModelRequest" /> class.
        /// </summary>
        /// <param name="style">
        /// Style type, one of lego, voxel, voronoi, minecraft, keyring, fridge_magnet, or keycap.
        /// </param>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source model task ID.
        /// </param>
        /// <param name="blockSize">
        /// Grid size, range 32-128. Only valid when style is minecraft.
        /// </param>
        /// <param name="vxc">
        /// Enable VXC processing. Requires account entitlement.
        /// </param>
        /// <param name="renderImage">
        /// Generate a rendered preview image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StylizeModelRequest(
            string style,
            string? input,
            string? originalModelTaskId,
            int? blockSize,
            bool? vxc,
            bool? renderImage)
        {
            this.Input = input;
            this.OriginalModelTaskId = originalModelTaskId;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.BlockSize = blockSize;
            this.Vxc = vxc;
            this.RenderImage = renderImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StylizeModelRequest" /> class.
        /// </summary>
        public StylizeModelRequest()
        {
        }

    }
}