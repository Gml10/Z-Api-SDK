namespace ZApi.Contracts
{
    public interface IZApi
    {
        IMessages Messages { get; }
        IContacts Contacts { get; }
        IInstance Instance { get; }
    }
}
