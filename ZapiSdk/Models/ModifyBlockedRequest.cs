using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapiSdk.Models
{
    public enum ModifyBlockedValue
    {
        Block,
        Unblock
    }

    public class ModifyBlockedRequest
    {
        /// <summary>
        /// Número de telefone que você deseja alterar no SEU chat
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Atributo para bloquear ou desbloquear o contato (block ou unblock)
        /// </summary>
        public ModifyBlockedValue Action { get; set; }
    }
}
