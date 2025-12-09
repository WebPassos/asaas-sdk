using WP.Asaas.Sdk.Commons;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.Finance.Responses;

namespace WP.Asaas.Sdk.Services
{
    public class FinanceService : IFinanceService
    {
        private const string Version = "v3";
        private readonly IAsaasClient _asaasClient;

        public FinanceService(IAsaasClient asaasClient)
        {
            _asaasClient = asaasClient;
        }

        public async Task<FinanceBalanceResponse> GetAccountBalanceAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<FinanceBalanceResponse>($"{Version}/finance/balance", cancellationToken);
            return result;
        }

        public async Task<FinancePaymentStatisticsResponse> GetPaymentStatisticsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<FinancePaymentStatisticsResponse>($"{Version}/finance/payment/statistics", cancellationToken);
            return result;
        }

        public async Task<FinanceSplitStatisticsResponse> GetSplitStatisticsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<FinanceSplitStatisticsResponse>($"{Version}/finance/split/statistics", cancellationToken);
            return result;
        }

        public async Task<List<FinancialTransactionResponse>> GetFinancialTransactionsAsync(CancellationToken cancellationToken)
        {
            var result = await _asaasClient.GetAsync<List<FinancialTransactionResponse>>($"{Version}/financialTransactions", cancellationToken);
            return result;
        }
    }
}