
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteMeshRequest
    {
        /// <summary>
        /// task_id of a mesh/segment task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Completion model version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// List of part names to complete. If omitted, all parts are completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_names")]
        public global::System.Collections.Generic.IList<string>? PartNames { get; set; }

        /// <summary>
        /// V2-compatible source segmentation task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        public string? OriginalModelTaskId { get; set; }

        /// <summary>
        /// Completion mode, ai_completion or quick_cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_mode")]
        public string? CompletionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMeshRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// task_id of a mesh/segment task.
        /// </param>
        /// <param name="model">
        /// Completion model version.
        /// </param>
        /// <param name="partNames">
        /// List of part names to complete. If omitted, all parts are completed.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source segmentation task ID.
        /// </param>
        /// <param name="completionMode">
        /// Completion mode, ai_completion or quick_cap.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteMeshRequest(
            string? input,
            string? model,
            global::System.Collections.Generic.IList<string>? partNames,
            string? originalModelTaskId,
            string? completionMode)
        {
            this.Input = input;
            this.Model = model;
            this.PartNames = partNames;
            this.OriginalModelTaskId = originalModelTaskId;
            this.CompletionMode = completionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMeshRequest" /> class.
        /// </summary>
        public CompleteMeshRequest()
        {
        }

    }
}