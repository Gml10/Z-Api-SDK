namespace ZApi.Models;

public class SendButtonActionRequest
{
    /// <summary>
    /// Telefone (ou ID do grupo para casos de envio para grupos) do destinatário no formato DDI DDD NÚMERO Ex: 551199999999. IMPORTANTE Envie somente números, sem formatação ou máscara
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Texto a ser enviado
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a próxima mensagem. O delay default caso não seja informado é de 1~3 sec.
    /// </summary>
    public int? DelayMessage { get; set; }

    /// <summary>
    /// Caso queira enviar um título
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Caso queira enviar um rodapé
    /// </summary>
    public string? Footer { get; set; }

    /// <summary>
    /// Texto do botão (exemplo: "Clique aqui para copiar"). O valor padrão é "Copiar código"
    /// </summary>
    public ButtonAction[] ButtonActions { get; set; } = [];

    public abstract class ButtonAction
    {
        /// <summary>
        /// Identificador do botão
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Tipos de botão a ser enviados (CALL, URL, REPLY)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Texto para o botão
        /// </summary>
        public string Label { get; set; }
    }

    public class UrlButtonAction : ButtonAction
    {
        public UrlButtonAction()
        {
            Type = "URL";
        }
        /// <summary>
        /// Link atribuído ao botão caso seja do tipo URL
        /// </summary>
        public string? Url { get; set; }
    }

    public class CallButtonAction : ButtonAction
    {
        public CallButtonAction()
        {
            Type = "CALL";
        }

        /// <summary>
        /// Número atribuído ao botão caso seja do tipo CALL
        /// </summary>
        public string? Phone { get; set; }
    }

    public class ReplyButtonAction : ButtonAction
    {
        public ReplyButtonAction()
        {
            Type = "REPLY";
        }
    }


}
