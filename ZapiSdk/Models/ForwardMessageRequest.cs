﻿namespace ZApi.Models
{
    public class ForwardMessageRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinatário no formato DDI DDD NUMERO Ex: 551199999999. IMPORTANTE Envie somente números, sem formatação ou máscara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// ID da mensagem que vai ser reencaminhada
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Número do chat onde o messageId se encontra
        /// </summary>
        public string MessagePhone { get; set; }

        /// <summary>
        /// Nesse atributo um delay é adicionado na mensagem. Você pode decidir entre um range de 1~15 sec, significa quantos segundos ele vai esperar para enviar a próxima mensagem. (Ex "delayMessage": 5, ). O delay default caso não seja informado é de 1~3 sec
        /// </summary>
        public int? DelayMessage { get; set; }
    }
}
