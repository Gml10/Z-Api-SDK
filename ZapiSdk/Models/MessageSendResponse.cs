using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapiSdk.Models
{
    public class MessageSendResponse
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
