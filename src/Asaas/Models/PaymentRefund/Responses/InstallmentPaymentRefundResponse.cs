namespace WP.Asaas.Sdk.Models.PaymentRefund.Responses
{
    public class InstallmentPaymentRefundResponse
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public double Value { get; set; }
        public double NetValue { get; set; }
        public double PaymentValue { get; set; }
        public int InstallmentCount { get; set; }
        public string BillingType { get; set; }
        public string PaymentDate { get; set; }
        public string Description { get; set; }
        public int ExpirationDay { get; set; }
        public string DateCreated { get; set; }
        public string Customer { get; set; }
        public string PaymentLink { get; set; }
        public string CheckoutSession { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public ChargebackResponse Chargeback { get; set; }
        public CreditCardResponse CreditCard { get; set; }
        public bool Deleted { get; set; }
        public List<RefundResponse> Refunds { get; set; }
    }

    public class ChargebackResponse
    {
        public string Id { get; set; }
        public string Payment { get; set; }
        public string Installment { get; set; }
        public string CustomerAccount { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string DisputeStartDate { get; set; }
        public double Value { get; set; }
        public string PaymentDate { get; set; }
        public CreditCardResponse CreditCard { get; set; }
        public string DisputeStatus { get; set; }
        public string DeadlineToSendDisputeDocuments { get; set; }
    }

    public class CreditCardResponse
    {
        public string CreditCardNumber { get; set; }
        public string CreditCardBrand { get; set; }
        public string CreditCardToken { get; set; }
    }

    public class RefundResponse
    {
        public string DateCreated { get; set; }
        public string Status { get; set; }
        public double Value { get; set; }
        public string EndToEndIdentifier { get; set; }
        public string Description { get; set; }
        public string EffectiveDate { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public List<RefundedSplitResponse> RefundedSplits { get; set; }
        public string PaymentId { get; set; }
    }

    public class RefundedSplitResponse
    {
        public string Id { get; set; }
        public double Value { get; set; }
        public bool Done { get; set; }
    }
}
