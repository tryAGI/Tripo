
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9TypeJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant9Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9FormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Tripo.CreateTaskRequestVariant9Format Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalModelTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quad")]
        public bool? Quad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_symmetry")]
        public bool? ForceSymmetry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_bottom")]
        public bool? FlattenBottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_bottom_threshold")]
        public double? FlattenBottomThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_size")]
        public int? TextureSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9TextureFormatJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant9TextureFormat? TextureFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pivot_to_center_bottom")]
        public bool? PivotToCenterBottom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}