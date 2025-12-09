using WP.Asaas.Sdk.Models.Finance.Responses;

namespace WP.Asaas.Sdk.Interfaces;

public interface IFinanceService
{
    Task<FinanceBalanceResponse> GetAccountBalanceAsync(CancellationToken cancellationToken);
    Task<FinancePaymentStatisticsResponse> GetPaymentStatisticsAsync(CancellationToken cancellationToken);
    Task<FinanceSplitStatisticsResponse> GetSplitStatisticsAsync(CancellationToken cancellationToken);
    Task<List<FinancialTransactionResponse>> GetFinancialTransactionsAsync(CancellationToken cancellationToken);
}