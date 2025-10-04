using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZApi.Models
{
    public class SendTextRequest
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
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 seg, que significa quantos segundos ele vai esperar para enviar a próxima mensagem. (Ex.: "delayMessage": 5, ). O delay default caso não seja informado é de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai ficar com o status "Digitando...". (Ex "delayTyping": 5, ). O delay default caso não seja informado é de 0
        /// </summary>
        public int? DelayTyping { get; set; }

        /// <summary>
        /// 	Esse atributo permite editar mensagens enviadas anteriormente no WhatsApp. Use o ID da mensagem e o novo conteúdo no JSON para fazer alterações. É necessário configurar o webhook antes de editar.
        /// </summary>
        public string? EditMessageId { get; set; }
    }
}
