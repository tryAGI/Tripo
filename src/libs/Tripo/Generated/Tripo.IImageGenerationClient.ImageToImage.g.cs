#nullable enable

namespace Tripo
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Generate or edit an image from reference images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> ImageToImageAsync(

            global::Tripo.ImageToImageRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or edit an image from reference images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> ImageToImageAsResponseAsync(

            global::Tripo.ImageToImageRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or edit an image from reference images
        /// </summary>
        /// <param name="input">
        /// Reference image. Supports file_token, image URL, or task_id.
        /// </param>
        /// <param name="inputs">
        /// List of multiple reference images.
        /// </param>
        /// <param name="prompt">
        /// Image editing instruction. Required when template is not specified.
        /// </param>
        /// <param name="model">
        /// Image model, for example seedream_v5, gemini-2.5-flash, gemini-3-pro, gemini-3.1-flash, chat_image_1, chat_image_1.5, or chat_image_2.
        /// </param>
        /// <param name="template">
        /// Template name, such as asset_extraction, character_completion, t_pose, head_extraction, 3d_enhance, variants, print_clay, or figure.
        /// </param>
        /// <param name="tPose">
        /// Convert to T-pose.
        /// </param>
        /// <param name="sketchToRender">
        /// Convert a sketch to a rendered image.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> ImageToImageAsync(
            string input,
            global::System.Collections.Generic.IList<string>? inputs = default,
            string? prompt = default,
            string? model = default,
            string? template = default,
            bool? tPose = default,
            bool? sketchToRender = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}