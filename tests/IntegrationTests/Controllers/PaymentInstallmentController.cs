using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentInstallment.Requests;
using WP.Asaas.Sdk.Models.PaymentInstallment.Responses;
using WP.Asaas.Sdk.Models.Common;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de parcela mentos
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Parcelamentos")]
public class PaymentInstallmentController : ControllerBase
{
    private readonly IPaymentInstallmentService _paymentInstallmentService;

    public PaymentInstallmentController(IPaymentInstallmentService paymentInstallmentService)
    {
        _paymentInstallmentService = paymentInstallmentService;
    }

    /// <summary>
    /// Criar um parcelamento
    /// </summary>
    /// <param name="request">Dados do parcelamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do parcelamento criado</returns>
    /// <response code="200">Parcelamento criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost]
    [ProducesResponseType(typeof(PaymentInstallmentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateInstallment([FromBody] CreatePaymentInstallmentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.CreateInstallmentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Criar um parcelamento com cartão de crédito
    /// </summary>
    /// <param name="request">Dados do parcelamento com cartão</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do parcelamento criado</returns>
    /// <response code="200">Parcelamento criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("creditCard")]
    [ProducesResponseType(typeof(PaymentInstallmentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCreditCardInstallment([FromBody] CreateCreditCardInstallmentRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.CreateCreditCardInstallmentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todos os parcelamentos
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de parcelamentos</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet]
    [ProducesResponseType(typeof(PaymentInstallmentListResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllInstallments(CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.GetAllInstallmentsAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Deletar um parcelamento
    /// </summary>
    /// <param name="installmentId">ID do parcelamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Status da deleção</returns>
    /// <response code="200">Parcelamento deletado com sucesso</response>
    /// <response code="404">Parcelamento não encontrado</response>
    [HttpDelete("{installmentId}")]
    [ProducesResponseType(typeof(DeletedInstallmentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteInstallment(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.DeleteInstallmentAsync(installmentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Gerar carnê de pagamento do parcelamento
    /// </summary>
    /// <param name="installmentId">ID do parcelamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>PDF do carnê de pagamento</returns>
    /// <response code="200">Carnê gerado com sucesso</response>
    /// <response code="404">Parcelamento não encontrado</response>
    [HttpGet("{installmentId}/paymentBook")]
    [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GenerateInstallmentPaymentBook(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.GenerateInstallmentPaymentBookAsync(installmentId, cancellationToken);
        return File(result, "application/pdf", $"paymentBook_{installmentId}.pdf");
    }

    /// <summary>
    /// Buscar um parcelamento por ID
    /// </summary>
    /// <param name="installmentId">ID do parcelamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do parcelamento</returns>
    /// <response code="200">Parcelamento encontrado</response>
    /// <response code="404">Parcelamento não encontrado</response>
    [HttpGet("{installmentId}")]
    [ProducesResponseType(typeof(PaymentInstallmentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetInstallmentById(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.GetInstallmentByIdAsync(installmentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar pagamentos do parcelamento
    /// </summary>
    /// <param name="installmentId">ID do parcelamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de pagamentos do parcelamento</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    /// <response code="404">Parcelamento não encontrado</response>
    [HttpGet("{installmentId}/payments")]
    [ProducesResponseType(typeof(InstallmentPaymentListResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListInstallmentPayments(string installmentId, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.ListInstallmentPaymentsAsync(installmentId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Tokenizar cartão de crédito
    /// </summary>
    /// <param name="request">Dados do cartão</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Token do cartão de crédito</returns>
    /// <response code="200">Cartão tokenizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("tokenizeCreditCard")]
    [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> TokenizeCreditCard([FromBody] TokenizeCreditCardRequest request, CancellationToken cancellationToken)
    {
        var result = await _paymentInstallmentService.TokenizeCreditCardAsync(request, cancellationToken);
        return Ok(result);
    }
}

