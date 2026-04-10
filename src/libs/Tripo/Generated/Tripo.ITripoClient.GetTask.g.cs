#nullable enable

namespace Tripo
{
    public partial interface ITripoClient
    {
        /// <summary>
        /// use the task_id created by createTask to get the status of a task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.GetTaskResponse> GetTaskAsync(
            string taskId,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}