using Microsoft.Extensions.DependencyInjection;
using ZapiSdk;
using ZApi.Contracts;

namespace Tests;

[TestClass]
public sealed class Test1
{
    private ServiceProvider _serviceProvider;
    private IZApi _zapi;

    [TestInitialize]
    public void Setup()
    {
        var services = new ServiceCollection();
        services.AddZapiInstance(() => new ZApiConfigure
        {
            Instance = "3DF922EBAAE5C08CF2C58E66062CE0C1",
            Token = "B36AEEA0B00DE77F9DCF5554",
            Secret = "F83c6fac6e72d4fa4ae614ab85f6459b6S"
        });

        _serviceProvider = services.BuildServiceProvider();
        _zapi = _serviceProvider.GetService<IZApi>();
        Assert.IsNotNull(_zapi);
    }

    [TestMethod]
    public async Task SendTextMessage_WithValidRequest_ReturnMessageId()
    {
        var response = await _zapi.Messages.SendText(new ZApi.Models.SendTextRequest
        {
            Phone = "5543998051966",
            DelayMessage = 3,
            DelayTyping = 3,
            Message = "Segue seu link: https://www.google.com",
        });

        Assert.IsNotNull(response);
        Assert.IsFalse(string.IsNullOrEmpty(response.Id), "Response.Id should not be null or empty.");
        Assert.IsFalse(string.IsNullOrEmpty(response.ZaapId), "Response.ZaapId should not be null or empty.");
        Assert.IsFalse(string.IsNullOrEmpty(response.MessageId), "Response.MessageId should not be null or empty.");

    }

  


}