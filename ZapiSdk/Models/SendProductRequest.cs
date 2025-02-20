namespace ZapiSdk.Models
{
    public class SendProductRequest
    {
        /// <summary>
        /// Telefone (ou ID do grupo para casos de envio para grupos) do destinat�rio no formato DDI DDD N�MERO Ex: 551199999999. IMPORTANTE Envie somente n�meros, sem formata��o ou m�scara
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Telefone da conta business a qual pertence o produto.
        /// </summary>
        public string CatalogPhone { get; set; }

        /// <summary>
        /// ID do produto. Pode ser obtido na API de listar produtos ou via webhook.
        /// </summary>
        public string ProductId { get; set; }
    }
}
