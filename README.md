<h1 align="center">Whatsapp API | Z-Api SDK</h1> 

<p align="center">
<img loading="lazy" src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge"/>
</p>

<p>Z-Api é um serviço de API não oficial para WhatsApp, permitindo o controle da sua conta via API. Com ela, você pode enviar mensagens de texto, imagens, gerenciar grupos e muito mais.</p>

<p>Este SDK não oficial para a plataforma <a href="https://www.z-api.io/">Z-Api</a> foi desenvolvido para simplificar e otimizar a interação com a API, abstraindo todas as chamadas e facilitando a integração.</p>

<h2>Instalação</h2>
<p>Para instalar via NuGet, use o seguinte comando:</p>
<pre><code>NuGet\Install-Package ZapiSdk -Version 0.0.1</code></pre>

<p>No CLI use:</p>
<pre><code>dotnet add package ZapiSdk --version 0.0.1</code></pre>

<h2>Configuração</h2>

<p>Após a instalação, adicione o SDK ao seu projeto utilizando o <code>ServiceCollection</code>:</p>

<pre><code>services.AddZapiInstance(config => {
    Instance = "xxxxxxxx", // (Obrigatório) ID da sua instância
    Secret = "sssssss",    // (Obrigatório) Secret da sua instância
    Token = "ttttttt"      // Token de autenticação (caso ativado). Será enviado no header como "Client-Token".
});</code></pre>

<p>Se necessário, você pode alterar a URL base para a qual as requisições serão enviadas. Caso não seja definida, a aplicação utilizará a URL padrão.</p>

<pre><code>services.AddZapiInstance(config => {
    BaseUrl = "URL"
});
</code></pre>

<h2>Utilização</h2>
<p>A documentação oficial da API pode ser encontrada <a href="https://developer.z-api.io/" target="_blank">AQUI</a>.</p>
<p>O SDK reflete a documentação da API e suas chamadas.</p>
<p>Atualmente, este SDK está em desenvolvimento e algumas funcionalidades podem não estar disponíveis.</p>

<p>Para utilizá-lo em seu projeto, basta injetar a interface base <code>IZApi</code>. Veja um exemplo abaixo:</p>

<pre><code>
public class TesteController : ControllerBase
{
    private readonly IZApi _zapi;

    public TesteController(IZApi zapi)
    {
        _zapi = zapi;
    }

    [HttpGet]
    public async Task<IActionResult> Send()
    {
        var request = new SendTextRequest
        {
            Phone = "554399887766", // Use apenas números no formato DDI + DDD + Telefone
            Message = "Sua mensagem aqui"
        };

        MessageSendResponse response = await _zapi.Messages.SendText(request);

        return Ok(response);
    }
}
</code></pre>


