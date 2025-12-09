using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Bill.Requests;
using WP.Asaas.Sdk.Models.Bill.Responses;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de pagamento de contas (boletos, luz, água, etc)
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Pagamento de Contas")]
[AllowAnonymous]
public class BillsController : ControllerBase
{
    private readonly IBillService _billService;

    public BillsController(IBillService billService)
    {
        _billService = billService;
    }

    /// <summary>
    /// Criar um novo pagamento de conta
    /// </summary>
    /// <param name="request">Dados do pagamento da conta</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento criado</returns>
    /// <response code="200">Pagamento criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost]
    [ProducesResponseType(typeof(BillPaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateBillPayment([FromBody] CreateBillPaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _billService.CreateBillPaymentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todos os pagamentos de contas
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de pagamentos de contas</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet]
    [ProducesResponseType(typeof(ListBillPaymentResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllBillPayments(CancellationToken cancellationToken)
    {
        var result = await _billService.GetAllBillPaymentsAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Simular um pagamento de conta
    /// </summary>
    /// <param name="request">Dados para simulação</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados simulados do pagamento</returns>
    /// <response code="200">Simulação realizada com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("simulate")]
    [ProducesResponseType(typeof(SimulatedBillPaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SimulateBillPayment([FromBody] SimulateBillPaymentRequest request, CancellationToken cancellationToken)
    {
        var result = await _billService.SimulateBillPaymentAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar um pagamento de conta por ID
    /// </summary>
    /// <param name="id">ID do pagamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento</returns>
    /// <response code="200">Pagamento encontrado</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(BillPaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetBillPaymentById(string id, CancellationToken cancellationToken)
    {
        var result = await _billService.GetBillPaymentByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Cancelar um pagamento de conta
    /// </summary>
    /// <param name="id">ID do pagamento a ser cancelado</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento cancelado</returns>
    /// <response code="200">Pagamento cancelado com sucesso</response>
    /// <response code="404">Pagamento não encontrado</response>
    [HttpPost("{id}/cancel")]
    [ProducesResponseType(typeof(BillPaymentResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CancelBillPayment(string id, CancellationToken cancellationToken)
    {
        var result = await _billService.CancelBillPaymentAsync(id, cancellationToken);
        return Ok(result);
    }
}

