using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Webhook.Requests;
using WP.Asaas.Sdk.Models.Webhook.Responses;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de webhooks (notificações automáticas)
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Webhooks")]
[AllowAnonymous]
public class WebhooksController : ControllerBase
{
    private readonly IWebHookService _webHookService;

    public WebhooksController(IWebHookService webHookService)
    {
        _webHookService = webHookService;
    }

    /// <summary>
    /// Criar um webhook
    /// </summary>
    /// <param name="request">Dados do webhook</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do webhook criado</returns>
    /// <response code="200">Webhook criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost]
    [ProducesResponseType(typeof(WebhookResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateWebhook([FromBody] WebhookRequest request, CancellationToken cancellationToken)
    {
        var result = await _webHookService.CreateWebhookAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todos os webhooks
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de webhooks</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet]
    [ProducesResponseType(typeof(ListWebhookResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllWebhooks(CancellationToken cancellationToken)
    {
        var result = await _webHookService.GetAllWebhooksAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar um webhook por ID
    /// </summary>
    /// <param name="id">ID do webhook</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do webhook</returns>
    /// <response code="200">Webhook encontrado</response>
    /// <response code="404">Webhook não encontrado</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(WebhookResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetWebhookById(string id, CancellationToken cancellationToken)
    {
        var result = await _webHookService.GetWebhookByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Atualizar um webhook
    /// </summary>
    /// <param name="id">ID do webhook</param>
    /// <param name="request">Dados atualizados</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do webhook atualizado</returns>
    /// <response code="200">Webhook atualizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Webhook não encontrado</response>
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(WebhookResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateWebhook(string id, [FromBody] WebhookRequest request, CancellationToken cancellationToken)
    {
        var result = await _webHookService.UpdateWebhookAsync(id, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Deletar um webhook
    /// </summary>
    /// <param name="id">ID do webhook</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Status da deleção</returns>
    /// <response code="200">Webhook deletado com sucesso</response>
    /// <response code="404">Webhook não encontrado</response>
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(DeleteWebhookResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteWebhook(string id, CancellationToken cancellationToken)
    {
        var result = await _webHookService.DeleteWebhookAsync(id, cancellationToken);
        return Ok(result);
    }
}

