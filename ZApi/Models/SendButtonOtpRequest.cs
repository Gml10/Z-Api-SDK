namespace ZApi.Models
{
    public class SendButtonOtpRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinat�rio no formato DDI DDD N�MERO Ex: 551199999999. IMPORTANTE Envie somente n�meros, sem formata��o ou m�scara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Texto a ser enviado
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Valor que ser� copiado quando o bot�o for clicado
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// URL ou Base64 da imagem que ir� acompanhar o bot�o
        /// </summary>
        public string? Image { get; set; }

        /// <summary>
        /// Texto do bot�o (exemplo: "Clique aqui para copiar"). O valor padr�o � "Copiar c�digo"
        /// </summary>
        public string? ButtonText { get; set; }
    }
}
