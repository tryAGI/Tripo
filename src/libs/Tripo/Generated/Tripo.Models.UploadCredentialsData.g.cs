
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCredentialsData
    {
        /// <summary>
        /// Unique file identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileToken { get; set; }

        /// <summary>
        /// Presigned upload URL. The client uploads the file directly with PUT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// Credential expiration time in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCredentialsData" /> class.
        /// </summary>
        /// <param name="fileToken">
        /// Unique file identifier.
        /// </param>
        /// <param name="uploadUrl">
        /// Presigned upload URL. The client uploads the file directly with PUT.
        /// </param>
        /// <param name="expiresAt">
        /// Credential expiration time in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadCredentialsData(
            string fileToken,
            string uploadUrl,
            global::System.DateTime expiresAt)
        {
            this.FileToken = fileToken ?? throw new global::System.ArgumentNullException(nameof(fileToken));
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCredentialsData" /> class.
        /// </summary>
        public UploadCredentialsData()
        {
        }

    }
}