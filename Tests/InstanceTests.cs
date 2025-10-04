using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapiSdk;
using ZApi.Contracts;

namespace Tests;

[TestClass]
public class InstanceTests
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
    public async Task GetQrCode_WithValidRequest_ReturnBase64()
    {
        var response = await _zapi.Instance.GetQrCodeImage();

        Assert.IsNotNull(response);
        Assert.IsFalse(string.IsNullOrEmpty(response), "QrCode should not be null or empty.");
        Assert.AreEqual("data",response.Substring(0,4));
    }
}
