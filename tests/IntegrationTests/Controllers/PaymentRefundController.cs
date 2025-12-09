using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentRefund.Requests;
using WP.Asaas.Sdk.Models.PaymentRefund.Responses;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de estornos de pagamentos
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Estornos")]
[AllowAnonymous]
public class PaymentRefundController : ControllerBase
{
    private readonly IPaymentRefundService _paymentRefundService;

    public PaymentRefundController(IPaymentRefundService paymentRefundService)
    {
        _paymentRefundService = paymentRefundService;
    }

    /// <summary>
    /// Estornar um boleto de pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do estorno do boleto</returns>
    /// <response code="200">Boleto estornado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("payments/{paymentId}/bankSlip/refund")]
    [ProducesResponseType(typeof(PaymentRefundSlipResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ReversePaymentSlip(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentRefundService.ReversePaymentSlipAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Estornar um pagamento parcelado
    /// </summary>
    /// <param name="installmentId">ID do parcelamento</param>
    /// <param name="request">Dados do estorno</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do estorno do parcelamento</returns>
    /// <response code="200">Parcelamento estornado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Parcelamento não encontrado</response>
    [HttpPost("installments/{installmentId}/refund")]
    [ProducesResponseType(typeof(InstallmentPaymentRefundResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ReverseInstallmentPayment(string installmentId, [FromBody] ReverseInstallmentPaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentRefundService.ReverseInstallmentPaymentAsync(installmentId, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Estornar um pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="request">Dados do estorno</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do estorno</returns>
    /// <response code="200">Pagamento estornado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("payments/{paymentId}/refund")]
    [ProducesResponseType(typeof(PaymentRefundResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ReversePaymentRefund(string paymentId, [FromBody] ReverseChargeRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentRefundService.ReversePaymentRefundAsync(paymentId, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todos os estornos de um pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de estornos</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpGet("payments/{paymentId}/refunds")]
    [ProducesResponseType(typeof(PaymentRefundListResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAllPaymentRefunds(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentRefundService.GetAllPaymentRefundsAsync(paymentId, cancellationToken);
        return Ok(result);
    }
}

