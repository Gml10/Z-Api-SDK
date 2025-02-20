namespace ZapiSdk.Contracts
{
    public interface IZapi
    {
        IMessages Messages { get; }
        IContacts Contacts { get; }
        IInstance Instance { get; }
    }
}
