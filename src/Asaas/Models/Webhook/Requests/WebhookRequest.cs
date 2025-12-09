using WP.Asaas.Sdk.Enums;

namespace WP.Asaas.Sdk.Models.Webhook.Requests
{
    /// <summary>
    /// Request para criação/atualização de webhook
    /// </summary>
    public class WebhookRequest
    {
        /// <summary>
        /// Nome identificador do webhook
        /// </summary>
        public string Name { get; set; }
    
        /// <summary>
        /// URL do webhook que receberá as notificações
        /// </summary>
        public string Url { get; set; }
    
        /// <summary>
        /// E-mail para notificações de falha no envio do webhook
        /// </summary>
        public string Email { get; set; }
    
        /// <summary>
        /// Versão da API (2 ou 3)
        /// </summary>
        public int ApiVersion { get; set; }
    
        /// <summary>
        /// Indica se o webhook está ativo
        /// </summary>
        public bool Enabled { get; set; }
    
        /// <summary>
        /// Indica se o webhook está interrompido por muitas falhas
        /// </summary>
        public bool Interrupted { get; set; }
    
        /// <summary>
        /// Token de autenticação para validação do webhook
        /// </summary>
        public string AuthToken { get; set; }
    
        /// <summary>
        /// Tipo de envio (SEQUENTIAL ou NON_SEQUENTIAL)
        /// </summary>
        public WebhookSendType? SendType { get; set; }
    
        /// <summary>
        /// Lista de eventos que o webhook deve escutar
        /// </summary>
        public List<WebhookEvent> Events { get; set; }
    }


}
