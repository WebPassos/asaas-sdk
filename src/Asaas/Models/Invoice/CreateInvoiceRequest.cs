using Asaas.Models.Common;

namespace Asaas.Models.Invoice;

public class CreateInvoiceRequest
{
    public string Payment { get; init; }
    public string Installment { get; init; }
    public string Customer { get; init; }
    public string ServiceDescription { get; init; }
    public string Observations { get; init; }
    public decimal Value { get; init; }
    public decimal Deductions { get; init; }
    public DateTime EffectiveDate { get; init; }
    public string MunicipalServiceId { get; init; }
    public string MunicipalServiceCode { get; init; }
    public string MunicipalServiceName { get; init; }
    public Taxes Taxes { get; init; }
}