
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskListRequest
    {
        /// <summary>
        /// List of task IDs to query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TaskIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListRequest" /> class.
        /// </summary>
        /// <param name="taskIds">
        /// List of task IDs to query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskListRequest(
            global::System.Collections.Generic.IList<string> taskIds)
        {
            this.TaskIds = taskIds ?? throw new global::System.ArgumentNullException(nameof(taskIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListRequest" /> class.
        /// </summary>
        public TaskListRequest()
        {
        }

    }
}