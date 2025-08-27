using Asaas.Models.Common;

namespace Asaas.Models.Invoice;

public class UpdateInvoiceRequest
{
    public string ServiceDescription { get; init; }
    public string Observations { get; init; }
    public decimal? Value { get; init; }
    public decimal? Deductions { get; init; }
    public DateTime? EffectiveDate { get; init; }
    public Taxes Taxes { get; init; }
}