using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Transfer.Requests;
using WP.Asaas.Sdk.Models.Transfer.Responses;

namespace IntegrationTests.Controllers
{
    /// <summary>
    /// Gerenciamento de transferências bancárias
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Tags("Transferências")]
    [AllowAnonymous]
    public class TransfersController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransfersController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        /// <summary>
        /// Criar uma transferência bancária
        /// </summary>
        /// <param name="request">Dados da transferência</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da transferência criada</returns>
        /// <response code="200">Transferência criada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost]
        [ProducesResponseType(typeof(TransferResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Transfer([FromBody] CreateTransferRequest request, CancellationToken cancellationToken)
        {
            var result = await _transferService.TransferAsync(request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Listar todas as transferências
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Lista de transferências</returns>
        /// <response code="200">Lista retornada com sucesso</response>
        [HttpGet]
        [ProducesResponseType(typeof(TransferListResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllTransfers(CancellationToken cancellationToken)
        {
            var result = await _transferService.GetAllTransfersAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Criar uma transferência para outra conta Asaas
        /// </summary>
        /// <param name="request">Dados da transferência entre contas Asaas</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da transferência criada</returns>
        /// <response code="200">Transferência criada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost("asaasAccount")]
        [ProducesResponseType(typeof(AsaasAccountTransferResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAsaasAccountTransfer([FromBody] AsaasAccountTransferRequest request, CancellationToken cancellationToken)
        {
            var result = await _transferService.CreateAsaasAccountTransferAsync(request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Cancelar uma transferência
        /// </summary>
        /// <param name="id">ID da transferência</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da transferência cancelada</returns>
        /// <response code="200">Transferência cancelada com sucesso</response>
        /// <response code="404">Transferência não encontrada</response>
        [HttpPost("{id}/cancel")]
        [ProducesResponseType(typeof(TransferResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CancelTransfer(string id, CancellationToken cancellationToken)
        {
            var result = await _transferService.CancelTransferAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Buscar uma transferência por ID
        /// </summary>
        /// <param name="id">ID da transferência</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da transferência</returns>
        /// <response code="200">Transferência encontrada</response>
        /// <response code="404">Transferência não encontrada</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TransferResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTransfersById(string id, CancellationToken cancellationToken)
        {
            var result = await _transferService.GetTransfersByIdAsync(id, cancellationToken);
            return Ok(result);
        }
    }

}
