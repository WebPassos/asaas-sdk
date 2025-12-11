using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Finance.Responses;

namespace IntegrationTests.Controllers
{
    /// <summary>
    /// Consultas financeiras e estatísticas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Tags("Finanças")]
    [AllowAnonymous]
    public class FinanceController : ControllerBase
    {
        private readonly IFinanceService _financeService;

        public FinanceController(IFinanceService financeService)
        {
            _financeService = financeService;
        }

        /// <summary>
        /// Consultar saldo da conta
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Informações do saldo da conta</returns>
        /// <response code="200">Saldo retornado com sucesso</response>
        [HttpGet("balance")]
        [ProducesResponseType(typeof(FinanceBalanceResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAccountBalance(CancellationToken cancellationToken)
        {
            var result = await _financeService.GetAccountBalanceAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Consultar estatísticas de pagamentos
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Estatísticas detalhadas dos pagamentos</returns>
        /// <response code="200">Estatísticas retornadas com sucesso</response>
        [HttpGet("payment/statistics")]
        [ProducesResponseType(typeof(FinancePaymentStatisticsResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPaymentStatistics(CancellationToken cancellationToken)
        {
            var result = await _financeService.GetPaymentStatisticsAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Consultar estatísticas de split de pagamentos
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Estatísticas de divisão de pagamentos</returns>
        /// <response code="200">Estatísticas retornadas com sucesso</response>
        [HttpGet("split/statistics")]
        [ProducesResponseType(typeof(FinanceSplitStatisticsResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSplitStatistics(CancellationToken cancellationToken)
        {
            var result = await _financeService.GetSplitStatisticsAsync(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Listar transações financeiras
        /// </summary>
        /// <param name="cancellationToken">Token de cancelamento</param>
        /// <returns>Lista de transações financeiras</returns>
        /// <response code="200">Transações retornadas com sucesso</response>
        [HttpGet("transactions")]
        [ProducesResponseType(typeof(List<FinancialTransactionResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFinancialTransactions(CancellationToken cancellationToken)
        {
            var result = await _financeService.GetFinancialTransactionsAsync(cancellationToken);
            return Ok(result);
        }
    }

}
