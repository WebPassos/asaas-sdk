namespace Asaas.Extensions;

internal static class StringExtensions
{
    public static string FirstCharToLower(this string text)
    {
        return char.ToLowerInvariant(text[0]) + text.Substring(1);
    }
}