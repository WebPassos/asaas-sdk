using WP.Asaas.Sdk.Models.Enums;

namespace WP.Asaas.Sdk.Models.Common
{
    public class Chargeback
    {
        public string Id { get; set; }
        public string Payment { get; set; }
        public string Installment { get; set; }
        public string CustomerAccount { get; set; }
        public StatusType Status { get; set; }
        public string Reason { get; set; }
        public DateTime? DisputeStartDate { get; set; }
        public double Value { get; set; }
        public DateTime? PaymentDate { get; set; }
        public CreditCardInfo CreditCard { get; set; }
        public string DisputeStatus { get; set; }
        public DateTime? DeadlineToSendDisputeDocuments { get; set; }
    }
}