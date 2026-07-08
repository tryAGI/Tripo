
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageItem
    {
        /// <summary>
        /// Unique task identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Task type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Credits consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_consumed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreditsConsumed { get; set; }

        /// <summary>
        /// Creation time in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task identifier.
        /// </param>
        /// <param name="type">
        /// Task type.
        /// </param>
        /// <param name="creditsConsumed">
        /// Credits consumed.
        /// </param>
        /// <param name="createdAt">
        /// Creation time in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageItem(
            string taskId,
            string type,
            double creditsConsumed,
            global::System.DateTime createdAt)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreditsConsumed = creditsConsumed;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        public UsageItem()
        {
        }

    }
}