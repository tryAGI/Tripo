
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RigCheckRequest
    {
        /// <summary>
        /// Model source. Accepts task_id, file_token, or a publicly accessible URL to a GLB model file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// V2-compatible source model task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        public string? OriginalModelTaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RigCheckRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id, file_token, or a publicly accessible URL to a GLB model file.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source model task ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RigCheckRequest(
            string? input,
            string? originalModelTaskId)
        {
            this.Input = input;
            this.OriginalModelTaskId = originalModelTaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RigCheckRequest" /> class.
        /// </summary>
        public RigCheckRequest()
        {
        }

    }
}