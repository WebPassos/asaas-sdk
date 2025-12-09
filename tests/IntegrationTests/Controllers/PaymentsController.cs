using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Payment.Requests;
using WP.Asaas.Sdk.Models.Payment.Responses;
using WP.Asaas.Sdk.Models.Common;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de pagamentos (cobranças)
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Pagamentos")]
[AllowAnonymous]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentsController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    /// <summary>
    /// Criar um novo pagamento/cobrança
    /// </summary>
    /// <param name="request">Dados do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento criado</returns>
    /// <response code="200">Pagamento criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost]
    [ProducesResponseType(typeof(PaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentService.CreatePaymentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Criar um pagamento com cartão de crédito
    /// </summary>
    /// <param name="request">Dados do pagamento com cartão</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento criado</returns>
    /// <response code="200">Pagamento criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("creditCard")]
    [ProducesResponseType(typeof(CreditCardPaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCreditCardPayment([FromBody] CreateCreditCardPaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentService.CreateCreditCardPaymentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todos os pagamentos
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de pagamentos</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet]
    [ProducesResponseType(typeof(PaymentListResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllPayments(CancellationToken cancellationToken)
    {
        var result = await _paymentService.GetAllPaymentsAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar QR Code PIX de um pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do QR Code PIX</returns>
    /// <response code="200">QR Code retornado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpGet("{paymentId}/pixQrCode")]
    [ProducesResponseType(typeof(PixQrCodeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPaymentPixQrCodeById(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.GetPaymentPixQrCodeByIdAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Deletar um pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Status da deleção</returns>
    /// <response code="200">Pagamento deletado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpDelete("{paymentId}")]
    [ProducesResponseType(typeof(DeletePaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePayment(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.DeletePaymentAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Atualizar um pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="request">Dados atualizados</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento atualizado</returns>
    /// <response code="200">Pagamento atualizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPut("{paymentId}")]
    [ProducesResponseType(typeof(PaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdatePayment(string paymentId, [FromBody] UpdatePaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentService.UpdatePaymentAsync(paymentId, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Restaurar um pagamento deletado
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento restaurado</returns>
    /// <response code="200">Pagamento restaurado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("{paymentId}/restore")]
    [ProducesResponseType(typeof(PaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RestorePayment(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.RestorePaymentAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Capturar pagamento pré-autorizado
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento capturado</returns>
    /// <response code="200">Pagamento capturado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("{paymentId}/captureAuthorizedPayment")]
    [ProducesResponseType(typeof(CaptureAuthorizedPaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CaptureAuthorizedPayment(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.CaptureAuthorizedPaymentAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Pagar com cartão de crédito
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="request">Dados do cartão</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento processado</returns>
    /// <response code="200">Pagamento processado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("{paymentId}/payWithCreditCard")]
    [ProducesResponseType(typeof(PayWithCreditCardResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> PayWithCreditCard(string paymentId, [FromBody] PayWithCreditCardRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentService.PayWithCreditCardAsync(paymentId, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar informações de cobrança do pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Informações de cobrança</returns>
    /// <response code="200">Informações retornadas com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpGet("{paymentId}/billingInfo")]
    [ProducesResponseType(typeof(BillingInfoResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetBillingInfoById(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.GetBillingInfoByIdAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar informações de visualização do pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Informações de visualização</returns>
    /// <response code="200">Informações retornadas com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpGet("{paymentId}/viewingInfo")]
    [ProducesResponseType(typeof(ViewingInfoResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetViewingInfoById(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.GetViewingInfoByIdAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar campo de identificação do pagamento
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Campo de identificação</returns>
    /// <response code="200">Campo retornado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpGet("{paymentId}/identificationField")]
    [ProducesResponseType(typeof(IdentificationFieldResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetIdentificationField(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.GetIdentificationFieldAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Confirmar recebimento em dinheiro
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="request">Dados do recebimento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento confirmado</returns>
    /// <response code="200">Recebimento confirmado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("{paymentId}/receiveInCash")]
    [ProducesResponseType(typeof(PaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ReceiveInCash(string paymentId, [FromBody] ReceiveInCashRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentService.ReceiveInCashAsync(paymentId, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Desfazer recebimento em dinheiro
    /// </summary>
    /// <param name="paymentId">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento</returns>
    /// <response code="200">Operação realizada com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("{paymentId}/undoReceivedInCash")]
    [ProducesResponseType(typeof(PaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UndoReceivedInCash(string paymentId, CancellationToken cancellationToken)
    {
        var result = await _paymentService.UndoReceivedInCashAsync(paymentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Simular um pagamento
    /// </summary>
    /// <param name="request">Dados para simulação</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados simulados do pagamento</returns>
    /// <response code="200">Simulação realizada com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("simulate")]
    [ProducesResponseType(typeof(SimulatePaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SimulatePayment([FromBody] SimulatePaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentService.SimulatePaymentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Consultar limites de pagamento
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Limites de pagamento</returns>
    /// <response code="200">Limites retornados com sucesso</response>
    [HttpGet("limits")]
    [ProducesResponseType(typeof(PaymentLimitsResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPaymentLimits(CancellationToken cancellationToken)
    {
        var result = await _paymentService.GetPaymentLimitsAsync(cancellationToken);
        return Ok(result);
    }
}

