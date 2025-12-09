using WP.Asaas.Sdk.Models.Webhook.Enums;

namespace WP.Asaas.Sdk.Models.Webhook.Responses;

/// <summary>
/// Resposta de webhook
/// </summary>
public class WebhookResponse
{
    /// <summary>
    /// ID do webhook
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// Nome identificador do webhook
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// URL do webhook
    /// </summary>
    public string Url { get; set; }
    
    /// <summary>
    /// E-mail para notificações de falha
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Indica se o webhook está ativo
    /// </summary>
    public bool Enabled { get; set; }
    
    /// <summary>
    /// Indica se o webhook está interrompido
    /// </summary>
    public bool Interrupted { get; set; }
    
    /// <summary>
    /// Versão da API
    /// </summary>
    public int ApiVersion { get; set; }
    
    /// <summary>
    /// Indica se possui token de autenticação configurado
    /// </summary>
    public bool HasAuthToken { get; set; }
    
    /// <summary>
    /// Tipo de envio do webhook
    /// </summary>
    public WebhookSendType SendType { get; set; }
    
    /// <summary>
    /// Lista de eventos configurados
    /// </summary>
    public List<WebhookEvent> Events { get; set; }
}


