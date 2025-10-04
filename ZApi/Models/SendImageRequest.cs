using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZApi.Models
{
    public class SendImageRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinatário no formato DDI DDD NÚMERO Ex: 551199999999.
        /// IMPORTANTE: Envie somente números, sem formatação ou máscara.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Link da imagem ou seu Base64.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Titulo da sua imagem.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Atributo utilizado para responder uma mensagem do chat, basta adicionar o messageId da mensagem que queira responder neste atributo.
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a próxima mensagem.
        /// O delay default caso não seja informado é de 1~3 sec.
        /// </summary>
        public int? DelayMessage { get; set; }

        /// <summary>
        /// Define se será uma mensagem de visualização única ou não.
        /// </summary>
        public bool? ViewOnce { get; set; }
    }
}
