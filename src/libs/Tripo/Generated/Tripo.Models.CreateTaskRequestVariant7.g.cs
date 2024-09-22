
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant7TypeJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant7Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalModelTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_format")]
        public string? OutFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant7AnimationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Tripo.CreateTaskRequestVariant7Animation Animation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}