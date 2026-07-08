
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Task
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
        public string? Type { get; set; }

        /// <summary>
        /// Task status, such as queued, running, success, failed, cancelled, banned, or expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Task progress, in the range 0-100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// Task input parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Tripo.TaskOutput? Output { get; set; }

        /// <summary>
        /// Credits consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_consumed")]
        public double? CreditsConsumed { get; set; }

        /// <summary>
        /// Creation time in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Completion time in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Tripo.TaskError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task identifier.
        /// </param>
        /// <param name="status">
        /// Task status, such as queued, running, success, failed, cancelled, banned, or expired.
        /// </param>
        /// <param name="type">
        /// Task type.
        /// </param>
        /// <param name="progress">
        /// Task progress, in the range 0-100.
        /// </param>
        /// <param name="input">
        /// Task input parameters.
        /// </param>
        /// <param name="output"></param>
        /// <param name="creditsConsumed">
        /// Credits consumed.
        /// </param>
        /// <param name="createdAt">
        /// Creation time in ISO 8601 format.
        /// </param>
        /// <param name="completedAt">
        /// Completion time in ISO 8601 format.
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Task(
            string taskId,
            string status,
            string? type,
            int? progress,
            object? input,
            global::Tripo.TaskOutput? output,
            double? creditsConsumed,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            global::Tripo.TaskError? error)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Type = type;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Progress = progress;
            this.Input = input;
            this.Output = output;
            this.CreditsConsumed = creditsConsumed;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        public Task()
        {
        }

    }
}