using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Invoice.Requests;
using WP.Asaas.Sdk.Models.Invoice.Responses;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de notas fiscais
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("Notas Fiscais")]
[AllowAnonymous]
public class InvoicesController : ControllerBase
{
    private readonly IInvoiceService _invoiceService;

    public InvoicesController(IInvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    /// <summary>
    /// Criar uma nova nota fiscal
    /// </summary>
    /// <param name="request">Dados da nota fiscal</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da nota fiscal criada</returns>
    /// <response code="200">Nota fiscal criada com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost]
    [ProducesResponseType(typeof(InvoiceResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateInvoice([FromBody] CreateInvoiceRequest request, CancellationToken cancellationToken)
    {
        var result = await _invoiceService.CreateInvoiceAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Listar todas as notas fiscais
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de notas fiscais</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet]
    [ProducesResponseType(typeof(ListInvoiceResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllInvoices(CancellationToken cancellationToken)
    {
        var result = await _invoiceService.GetAllInvoicesAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Atualizar uma nota fiscal
    /// </summary>
    /// <param name="id">ID da nota fiscal</param>
    /// <param name="request">Dados atualizados da nota fiscal</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da nota fiscal atualizada</returns>
    /// <response code="200">Nota fiscal atualizada com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Nota fiscal não encontrada</response>
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(InvoiceResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateInvoice(string id, [FromBody] UpdateInvoiceRequest request, CancellationToken cancellationToken)
    {
        var result = await _invoiceService.UpdateInvoiceAsync(id, request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar uma nota fiscal por ID
    /// </summary>
    /// <param name="id">ID da nota fiscal</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da nota fiscal</returns>
    /// <response code="200">Nota fiscal encontrada</response>
    /// <response code="404">Nota fiscal não encontrada</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(InvoiceResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetInvoiceById(string id, CancellationToken cancellationToken)
    {
        var result = await _invoiceService.GetInvoiceByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Autorizar uma nota fiscal
    /// </summary>
    /// <param name="id">ID da nota fiscal</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da nota fiscal autorizada</returns>
    /// <response code="200">Nota fiscal autorizada com sucesso</response>
    /// <response code="404">Nota fiscal não encontrada</response>
    [HttpPost("{id}/authorize")]
    [ProducesResponseType(typeof(InvoiceResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AuthorizeInvoice(string id, CancellationToken cancellationToken)
    {
        var result = await _invoiceService.AuthorizeInvoiceAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Cancelar uma nota fiscal
    /// </summary>
    /// <param name="id">ID da nota fiscal</param>
    /// <param name="request">Motivo do cancelamento</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da nota fiscal cancelada</returns>
    /// <response code="200">Nota fiscal cancelada com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Nota fiscal não encontrada</response>
    [HttpPost("{id}/cancel")]
    [ProducesResponseType(typeof(InvoiceResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CancelInvoice(string id, [FromBody] CancelInvoiceRequest request, CancellationToken cancellationToken)
    {
        var result = await _invoiceService.CancelInvoiceAsync(id, request, cancellationToken);
        return Ok(result);
    }
}

