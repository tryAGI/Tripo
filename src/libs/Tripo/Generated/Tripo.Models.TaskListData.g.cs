
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskListData
    {
        /// <summary>
        /// Map of task details keyed by task ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Tripo.Task> Tasks { get; set; }

        /// <summary>
        /// Task IDs that were not found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Missed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListData" /> class.
        /// </summary>
        /// <param name="tasks">
        /// Map of task details keyed by task ID.
        /// </param>
        /// <param name="missed">
        /// Task IDs that were not found.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskListData(
            global::System.Collections.Generic.Dictionary<string, global::Tripo.Task> tasks,
            global::System.Collections.Generic.IList<string> missed)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.Missed = missed ?? throw new global::System.ArgumentNullException(nameof(missed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListData" /> class.
        /// </summary>
        public TaskListData()
        {
        }

    }
}