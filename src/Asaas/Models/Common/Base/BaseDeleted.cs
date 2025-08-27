namespace WP.Asaas.Sdk.Models.Common.Base;

public abstract class BaseDeleted
{
    public string Id { get; init; } = null!;

    public bool Deleted { get; init; }
}