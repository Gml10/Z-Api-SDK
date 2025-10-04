namespace ZApi.Models
{
    public class MessageSendResponse : ZapiResponse
    {
        /// <summary>
        /// Adicionado para compatibilidade com zapier, ele tem o mesmo valor do messageId
        /// </summary>
        public string ZaapId { get; set; }

        /// <summary>
        /// id no whatsapp
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// id no z-api
        /// </summary>
        public string Id { get; set; }
    }
}
