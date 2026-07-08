
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToSplatRequest
    {
        /// <summary>
        /// Source image for Gaussian Splat generation. Accepts a file_token or public image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Random seed for Gaussian Splat generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_seed")]
        public int? ModelSeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToSplatRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Source image for Gaussian Splat generation. Accepts a file_token or public image URL.
        /// </param>
        /// <param name="modelSeed">
        /// Random seed for Gaussian Splat generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToSplatRequest(
            string input,
            int? modelSeed)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ModelSeed = modelSeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToSplatRequest" /> class.
        /// </summary>
        public ImageToSplatRequest()
        {
        }

    }
}