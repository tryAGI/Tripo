
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditMultiviewRequest
    {
        /// <summary>
        /// Source multiview image, file token, URL, or task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Legacy task ID from a successful image-to-multiview task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_task_id")]
        public string? OriginalTaskId { get; set; }

        /// <summary>
        /// One to four per-view edit instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Tripo.MultiviewEditPrompt> Prompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMultiviewRequest" /> class.
        /// </summary>
        /// <param name="prompts">
        /// One to four per-view edit instructions.
        /// </param>
        /// <param name="input">
        /// Source multiview image, file token, URL, or task ID.
        /// </param>
        /// <param name="originalTaskId">
        /// Legacy task ID from a successful image-to-multiview task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditMultiviewRequest(
            global::System.Collections.Generic.IList<global::Tripo.MultiviewEditPrompt> prompts,
            string? input,
            string? originalTaskId)
        {
            this.Input = input;
            this.OriginalTaskId = originalTaskId;
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMultiviewRequest" /> class.
        /// </summary>
        public EditMultiviewRequest()
        {
        }

    }
}