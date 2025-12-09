namespace WP.Asaas.Sdk.Utils;

internal static class ObjectUtils
{
    public static T Cast<T>(this object obj)
    {
        return (T)obj;
    }

    public static bool IsNullableEnum(this Type t)
    {
        var type = Nullable.GetUnderlyingType(t);
        return type != null && type.IsEnum;
    }
}