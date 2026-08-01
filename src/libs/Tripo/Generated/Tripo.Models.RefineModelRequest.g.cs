
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RefineModelRequest
    {
        /// <summary>
        /// Draft task_id to refine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// V2-compatible draft task ID. Replaces the retired rough_model_task_id alias.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_model_task_id")]
        public string? DraftModelTaskId { get; set; }

        /// <summary>
        /// AI model version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefineModelRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Draft task_id to refine.
        /// </param>
        /// <param name="draftModelTaskId">
        /// V2-compatible draft task ID. Replaces the retired rough_model_task_id alias.
        /// </param>
        /// <param name="model">
        /// AI model version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefineModelRequest(
            string? input,
            string? draftModelTaskId,
            string? model)
        {
            this.Input = input;
            this.DraftModelTaskId = draftModelTaskId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefineModelRequest" /> class.
        /// </summary>
        public RefineModelRequest()
        {
        }

    }
}