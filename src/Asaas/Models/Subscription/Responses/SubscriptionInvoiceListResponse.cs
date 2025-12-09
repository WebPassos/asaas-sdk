using WP.Asaas.Sdk.Models.Common;

namespace WP.Asaas.Sdk.Models.Subscription.Responses
{
    public class SubscriptionInvoiceListResponse
    {
        public string Object { get; set; }
        public bool HasMore { get; set; }
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<SubscriptionInvoiceResponse> Data { get; set; }
    }

    public class SubscriptionInvoiceResponse 
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string Status { get; set; }
        public string Customer { get; set; }
        public string Payment { get; set; }
        public string Installment { get; set; }
        public string Type { get; set; }
        public string StatusDescription { get; set; }
        public string ServiceDescription { get; set; }
        public string PdfUrl { get; set; }
        public string XmlUrl { get; set; }
        public string RpsSerie { get; set; }
        public string RpsNumber { get; set; }
        public string Number { get; set; }
        public string ValidationCode { get; set; }
        public double Value { get; set; }
        public double Deductions { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Observations { get; set; }
        public string EstimatedTaxesDescription { get; set; }
        public string ExternalReference { get; set; }
        public Taxes Taxes { get; set; }
        public string MunicipalServiceId { get; set; }
        public string MunicipalServiceCode { get; set; }
        public string MunicipalServiceName { get; set; }
    }
}