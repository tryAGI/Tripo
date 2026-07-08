
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentMeshRequest
    {
        /// <summary>
        /// Model source. Accepts task_id, file_token, or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Segmentation model version, such as v1.0-20250506 or v2.0-20260430.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// v2 only. Granularity, such as simple, balanced, or detailed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation_granularity")]
        public string? SegmentationGranularity { get; set; }

        /// <summary>
        /// v2 only. Whether to split by connected components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_by_connectivity")]
        public bool? SplitByConnectivity { get; set; }

        /// <summary>
        /// v2 only. Reference image as file_token or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_image")]
        public string? RefImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentMeshRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id, file_token, or URL.
        /// </param>
        /// <param name="model">
        /// Segmentation model version, such as v1.0-20250506 or v2.0-20260430.
        /// </param>
        /// <param name="segmentationGranularity">
        /// v2 only. Granularity, such as simple, balanced, or detailed.
        /// </param>
        /// <param name="splitByConnectivity">
        /// v2 only. Whether to split by connected components.
        /// </param>
        /// <param name="refImage">
        /// v2 only. Reference image as file_token or URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentMeshRequest(
            string input,
            string? model,
            string? segmentationGranularity,
            bool? splitByConnectivity,
            string? refImage)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.SegmentationGranularity = segmentationGranularity;
            this.SplitByConnectivity = splitByConnectivity;
            this.RefImage = refImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentMeshRequest" /> class.
        /// </summary>
        public SegmentMeshRequest()
        {
        }

    }
}