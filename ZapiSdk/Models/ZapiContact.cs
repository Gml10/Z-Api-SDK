using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZApi.Models
{
    public class ZapiContact
    {
        /// <summary>  
        /// Phone do contato  
        /// </summary>  
        public string Phone { get; set; }

        /// <summary>  
        /// Nome e sobrenome do contato, só vai retornar preenchido caso você tenha o número em seus contatos  
        /// </summary>  
        public string Name { get; set; }

        /// <summary>  
        /// Nome do contato, só vai retornar preenchido caso você tenha o número em seus contatos  
        /// </summary>  
        public string Short { get; set; }

        /// <summary>  
        /// Nome do contato caso você tenha ele como contato  
        /// </summary>  
        public string Vname { get; set; }

        /// <summary>  
        /// Nome informado nas configurações de nome do WhatsApp  
        /// </summary>  
        public string Notify { get; set; }

        /// <summary>
        /// URL da foto do contato o WhatsApp apaga após 48h
        /// </summary>
        public string ImgUrl { get; set; }
    }
}
