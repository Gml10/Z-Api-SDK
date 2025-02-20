namespace ZapiSdk.Models
{
    public class PhonesExistsInBatch
    {
        /// <summary>
        /// true para caso exista e false para casos onde o número não tenha WhatsApp
        /// </summary>
        public bool Exists { get; set; }

        /// <summary>
        /// Número enviado na requisição, podendo conter ou não o nono dígito.
        /// </summary>
        public string InputPhone { get; set; }

        /// <summary>
        /// Número formatado de acordo com a resposta do WhatsApp, refletindo o cadastro no WhatsApp e incluindo o nono dígito, se houver.
        /// </summary>
        public string OutputPhone { get; set; }
    }
}
