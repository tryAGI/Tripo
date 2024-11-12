#nullable enable

namespace Tripo
{
    public partial interface ITripoApi
    {
        /// <summary>
        /// use the task_id created by createTask to get the status of a task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.GetTaskResponse> GetTaskAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}