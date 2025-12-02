namespace WP.Asaas.Sdk.Models.PaymentDunning.Responses;

public class TypeSimulationResponse
{
    public string Type { get; set; }
    public bool IsAllowed { get; set; }
    public string NotAllowedReason { get; set; }
    public decimal FeeValue { get; set; }
    public decimal NetValue { get; set; }
    public DateTime? StartDate { get; set; }
}

public class PaymentAvailableForDunningResponse
{
    public string Payment { get; set; }
    public string Customer { get; set; }
    public decimal Value { get; set; }
    public string Status { get; set; }
    public string BillingType { get; set; }
    public DateTime DueDate { get; set; }
    public List<TypeSimulationResponse> TypeSimulations { get; set; }
}

public class ListPaymentAvailableForDunningResponse
{
    public string Object { get; set; }
    public bool HasMore { get; set; }
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public List<PaymentAvailableForDunningResponse> Data { get; set; }
}
