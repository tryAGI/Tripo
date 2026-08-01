
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RigModelRequest
    {
        /// <summary>
        /// Model source. Accepts task_id or file_token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// V2-compatible source model task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_model_task_id")]
        public string? OriginalModelTaskId { get; set; }

        /// <summary>
        /// Auto rigging model version, v1.0-20240301 or v2.5-20260210.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Rig type, such as biped, quadruped, hexapod, octopod, avian, serpentine, or aquatic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rig_type")]
        public string? RigType { get; set; }

        /// <summary>
        /// Rigging specification, such as tripo or mixamo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public string? Spec { get; set; }

        /// <summary>
        /// Output format, such as glb or fbx.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("out_format")]
        public string? OutFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RigModelRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Model source. Accepts task_id or file_token.
        /// </param>
        /// <param name="originalModelTaskId">
        /// V2-compatible source model task ID.
        /// </param>
        /// <param name="model">
        /// Auto rigging model version, v1.0-20240301 or v2.5-20260210.
        /// </param>
        /// <param name="rigType">
        /// Rig type, such as biped, quadruped, hexapod, octopod, avian, serpentine, or aquatic.
        /// </param>
        /// <param name="spec">
        /// Rigging specification, such as tripo or mixamo.
        /// </param>
        /// <param name="outFormat">
        /// Output format, such as glb or fbx.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RigModelRequest(
            string? input,
            string? originalModelTaskId,
            string? model,
            string? rigType,
            string? spec,
            string? outFormat)
        {
            this.Input = input;
            this.OriginalModelTaskId = originalModelTaskId;
            this.Model = model;
            this.RigType = rigType;
            this.Spec = spec;
            this.OutFormat = outFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RigModelRequest" /> class.
        /// </summary>
        public RigModelRequest()
        {
        }

    }
}