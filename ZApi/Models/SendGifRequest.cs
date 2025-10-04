namespace ZApi.Models
{
    public class SendGifRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinat�rio no formato DDI DDD NUMERO Ex: 551199999999. IMPORTANTE Envie somente n�meros, sem formata��o ou m�scara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Link do arquivo do seu GIF (O arquivo precisa ser um mp4)
        /// </summary>
        public string Gif { get; set; }

        /// <summary>
        /// Atributo utilizado para responder uma mensagem do chat, basta adicionar o messageId da mensagem que queira responder neste atributo
        /// </summary>
        public string? MessageId { get; set; }

        /// <summary>
        /// Nesse atributo um delay � adicionado na mensagem. Voc� pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a pr�xima mensagem. (Ex "delayMessage": 5, ). O delay default caso n�o seja informado � de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }

        /// <summary>
        /// Mensagem em que desejar enviar, junto com o gif
        /// </summary>
        public string? Caption { get; set; }
    }
}
