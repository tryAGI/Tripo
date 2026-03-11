
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant2TypeJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Tripo.CreateTaskRequestVariant2File File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant2ModelVersionJsonConverter))]
        public global::Tripo.CreateTaskRequestVariant2ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture")]
        public bool? Texture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr")]
        public bool? Pbr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="file"></param>
        /// <param name="modelVersion"></param>
        /// <param name="faceLimit"></param>
        /// <param name="texture"></param>
        /// <param name="pbr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequestVariant2(
            global::Tripo.CreateTaskRequestVariant2File file,
            global::Tripo.CreateTaskRequestVariant2Type type,
            global::Tripo.CreateTaskRequestVariant2ModelVersion? modelVersion,
            int? faceLimit,
            bool? texture,
            bool? pbr)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Type = type;
            this.ModelVersion = modelVersion;
            this.FaceLimit = faceLimit;
            this.Texture = texture;
            this.Pbr = pbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant2" /> class.
        /// </summary>
        public CreateTaskRequestVariant2()
        {
        }
    }
}