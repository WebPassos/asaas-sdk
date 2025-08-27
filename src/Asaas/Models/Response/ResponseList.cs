using System.Net;
using System.Text.Json;

namespace WP.Asaas.Sdk.Models.Response;

public class ResponseList<T> : BaseResponse
{
    public ResponseList(HttpStatusCode httpStatusCode, string content) : base(httpStatusCode, content)
    {
        if (httpStatusCode != HttpStatusCode.OK)
        {
            return;
        }

        ResponseList<T>? tempResponse = JsonSerializer.Deserialize<ResponseList<T>>(content);

        if (tempResponse == null)
        {
            return;
        }

        HasMore = tempResponse.HasMore;
        TotalCount = tempResponse.TotalCount;
        Limit = tempResponse.Limit;
        Offset = tempResponse.Offset;
        Data = tempResponse.Data;
    }

    public bool HasMore { get; init; }
    public int TotalCount { get; init; }
    public int Limit { get; init; }
    public int Offset { get; init; }
    public List<T>? Data { get; init; } = [];
}