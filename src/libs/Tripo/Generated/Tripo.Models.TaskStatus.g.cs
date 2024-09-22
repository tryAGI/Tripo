
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Banned,
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskStatus value)
        {
            return value switch
            {
                TaskStatus.Queued => "queued",
                TaskStatus.Running => "running",
                TaskStatus.Success => "success",
                TaskStatus.Failed => "failed",
                TaskStatus.Cancelled => "cancelled",
                TaskStatus.Unknown => "unknown",
                TaskStatus.Banned => "banned",
                TaskStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => TaskStatus.Queued,
                "running" => TaskStatus.Running,
                "success" => TaskStatus.Success,
                "failed" => TaskStatus.Failed,
                "cancelled" => TaskStatus.Cancelled,
                "unknown" => TaskStatus.Unknown,
                "banned" => TaskStatus.Banned,
                "expired" => TaskStatus.Expired,
                _ => null,
            };
        }
    }
}