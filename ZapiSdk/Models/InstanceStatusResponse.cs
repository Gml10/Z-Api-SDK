namespace ZapiSdk.Models
{
    public class InstanceStatusResponse
    {
        /// <summary>
        /// Indica se seu n�mero est� conectado ao Z-API
        /// </summary>
        public bool Connected { get; set; }

        /// <summary>
        /// Informa detalhes caso algum dos atributos n�o esteja true
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// Indica se o celular est� conectado � internet
        /// </summary>
        public bool SmartphoneConnected { get; set; }
    }
}

