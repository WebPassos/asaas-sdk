using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WP.Asaas.Sdk.Converters
{
    /// <summary>
    /// Converter customizado para lidar com múltiplos formatos de DateTime retornados pela API do Asaas
    /// </summary>
    public class FlexibleDateTimeConverter : JsonConverter<DateTime>
    {
        private readonly string[] _formats = new[]
        {
            "yyyy-MM-dd HH:mm:ss",           // Formato comum do Asaas
            "yyyy-MM-dd'T'HH:mm:ss",         // ISO 8601 sem timezone
            "yyyy-MM-dd'T'HH:mm:ss.fff",     // ISO 8601 com milissegundos
            "yyyy-MM-dd'T'HH:mm:ss.fffZ",    // ISO 8601 com milissegundos e UTC
            "yyyy-MM-dd'T'HH:mm:ssZ",        // ISO 8601 com UTC
            "yyyy-MM-dd'T'HH:mm:ss.fffzzz",  // ISO 8601 com timezone offset
            "yyyy-MM-dd'T'HH:mm:sszzz",      // ISO 8601 com timezone offset sem milissegundos
            "yyyy-MM-dd",                     // Apenas data
        };

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return default;
            }

            var dateString = reader.GetString();
        
            if (string.IsNullOrWhiteSpace(dateString))
            {
                return default;
            }

            // Tentar parsing direto primeiro (para formato padrão ISO 8601)
            if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var dateTime))
            {
                return dateTime;
            }

            // Tentar com os formatos customizados
            foreach (var format in _formats)
            {
                if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                {
                    return dateTime;
                }
            }

            // Se nada funcionar, lançar exceção com informação útil
            throw new JsonException($"Unable to parse DateTime from value: '{dateString}'. Expected formats: {string.Join(", ", _formats)}");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture));
        }
    }

}
