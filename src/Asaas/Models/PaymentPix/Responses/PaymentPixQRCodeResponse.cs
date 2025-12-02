namespace WP.Asaas.Sdk.Models.PaymentPix.Responses
{
    public class PaymentPixQRCodeResponse
    {
        public string Id { get; set; }
        public string EndToEndIdentifier { get; set; }
        public string Finality { get; set; }
        public double Value { get; set; }
        public double? ChangeValue { get; set; }
        public double RefundedValue { get; set; }
        public string EffectiveDate { get; set; }
        public string ScheduledDate { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string OriginType { get; set; }
        public string ConciliationIdentifier { get; set; }
        public string Description { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public string RefusalReason { get; set; }
        public bool CanBeCanceled { get; set; }
        public PaymentPixQRCodeOriginalTransaction OriginalTransaction { get; set; }
        public PaymentPixQRCodeExternalAccount ExternalAccount { get; set; }
        public PaymentPixQRCodeQrCodeResponse QrCode { get; set; }
        public string Payment { get; set; }
        public bool CanBeRefunded { get; set; }
        public string RefundDisabledReason { get; set; }
        public double ChargedFeeValue { get; set; }
        public string DateCreated { get; set; }
        public string AddressKey { get; set; }
        public string AddressKeyType { get; set; }
        public string TransferId { get; set; }
        public string ExternalReference { get; set; }
    }

    public class PaymentPixQRCodeOriginalTransaction
    {
        public string Id { get; set; }
        public string EndToEndIdentifier { get; set; }
        public double? Value { get; set; }
        public string EffectiveDate { get; set; }
    }

    public class PaymentPixQRCodeExternalAccount
    {
        public string Ispb { get; set; }
        public string IspbName { get; set; }
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
        public string AddressKey { get; set; }
        public string AddressKeyType { get; set; }
    }

    public class PaymentPixQRCodeQrCodeResponse
    {
        public PaymentPixQRCodePayerResponse Payer { get; set; }
        public string ConciliationIdentifier { get; set; }
        public double OriginalValue { get; set; }
        public string DueDate { get; set; }
        public double Interest { get; set; }
        public double Fine { get; set; }
        public double Discount { get; set; }
        public string ExpirationDate { get; set; }
        public string Description { get; set; }
    }

    public class PaymentPixQRCodePayerResponse
    {
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
    }
}
