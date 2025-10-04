using ZApi.Models;

namespace ZApi.Contracts
{
    public interface IContacts
    {
        Task<IEnumerable<ZapiContact>> GetContacts(int page, int pageSize);
        Task<ZapiResponse> Add(IEnumerable<AddContactRequest> contacts);
        Task<ZapiResponse> Remove(IEnumerable<string> phoneNumbers);
        Task<ZapiContact> GetMetadata(string phone);
        Task<string> GetProfilePicture(string phone);
        Task<bool> CheckIfExists(string phone);
        Task<IEnumerable<PhonesExistsInBatch>> CheckIfExistsInBatch(string[] phones);
        Task<bool> ModifyBlocked(ModifyBlockedRequest request);
        Task<ZapiResponse> Report(string phone);
    }
}

