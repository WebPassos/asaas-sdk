using WP.Asaas.Sdk.Models.Common;
using WP.Asaas.Sdk.Models.PaymentDunning.Enums;

namespace WP.Asaas.Sdk.Models.PaymentDunning;

public class CreatePaymentDunningRequest
{
    public string Payment { get; init; }
    public PaymentDunningType Type { get; init; }
    public string Description { get; init; }
    public string CustomerName { get; init; }
    public string CustomerCpfCnpj { get; init; }
    public string CustomerPrimaryPhone { get; init; }
    public string CustomerSecondaryPhone { get; init; }
    public string CustomerPostalCode { get; init; }
    public string CustomerAddress { get; init; }
    public string CustomerAddressNumber { get; init; }
    public string CustomerComplement { get; init; }
    public string CustomerProvince { get; init; }
    public List<AsaasFile> Documents { get; init; }
}