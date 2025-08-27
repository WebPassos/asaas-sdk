using AsaasSdk.Models.Common;
using AsaasSdk.Models.Invoice.Enums;

namespace AsaasSdk.Models.Invoice;

public class Invoice
{
    public string Id { get; init; }
    public InvoiceStatus Status { get; init; }
    public string Customer { get; init; }
    public string Payment { get; init; }
    public string Installment { get; init; }
    public string Type { get; init; }
    public string StatusDescription { get; init; }
    public string ServiceDescription { get; init; }
    public string PdfUrl { get; init; }
    public string XmlUrl { get; init; }
    public string RpsSerie { get; init; }
    public string RpsNumber { get; init; }
    public string Number { get; init; }
    public string ValidationCode { get; init; }
    public decimal Value { get; init; }
    public decimal Deductions { get; init; }
    public DateTime EffectiveDate { get; init; }
    public string Observations { get; init; }
    public string EstimatedTaxesDescription { get; init; }
    public string MunicipalServiceId { get; init; }
    public string MunicipalServiceCode { get; init; }
    public string MunicipalServiceName { get; init; }
    public Taxes Taxes { get; init; }
}