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
        /// Text prompt, up to 1800 characters.
        /// </param>
        /// <param name="negativePrompt">
        /// Optional negative prompt.
        /// </param>
        /// <param name="styleImage"></param>
        /// <param name="model">
        /// Image model alias. Supported values include seedream_v5, seedream_v4, banana, banana_pro, banana2, chat_image_1, chat_image_1.5, and chat_image_2. Defaults to seedream_v4.
        /// </param>
        /// <param name="size">
        /// Output image size. Supported values depend on the selected model.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Supported only by banana-family models.
        /// </param>
        /// <param name="outputFormat">
        /// Output image format, png or jpeg.
        /// </param>
        /// <param name="watermark">
        /// Add an AI-generated content watermark where supported.
        /// </param>
        /// <param name="template">
        /// Template name, such as asset_extraction, character_completion, t_pose, variants, or figure.
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
            string? negativePrompt = default,
            global::Tripo.InputSourceObject? styleImage = default,
            string? model = default,
            string? size = default,
            string? aspectRatio = default,
            string? outputFormat = default,
            bool? watermark = default,
            string? template = default,
            bool? tPose = default,
            bool? sketchToRender = default,
            global::Tripo.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}