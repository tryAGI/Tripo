#nullable enable

namespace Tripo
{
    public partial interface ITripoApi
    {
        /// <summary>
        /// upload a file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.UploadFileResponse> UploadFileAsync(
            global::Tripo.UploadFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// upload a file
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.UploadFileResponse> UploadFileAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}