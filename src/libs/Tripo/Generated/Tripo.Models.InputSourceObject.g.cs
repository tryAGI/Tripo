
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputSourceObject
    {
        /// <summary>
        /// Public URL input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Uploaded file token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_token")]
        public string? FileToken { get; set; }

        /// <summary>
        /// Provider-specific object storage reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public object? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputSourceObject" /> class.
        /// </summary>
        /// <param name="url">
        /// Public URL input.
        /// </param>
        /// <param name="fileToken">
        /// Uploaded file token.
        /// </param>
        /// <param name="object">
        /// Provider-specific object storage reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputSourceObject(
            string? url,
            string? fileToken,
            object? @object)
        {
            this.Url = url;
            this.FileToken = fileToken;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputSourceObject" /> class.
        /// </summary>
        public InputSourceObject()
        {
        }

    }
}