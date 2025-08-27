namespace AsaasSdk.Models.Common;

public class CreditCardHolderInfoRequest
{
    public string Name { get; init; }

    public string Email { get; init; }

    public string CpfCnpj { get; init; }

    public string PostalCode { get; init; }

    public string AddressNumber { get; init; }

    public string AddressComplement { get; init; }

    public string Phone { get; init; }

    public string MobilePhone { get; init; }
}