namespace WP.Asaas.Sdk.Models.Common
{
    public class Refund
    {
        public DateTime? DateCreated { get; set; }
        public string Status { get; set; }
        public double Value { get; set; }
        public string EndToEndIdentifier { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string TransactionReceiptUrl { get; set; }
        public List<RefundedSplit> RefundedSplits { get; set; }
    }

    public class RefundedSplit
    {
        public string Id { get; set; }
        public double Value { get; set; }
        public bool Done { get; set; }
    }
}
