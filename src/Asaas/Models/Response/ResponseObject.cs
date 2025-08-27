using System.Net;
using System.Text.Json;

namespace WP.Asaas.Sdk.Models.Response;

public class ResponseObject<T> : BaseResponse
{
    public ResponseObject(HttpStatusCode httpStatusCode, string content) : base(httpStatusCode, content)
    {
        if (httpStatusCode != HttpStatusCode.OK)
        {
            return;
        }

        Data = JsonSerializer.Deserialize<T>(content);
    }

    public T Data { get; }
}