#nullable enable

namespace Tripo
{
    public partial interface ITripoApi
    {
        /// <summary>
        /// get user balance
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.GetBalanceResponse> GetBalanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}