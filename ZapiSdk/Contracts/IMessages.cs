using ZapiSdk.Models;

namespace ZapiSdk.Contracts
{
    public interface IMessages
    {
        Task<MessageSendResponse> SendText(SendTextRequest request);
        Task<MessageSendResponse> ForwardMessage(ForwardMessageRequest request);
        Task<MessageSendResponse> SendReaction(ForwardMessageRequest request);
        Task<MessageSendResponse> SendImage(SendImageRequest request);
        Task<MessageSendResponse> SendSticker(SendStickerRequest request);
        Task<MessageSendResponse> SendGif(SendGifRequest request);
        Task<MessageSendResponse> SendAudio(SendAudioRequest request);
        Task<MessageSendResponse> SendVideo(SendVideoRequest request);
        Task<MessageSendResponse> SendPtv(SendPtvRequest request);
        Task<MessageSendResponse> SendDocument(SendDocumentRequest request, string extension);
        Task<MessageSendResponse> SendLink(SendLinkRequest request);
        Task<MessageSendResponse> SendLocation(SendLocationRequest request);
        Task<MessageSendResponse> SendProduct(SendProductRequest request);
        Task<MessageSendResponse> SendButtonOtp(SendButtonOtpRequest request);
    }
}
