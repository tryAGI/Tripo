#nullable enable

namespace Tripo
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file and obtain a file_token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.FileResponse> UploadFileAsync(

            global::Tripo.UploadFileRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file and obtain a file_token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.FileResponse>> UploadFileAsResponseAsync(

            global::Tripo.UploadFileRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file and obtain a file_token
        /// </summary>
        /// <param name="file">
        /// File data. Images support JPEG/PNG, up to 20 MB. Models support GLB/GLTF/FBX/OBJ/STL, up to 150 MB.
        /// </param>
        /// <param name="filename">
        /// File data. Images support JPEG/PNG, up to 20 MB. Models support GLB/GLTF/FBX/OBJ/STL, up to 150 MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.FileResponse> UploadFileAsync(
            byte[] file,
            string filename,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file and obtain a file_token
        /// </summary>
        /// <param name="file">
        /// File data. Images support JPEG/PNG, up to 20 MB. Models support GLB/GLTF/FBX/OBJ/STL, up to 150 MB.
        /// </param>
        /// <param name="filename">
        /// File data. Images support JPEG/PNG, up to 20 MB. Models support GLB/GLTF/FBX/OBJ/STL, up to 150 MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.FileResponse> UploadFileAsync(
            global::System.IO.Stream file,
            string filename,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file and obtain a file_token
        /// </summary>
        /// <param name="file">
        /// File data. Images support JPEG/PNG, up to 20 MB. Models support GLB/GLTF/FBX/OBJ/STL, up to 150 MB.
        /// </param>
        /// <param name="filename">
        /// File data. Images support JPEG/PNG, up to 20 MB. Models support GLB/GLTF/FBX/OBJ/STL, up to 150 MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.FileResponse>> UploadFileAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}