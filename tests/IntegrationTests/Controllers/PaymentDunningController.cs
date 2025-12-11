using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentDunning.Requests;
using WP.Asaas.Sdk.Models.PaymentDunning.Responses;
using WP.Asaas.Sdk.Models.Common;

namespace IntegrationTests.Controllers
{
    /// <summary>
    /// Gerenciamento de negativação de pagamentos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Tags("Negativação")]
    [AllowAnonymous]
    public class PaymentDunningController : ControllerBase
    {
        private readonly IPaymentDunningService _paymentDunningService;

        public PaymentDunningController(IPaymentDunningService paymentDunningService)
        {
            _paymentDunningService = paymentDunningService;
        }

        /// <summary>
        /// Criar uma negativação de pagamento
        /// </summary>
        /// <param name="request">Dados da negativação</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da negativação criada</returns>
        /// <response code="200">Negativação criada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost]
        [ProducesResponseType(typeof(PaymentDunningResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreatePaymentDunning([FromBody] CreatePaymentDunningRequest request, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.CreatePaymentDunningAsync(request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Listar todas as negativações
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Lista de negativações</returns>
        /// <response code="200">Lista retornada com sucesso</response>
        [HttpGet]
        [ProducesResponseType(typeof(ListPaymentDunningResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllPaymentDunnings(CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.GetAllPaymentDunningsAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Simular uma negativação
        /// </summary>
        /// <param name="request">Dados para simulação</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados simulados da negativação</returns>
        /// <response code="200">Simulação realizada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost("simulate")]
        [ProducesResponseType(typeof(SimulatedPaymentDunningResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SimulatePaymentDunning([FromBody] SimulatePaymentDunningRequest request, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.SimulatePaymentDunningAsync(request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Buscar uma negativação por ID
        /// </summary>
        /// <param name="id">ID da negativação</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da negativação</returns>
        /// <response code="200">Negativação encontrada</response>
        /// <response code="404">Negativação não encontrada</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PaymentDunningResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPaymentDunningById(string id, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.GetPaymentDunningByIdAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Buscar histórico de eventos da negativação
        /// </summary>
        /// <param name="id">ID da negativação</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Histórico de eventos</returns>
        /// <response code="200">Histórico retornado com sucesso</response>
        /// <response code="404">Negativação não encontrada</response>
        [HttpGet("{id}/history")]
        [ProducesResponseType(typeof(ListPaymentDunningEventHistoryResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPaymentDunningEventHistory(string id, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.GetPaymentDunningEventHistoryAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Buscar pagamentos parciais da negativação
        /// </summary>
        /// <param name="id">ID da negativação</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Lista de pagamentos parciais</returns>
        /// <response code="200">Pagamentos parciais retornados com sucesso</response>
        /// <response code="404">Negativação não encontrada</response>
        [HttpGet("{id}/partialPayments")]
        [ProducesResponseType(typeof(ListPaymentDunningPartialPaymentResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPaymentDunningPartialPayments(string id, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.GetPaymentDunningPartialPaymentsAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Listar pagamentos disponíveis para negativação
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Lista de pagamentos disponíveis</returns>
        /// <response code="200">Pagamentos retornados com sucesso</response>
        [HttpGet("paymentsAvailableForDunning")]
        [ProducesResponseType(typeof(ListPaymentAvailableForDunningResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPaymentsAvailableForDunning(CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.GetPaymentsAvailableForDunningAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Enviar documentos da negativação
        /// </summary>
        /// <param name="id">ID da negativação</param>
        /// <param name="request">Documentos a serem enviados</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da negativação atualizada</returns>
        /// <response code="200">Documentos enviados com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        /// <response code="404">Negativação não encontrada</response>
        [HttpPost("{id}/documents")]
        [ProducesResponseType(typeof(PaymentDunningResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SendDocuments(string id, [FromBody] DocumentsRequest request, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.SendDocumentsAsync(id, request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Cancelar uma negativação
        /// </summary>
        /// <param name="id">ID da negativação</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da negativação cancelada</returns>
        /// <response code="200">Negativação cancelada com sucesso</response>
        /// <response code="404">Negativação não encontrada</response>
        [HttpPost("{id}/cancel")]
        [ProducesResponseType(typeof(PaymentDunningResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CancelPaymentDunning(string id, CancellationToken cancellationToken)
        {
            var result = await _paymentDunningService.CancelPaymentDunningAsync(id, cancellationToken);
            return Ok(result);
        }
    }

}
