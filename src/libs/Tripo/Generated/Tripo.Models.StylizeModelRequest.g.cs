
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StylizeModelRequest
    {
        /// <summary>
        /// Model source. Accepts task_id or file_token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Style type, such as lego, voxel, voronoi, or minecraft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Style { get; set; }

        /// <summary>
        /// Grid size, range 32-128. Only valid when style is minecraft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_size")]
        public int? BlockSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StylizeModelRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="style">
        /// Style type, such as lego, voxel, voronoi, or minecraft.
        /// </param>
        /// <param name="blockSize">
        /// Grid size, range 32-128. Only valid when style is minecraft.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StylizeModelRequest(
            string input,
            string style,
            int? blockSize)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.BlockSize = blockSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StylizeModelRequest" /> class.
        /// </summary>
        public StylizeModelRequest()
        {
        }

    }
}