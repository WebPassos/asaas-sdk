using WP.Asaas.Sdk.Models.Transfer.Enums;

namespace WP.Asaas.Sdk.Models.Transfer.Requests
{
    public class CreateTransferRequest
    {
        public decimal Value { get; set; }
        public BankAccount BankAccount { get; set; }
        public OperationType OperationType { get; set; }
        public string PixAddressKey { get; set; }
        public PixAddressKeyType PixAddressKeyType { get; set; }
        public string Description { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string ExternalReference { get; set; }
        public Recurring Recurring { get; set; }
    }
}
