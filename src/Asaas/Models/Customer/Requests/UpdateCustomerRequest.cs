namespace WP.Asaas.Sdk.Models.Customer.Requests
{
    public class UpdateCustomerRequest
    {
        public int Id { get; set; }
        public string Name { get; init; } = null!;
        public string CpfCnpj { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; } = null!;
        public string MobilePhone { get; init; } = null!;
        public string Address { get; init; }
        public string AddressNumber { get; init; }
        public string Complement { get; init; }
        public string Province { get; init; }
        public string PostalCode { get; init; }
        public string ExternalReference { get; init; }
        public bool NotificationDisabled { get; init; }
        public string AdditionalEmails { get; init; }
        public string MunicipalInscription { get; init; }
        public string StateInscription { get; init; }
        public string Observations { get; init; }
    }
}