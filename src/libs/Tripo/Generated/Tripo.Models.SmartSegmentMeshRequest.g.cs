
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmartSegmentMeshRequest
    {
        /// <summary>
        /// Segmentation type: image or model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seg_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegType { get; set; }

        /// <summary>
        /// Input source: file_token or public URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Segmentation granularity: coarse, medium, or fine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public string? Granularity { get; set; }

        /// <summary>
        /// Optional hint to help identify parts to segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// Required when seg_type=model. Column-major 4x4 transform matrix with 16 floats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        public global::System.Collections.Generic.IList<double>? Transform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartSegmentMeshRequest" /> class.
        /// </summary>
        /// <param name="segType">
        /// Segmentation type: image or model.
        /// </param>
        /// <param name="input">
        /// Input source: file_token or public URL.
        /// </param>
        /// <param name="granularity">
        /// Segmentation granularity: coarse, medium, or fine.
        /// </param>
        /// <param name="hint">
        /// Optional hint to help identify parts to segment.
        /// </param>
        /// <param name="transform">
        /// Required when seg_type=model. Column-major 4x4 transform matrix with 16 floats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmartSegmentMeshRequest(
            string segType,
            string input,
            string? granularity,
            string? hint,
            global::System.Collections.Generic.IList<double>? transform)
        {
            this.SegType = segType ?? throw new global::System.ArgumentNullException(nameof(segType));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Granularity = granularity;
            this.Hint = hint;
            this.Transform = transform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartSegmentMeshRequest" /> class.
        /// </summary>
        public SmartSegmentMeshRequest()
        {
        }

    }
}