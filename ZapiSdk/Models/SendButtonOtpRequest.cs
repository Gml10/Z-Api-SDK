namespace ZapiSdk.Models
{
    public class SendButtonOtpRequest
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
        /// Valor que será copiado quando o botão for clicado
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// URL ou Base64 da imagem que irá acompanhar o botão
        /// </summary>
        public string? Image { get; set; }

        /// <summary>
        /// Texto do botão (exemplo: "Clique aqui para copiar"). O valor padrão é "Copiar código"
        /// </summary>
        public string? ButtonText { get; set; }
    }
}
