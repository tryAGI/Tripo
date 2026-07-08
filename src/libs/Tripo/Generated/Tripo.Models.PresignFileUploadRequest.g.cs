
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignFileUploadRequest
    {
        /// <summary>
        /// File extension without a leading dot, such as glb, fbx, png, jpg, or webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignFileUploadRequest" /> class.
        /// </summary>
        /// <param name="format">
        /// File extension without a leading dot, such as glb, fbx, png, jpg, or webp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignFileUploadRequest(
            string format)
        {
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignFileUploadRequest" /> class.
        /// </summary>
        public PresignFileUploadRequest()
        {
        }

    }
}