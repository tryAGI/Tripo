
#nullable enable

namespace Tripo
{
    /// <summary>
    /// One multiview image keyed by view name.
    /// </summary>
    public sealed partial class MultiviewViewInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>))]
        public global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? Front { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>))]
        public global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>))]
        public global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? Back { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>))]
        public global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiviewViewInput" /> class.
        /// </summary>
        /// <param name="front"></param>
        /// <param name="left"></param>
        /// <param name="back"></param>
        /// <param name="right"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiviewViewInput(
            global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? front,
            global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? left,
            global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? back,
            global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? right)
        {
            this.Front = front;
            this.Left = left;
            this.Back = back;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiviewViewInput" /> class.
        /// </summary>
        public MultiviewViewInput()
        {
        }

    }
}