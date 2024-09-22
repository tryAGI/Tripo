#nullable enable

namespace Tripo
{
    public partial interface ITripoApi
    {
        /// <summary>
        /// create a task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.SuccessTask> CreateTaskAsync(
            global::Tripo.OneOf<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// create a task
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.SuccessTask> CreateTaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}