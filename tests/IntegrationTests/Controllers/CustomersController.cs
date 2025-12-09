using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Customer;
using WP.Asaas.Sdk.Models.Customer.Requests;
using WP.Asaas.Sdk.Models.Common.Base;

namespace IntegrationTests.Controllers
{
    /// <summary>
    /// Gerenciamento de clientes
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Tags("Clientes")]
    [AllowAnonymous]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Criar um cliente completo
        /// </summary>
        /// <param name="request">Dados completos do cliente</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>ID do cliente criado</returns>
        /// <response code="200">Cliente criado com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = await _customerService.CreateCustomerAsync(request, cancellationToken);
            return Ok(new { CustomerId = result });
        }

        /// <summary>
        /// Atualizar dados de um cliente
        /// </summary>
        /// <param name="request">Dados atualizados do cliente (deve incluir o ID)</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>ID do cliente atualizado</returns>
        /// <response code="200">Cliente atualizado com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        /// <response code="404">Cliente não encontrado</response>
        [HttpPut]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = await _customerService.UpdateCustomerAsync(request, cancellationToken);
            return Ok(new { CustomerId = result });
        }

        /// <summary>
        /// Deletar um cliente
        /// </summary>
        /// <param name="customerId">ID do cliente a ser deletado</param>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Status da deleção</returns>
        /// <response code="200">Cliente deletado com sucesso</response>
        /// <response code="404">Cliente não encontrado</response>
        [HttpDelete("{customerId}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCustomer(string customerId, CancellationToken cancellationToken)
        {
            var result = await _customerService.DeleteCustomerAsync(customerId, cancellationToken);
            return Ok(new { Deleted = result });
        }
    }

}
