namespace ZapiSdk.Models
{
    public class SendLinkRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinat�rio no formato DDI DDD NUMERO Ex: 551199999999. IMPORTANTE Envie somente n�meros, sem formata��o ou m�scara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Texto sobre seu link. N�o esque�a de informar o mesmo valor do linkURL no final deste texto.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Link da imagem
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Url do seu link
        /// </summary>
        public string LinkUrl { get; set; }

        /// <summary>
        /// Titulo para o link
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descri��o do link
        /// </summary>
        public string LinkDescription { get; set; }

        /// <summary>
        /// Nesse atributo um delay � adicionado na mensagem. Voc� pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a pr�xima mensagem. (Ex "delayMessage": 5, ). O delay default caso n�o seja informado � de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }

        /// <summary>
        /// Nesse atributo um delay � adicionado na mensagem. Voc� pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai ficar com o status "Digitando...". (Ex "delayTyping": 5, ). O delay default caso n�o seja informado � de 0
        /// </summary>
        public int? DelayTyping { get; set; }

        /// <summary>
        /// Atributo utilizado para definir o tamanho da mensagem de visualiza��o do link enviado (SMALL, MEDIUM ou LARGE). O tamanho default caso n�o seja informado � SMALL.
        /// </summary>
        public string? LinkType { get; set; }
    }
}


