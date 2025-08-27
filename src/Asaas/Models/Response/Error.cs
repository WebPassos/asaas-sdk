namespace Asaas.Models.Response;

public class Error
{
    public string Code { get; internal set; } = string.Empty;
    public string Description { get; internal set; } = string.Empty;
}