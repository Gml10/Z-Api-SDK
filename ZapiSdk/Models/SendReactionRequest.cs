using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapiSdk.Models
{
    public class SendReactionRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinatário no formato DDI DDD NÚMERO Ex: 551199999999.
        /// IMPORTANTE: Envie somente números, sem formatação ou máscara.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Emoji de reação (veja opções de emoji nesse link).
        /// </summary>
        public string Reaction { get; set; }

        /// <summary>
        /// Id da mensagem que vai receber a reação.
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec,
        /// significa quantos segundos ele vai esperar para enviar a próxima mensagem. (Ex "delayMessage": 5, ).
        /// O delay default caso não seja informado é de 1~3 sec.
        /// </summary>
        public int? DelayMessage { get; set; }
    }
}
