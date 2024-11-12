
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant4TypeJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_model_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DraftModelTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="draftModelTaskId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateTaskRequestVariant4(
            string draftModelTaskId,
            global::Tripo.CreateTaskRequestVariant4Type type)
        {
            this.DraftModelTaskId = draftModelTaskId ?? throw new global::System.ArgumentNullException(nameof(draftModelTaskId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant4" /> class.
        /// </summary>
        public CreateTaskRequestVariant4()
        {
        }
    }
}