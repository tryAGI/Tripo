
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignFileUploadData
    {
        /// <summary>
        /// Presigned PUT URL valid for 30 minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presigned_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresignedUrl { get; set; }

        /// <summary>
        /// File reference token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileToken { get; set; }

        /// <summary>
        /// Presigned URL validity in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignFileUploadData" /> class.
        /// </summary>
        /// <param name="presignedUrl">
        /// Presigned PUT URL valid for 30 minutes.
        /// </param>
        /// <param name="fileToken">
        /// File reference token.
        /// </param>
        /// <param name="expiresIn">
        /// Presigned URL validity in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignFileUploadData(
            string presignedUrl,
            string fileToken,
            int expiresIn)
        {
            this.PresignedUrl = presignedUrl ?? throw new global::System.ArgumentNullException(nameof(presignedUrl));
            this.FileToken = fileToken ?? throw new global::System.ArgumentNullException(nameof(fileToken));
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignFileUploadData" /> class.
        /// </summary>
        public PresignFileUploadData()
        {
        }

    }
}