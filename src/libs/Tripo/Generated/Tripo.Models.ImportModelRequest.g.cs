
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportModelRequest
    {
        /// <summary>
        /// Model file source. Accepts file_token or URL. Supported formats include GLB, GLTF, FBX, OBJ, and STL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportModelRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Model file source. Accepts file_token or URL. Supported formats include GLB, GLTF, FBX, OBJ, and STL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportModelRequest(
            string input)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportModelRequest" /> class.
        /// </summary>
        public ImportModelRequest()
        {
        }

    }
}