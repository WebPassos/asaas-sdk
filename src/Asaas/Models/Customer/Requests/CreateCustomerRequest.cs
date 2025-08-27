namespace WP.Asaas.Sdk.Models.Customer.Requests;

public class CreateCustomerRequest
{
    public string Name { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public string MobilePhone { get; init; }
    public string CpfCnpj { get; init; }
    public string PostalCode { get; init; }
    public string Address { get; init; }
    public string AddressNumber { get; init; }
    public string Complement { get; init; }
    public string Province { get; init; }
    public string ExternalReference { get; init; }
    public bool NotificationDisabled { get; init; }
    public string AdditionalEmails { get; init; }
    public string MunicipalInscription { get; init; }
    public string StateInscription { get; init; }
    public string Observations { get; init; }
    public string GroupName { get; init; }
}