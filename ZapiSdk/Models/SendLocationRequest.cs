namespace ZapiSdk.Models
{
    public class SendLocationRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinatário no formato DDI DDD NÚMERO Ex: 551199999999. IMPORTANTE Envie somente números, sem formatação ou máscara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Titulo para sua localização ex: Minha casa
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Endereço da localização que está enviando composto por logradouro, NÚMERO, bairro, cidade, UF e CEP, tudo separado por vírgula
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Latitude da localização enviada
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude da localização enviada
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Atributo utilizado para responder uma mensagem do chat, basta adicionar o messageId da mensagem que queira responder neste atributo
        /// </summary>
        public string? MessageId { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a próxima mensagem. (Ex "delayMessage": 5, ). O delay default caso não seja informado é de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }
    }
}
