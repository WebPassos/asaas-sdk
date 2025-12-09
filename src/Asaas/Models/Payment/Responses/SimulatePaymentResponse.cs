namespace WP.Asaas.Sdk.Models.Payment.Responses
{
    public class SimulatePaymentInstallmentResponse
    {
        public decimal PaymentNetValue { get; init; }
        public decimal PaymentValue { get; init; }
    }

    public class SimulatePaymentCreditCardResponse
    {
        public decimal NetValue { get; init; }
        public decimal FeePercentage { get; init; }
        public decimal OperationFee { get; init; }
        public SimulatePaymentInstallmentResponse Installment { get; init; }
    }

    public class SimulatePaymentBankSlipResponse
    {
        public decimal NetValue { get; init; }
        public decimal FeeValue { get; init; }
        public SimulatePaymentInstallmentResponse Installment { get; init; }
    }

    public class SimulatePaymentPixResponse
    {
        public decimal NetValue { get; init; }
        public decimal? FeePercentage { get; init; }
        public decimal FeeValue { get; init; }
        public SimulatePaymentInstallmentResponse Installment { get; init; }
    }

    public class SimulatePaymentResponse
    {
        public decimal Value { get; init; }
        public SimulatePaymentCreditCardResponse CreditCard { get; init; }
        public SimulatePaymentBankSlipResponse BankSlip { get; init; }
        public SimulatePaymentPixResponse Pix { get; init; }
    }
}
