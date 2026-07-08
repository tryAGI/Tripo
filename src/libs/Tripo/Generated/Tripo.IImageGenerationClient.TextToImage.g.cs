#nullable enable

namespace Tripo
{
    public partial interface IImageGenerationClient
    {
        /// <summary>
        /// Generate an image from a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> TextToImageAsync(

            global::Tripo.TextToImageRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image from a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tripo.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tripo.AutoSDKHttpResponse<global::Tripo.TaskCreatedResponse>> TextToImageAsResponseAsync(

            global::Tripo.TextToImageRequest request,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image from a text prompt
        /// </summary>
        /// <param name="prompt">
        /// Text prompt, up to 1024 characters.
        /// </param>
        /// <param name="model">
        /// Image model, for example seedream_v5, seedream_v4, gemini-2.5-flash, gemini-3-pro, gemini-3.1-flash, chat_image_1, chat_image_1.5, or chat_image_2.
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
        global::System.Threading.Tasks.Task<global::Tripo.TaskCreatedResponse> TextToImageAsync(
            string prompt,
            string? model = default,
            string? template = default,
            bool? tPose = default,
            bool? sketchToRender = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}