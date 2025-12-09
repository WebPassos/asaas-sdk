using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Subscription.Requests;
using WP.Asaas.Sdk.Models.Subscription.Responses;

namespace IntegrationTests.Controllers
{
    /// <summary>
    /// Gerenciamento de assinaturas recorrentes
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Tags("Assinaturas")]
    [AllowAnonymous]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionsController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        /// <summary>
        /// Criar uma nova assinatura
        /// </summary>
        /// <param name="request">Dados da assinatura</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da assinatura criada</returns>
        /// <response code="200">Assinatura criada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost]
        [ProducesResponseType(typeof(SubscriptionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateSubscription([FromBody] CreateSubscriptionRequest request, CancellationToken cancellationToken)
        {
            var result = await _subscriptionService.CreateSubscriptionAsync(request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Listar todas as assinaturas
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Lista de assinaturas</returns>
        /// <response code="200">Lista retornada com sucesso</response>
        [HttpGet]
        [ProducesResponseType(typeof(SubscriptionListResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllSubscriptions(CancellationToken cancellationToken)
        {
            var result = await _subscriptionService.GetAllSubscriptionsAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Criar uma assinatura com cartão de crédito
        /// </summary>
        /// <param name="request">Dados da assinatura com cartão</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da assinatura criada</returns>
        /// <response code="200">Assinatura criada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost("creditCard")]
        [ProducesResponseType(typeof(SubscriptionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCreditCardSubscription([FromBody] CreateSubscriptionCreditCardRequest request, CancellationToken cancellationToken)
        {
            var result = await _subscriptionService.CreateCreditCardSubscriptionAsync(request, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Buscar uma assinatura por ID
        /// </summary>
        /// <param name="id">ID da assinatura</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da assinatura</returns>
        /// <response code="200">Assinatura encontrada</response>
        /// <response code="404">Assinatura não encontrada</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(SubscriptionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubscription(string id, CancellationToken cancellationToken)
        {
            var result = await _subscriptionService.GetSubscriptionAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Deletar uma assinatura
        /// </summary>
        /// <param name="id">ID da assinatura</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Status da deleção</returns>
        /// <response code="200">Assinatura deletada com sucesso</response>
        /// <response code="404">Assinatura não encontrada</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(DeletedSubscriptionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteSubscription(string id, CancellationToken cancellationToken)
        {
            var result = await _subscriptionService.DeleteSubscriptionAsync(id, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Atualizar uma assinatura
        /// </summary>
        /// <param name="id">ID da assinatura</param>
        /// <param name="request">Dados atualizados</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Dados da assinatura atualizada</returns>
        /// <response code="200">Assinatura atualizada com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        /// <response code="404">Assinatura não encontrada</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(SubscriptionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateSubscription(string id, [FromBody] UpdateSubscriptionRequest request, CancellationToken cancellationToken)
        {
            var result = await _subscriptionService.UpdateSubscriptionAsync(id, request, cancellationToken);
            return Ok(result);
        }
    }

}
