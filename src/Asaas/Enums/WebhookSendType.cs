namespace WP.Asaas.Sdk.Enums
{
    /// <summary>
    /// Tipo de envio do webhook
    /// </summary>
    public enum WebhookSendType
    {
        /// <summary>
        /// Envio não sequencial (padrão)
        /// </summary>
        NON_SEQUENTIALLY,
    
        /// <summary>
        /// Envio sequencial (aguarda retorno do webhook anterior antes de enviar o próximo)
        /// </summary>
        SEQUENTIALLY
    }

}
