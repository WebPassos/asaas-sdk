using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentLink.Requests;
using WP.Asaas.Sdk.Models.PaymentLink.Responses;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de links de pagamento
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Links de Pagamento")]
[AllowAnonymous]
public class PaymentLinksController : ControllerBase
{
    private readonly IPaymentsLinkService _paymentsLinkService;

    public PaymentLinksController(IPaymentsLinkService paymentsLinkService)
    {
        _paymentsLinkService = paymentsLinkService;
    }

    /// <summary>
    /// Criar um link de pagamento
    /// </summary>
    /// <param name="request">Dados do link de pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do link criado</returns>
    /// <response code="200">Link criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost]
    [ProducesResponseType(typeof(PaymentLinkResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreatePaymentLink([FromBody] CreatePaymentLinkRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentsLinkService.CreatePaymentLinkAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todos os links de pagamento
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de links de pagamento</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet]
    [ProducesResponseType(typeof(PaymentLinkListResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllPaymentLinks(CancellationToken cancellationToken)
    {
        var result = await _paymentsLinkService.GetAllPaymentLinksAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Atualizar um link de pagamento
    /// </summary>
    /// <param name="paymentLinkId">ID do link</param>
    /// <param name="request">Dados atualizados do link</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do link atualizado</returns>
    /// <response code="200">Link atualizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Link não encontrado</response>
    [HttpPut("{paymentLinkId}")]
    [ProducesResponseType(typeof(PaymentLinkResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdatePaymentLink(string paymentLinkId, [FromBody] UpdatePaymentLinkRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentsLinkService.UpdatePaymentLinkAsync(paymentLinkId, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar um link de pagamento por ID
    /// </summary>
    /// <param name="paymentLinkId">ID do link</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do link</returns>
    /// <response code="200">Link encontrado</response>
    /// <response code="404">Link não encontrado</response>
    [HttpGet("{paymentLinkId}")]
    [ProducesResponseType(typeof(PaymentLinkResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPaymentLinks(string paymentLinkId, CancellationToken cancellationToken)
    {
        var result = await _paymentsLinkService.GetPaymentLinksAsync(paymentLinkId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Deletar um link de pagamento
    /// </summary>
    /// <param name="paymentLinkId">ID do link</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Status da deleção</returns>
    /// <response code="200">Link deletado com sucesso</response>
    /// <response code="404">Link não encontrado</response>
    [HttpDelete("{paymentLinkId}")]
    [ProducesResponseType(typeof(DeletedPaymentLinkResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePaymentLink(string paymentLinkId, CancellationToken cancellationToken)
    {
        var result = await _paymentsLinkService.DeletePaymentLinkAsync(paymentLinkId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Restaurar um link de pagamento deletado
    /// </summary>
    /// <param name="paymentLinkId">ID do link</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do link restaurado</returns>
    /// <response code="200">Link restaurado com sucesso</response>
    /// <response code="404">Link não encontrado</response>
    [HttpPost("{paymentLinkId}/restore")]
    [ProducesResponseType(typeof(PaymentLinkResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RestorePaymentLink(string paymentLinkId, CancellationToken cancellationToken)
    {
        var result = await _paymentsLinkService.RestorePaymentLinkAsync(paymentLinkId, cancellationToken);
        return Ok(result);
    }
}

