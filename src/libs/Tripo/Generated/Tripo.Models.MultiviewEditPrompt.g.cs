
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiviewEditPrompt
    {
        /// <summary>
        /// Target view, one of front, left, back, or right.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string View { get; set; }

        /// <summary>
        /// Edit instruction, up to 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiviewEditPrompt" /> class.
        /// </summary>
        /// <param name="view">
        /// Target view, one of front, left, back, or right.
        /// </param>
        /// <param name="prompt">
        /// Edit instruction, up to 1024 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiviewEditPrompt(
            string view,
            string prompt)
        {
            this.View = view ?? throw new global::System.ArgumentNullException(nameof(view));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiviewEditPrompt" /> class.
        /// </summary>
        public MultiviewEditPrompt()
        {
        }

    }
}