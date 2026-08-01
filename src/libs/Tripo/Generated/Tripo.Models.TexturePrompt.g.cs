
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TexturePrompt
    {
        /// <summary>
        /// Text describing the desired texture.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_image")]
        public global::Tripo.InputSourceObject? StyleImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Tripo.InputSourceObject? Image { get; set; }

        /// <summary>
        /// Four reference images in front, left, back, right order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::Tripo.InputSourceObject>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TexturePrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// Text describing the desired texture.
        /// </param>
        /// <param name="styleImage"></param>
        /// <param name="image"></param>
        /// <param name="images">
        /// Four reference images in front, left, back, right order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TexturePrompt(
            string? text,
            global::Tripo.InputSourceObject? styleImage,
            global::Tripo.InputSourceObject? image,
            global::System.Collections.Generic.IList<global::Tripo.InputSourceObject>? images)
        {
            this.Text = text;
            this.StyleImage = styleImage;
            this.Image = image;
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TexturePrompt" /> class.
        /// </summary>
        public TexturePrompt()
        {
        }

    }
}