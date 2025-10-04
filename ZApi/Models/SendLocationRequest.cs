namespace ZApi.Models
{
    public class SendLocationRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinat�rio no formato DDI DDD N�MERO Ex: 551199999999. IMPORTANTE Envie somente n�meros, sem formata��o ou m�scara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Titulo para sua localiza��o ex: Minha casa
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Endere�o da localiza��o que est� enviando composto por logradouro, N�MERO, bairro, cidade, UF e CEP, tudo separado por v�rgula
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Latitude da localiza��o enviada
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude da localiza��o enviada
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Atributo utilizado para responder uma mensagem do chat, basta adicionar o messageId da mensagem que queira responder neste atributo
        /// </summary>
        public string? MessageId { get; set; }

        /// <summary>
        /// Nesse atributo um delay � adicionado na mensagem. Voc� pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a pr�xima mensagem. (Ex "delayMessage": 5, ). O delay default caso n�o seja informado � de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }
    }
}
