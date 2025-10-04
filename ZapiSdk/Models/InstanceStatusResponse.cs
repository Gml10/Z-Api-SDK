namespace ZApi.Models
{
    public class InstanceStatusResponse
    {
        /// <summary>
        /// Indica se seu número está conectado ao Z-API
        /// </summary>
        public bool Connected { get; set; }

        /// <summary>
        /// Informa detalhes caso algum dos atributos não esteja true
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// Indica se o celular está conectado à internet
        /// </summary>
        public bool SmartphoneConnected { get; set; }
    }
}

