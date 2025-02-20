using ZapiSdk.Models;

namespace ZapiSdk.Contracts
{
    public interface IInstance
    {
        Task<byte[]> GetQrCodeBytes();
        Task<string> GetQrCodeImage();
        Task<string> GetPhoneCode(string phone);
        Task<InstanceStatusResponse> GetStatus();
        Task<bool> RestartInstance(string token);
        Task<bool> UpdateAutoReadMessage(bool value);
        Task Disconnect(string instanceId, string token);
    }
}

