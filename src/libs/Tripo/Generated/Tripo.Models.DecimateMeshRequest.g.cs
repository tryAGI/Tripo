
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DecimateMeshRequest
    {
        /// <summary>
        /// Model source. Accepts task_id or file_token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Decimation model version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Target polycount, in the range 1000-20000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// Output a quad mesh.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quad")]
        public bool? Quad { get; set; }

        /// <summary>
        /// List of part names to decimate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_names")]
        public global::System.Collections.Generic.IList<string>? PartNames { get; set; }

        /// <summary>
        /// Bake textures onto the low-poly model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bake")]
        public bool? Bake { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimateMeshRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="model">
        /// Decimation model version.
        /// </param>
        /// <param name="faceLimit">
        /// Target polycount, in the range 1000-20000.
        /// </param>
        /// <param name="quad">
        /// Output a quad mesh.
        /// </param>
        /// <param name="partNames">
        /// List of part names to decimate.
        /// </param>
        /// <param name="bake">
        /// Bake textures onto the low-poly model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecimateMeshRequest(
            string input,
            string? model,
            int? faceLimit,
            bool? quad,
            global::System.Collections.Generic.IList<string>? partNames,
            bool? bake)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.FaceLimit = faceLimit;
            this.Quad = quad;
            this.PartNames = partNames;
            this.Bake = bake;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimateMeshRequest" /> class.
        /// </summary>
        public DecimateMeshRequest()
        {
        }

    }
}