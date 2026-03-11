
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3TypeJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Tripo.CreateTaskRequestVariant3File> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3ModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Tripo.CreateTaskRequestVariant3Mode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3ModelVersionJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant3ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orthographic_projection")]
        public bool? OrthographicProjection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="files"></param>
        /// <param name="mode"></param>
        /// <param name="modelVersion"></param>
        /// <param name="orthographicProjection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequestVariant3(
            global::System.Collections.Generic.IList<global::Tripo.CreateTaskRequestVariant3File> files,
            global::Tripo.CreateTaskRequestVariant3Mode mode,
            global::Tripo.CreateTaskRequestVariant3Type type,
            global::Tripo.CreateTaskRequestVariant3ModelVersion? modelVersion,
            bool? orthographicProjection)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Mode = mode;
            this.Type = type;
            this.ModelVersion = modelVersion;
            this.OrthographicProjection = orthographicProjection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant3" /> class.
        /// </summary>
        public CreateTaskRequestVariant3()
        {
        }
    }
}