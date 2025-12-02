using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.Payment.Responses;

namespace WP.Asaas.Sdk.Models.Subscription.Responses
{
    public class SubscriptionPaymentsResponse : PaymentResponse
    {
        public string Object { get; init; }
        public string CheckoutSession { get; init; }
        public string PaymentLink { get; init; }
        public bool CanBePaidAfterDueDate { get; init; }
        public string PixTransaction { get; init; }
        public string PixQrCodeId { get; init; }
        public bool Anticipable { get; init; }
        public DateTime? CreditDate { get; init; }
        public DateTime? EstimatedCreditDate { get; init; }
        public string TransactionReceiptUrl { get; init; }
        public string NossoNumero { get; init; }
        public int? DaysAfterDueDateToRegistrationCancellation { get; init; }
        public Chargeback Chargeback { get; init; }
        public Escrow Escrow { get; init; }
        public List<Refund> Refunds { get; init; }
    }
}
