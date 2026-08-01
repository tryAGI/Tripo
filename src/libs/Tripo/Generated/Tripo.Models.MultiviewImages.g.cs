
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiviewImages
    {
        /// <summary>
        /// Front-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_view_url")]
        public string? FrontViewUrl { get; set; }

        /// <summary>
        /// Left-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_view_url")]
        public string? LeftViewUrl { get; set; }

        /// <summary>
        /// Back-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_view_url")]
        public string? BackViewUrl { get; set; }

        /// <summary>
        /// Right-view image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_view_url")]
        public string? RightViewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiviewImages" /> class.
        /// </summary>
        /// <param name="frontViewUrl">
        /// Front-view image URL.
        /// </param>
        /// <param name="leftViewUrl">
        /// Left-view image URL.
        /// </param>
        /// <param name="backViewUrl">
        /// Back-view image URL.
        /// </param>
        /// <param name="rightViewUrl">
        /// Right-view image URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiviewImages(
            string? frontViewUrl,
            string? leftViewUrl,
            string? backViewUrl,
            string? rightViewUrl)
        {
            this.FrontViewUrl = frontViewUrl;
            this.LeftViewUrl = leftViewUrl;
            this.BackViewUrl = backViewUrl;
            this.RightViewUrl = rightViewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiviewImages" /> class.
        /// </summary>
        public MultiviewImages()
        {
        }

    }
}