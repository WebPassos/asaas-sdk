using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WP.Asaas.Sdk.Models.Response;

public abstract class BaseResponse
{
    protected BaseResponse(HttpStatusCode httpStatusCode, string content)
    {
        StatusCode = httpStatusCode;
        AsaasResponse = content;
        BuildErrors();
    }

    public HttpStatusCode StatusCode { get; }

    public List<Error> Errors { get; private set; } = [];

    public string AsaasResponse { get; }

    private void BuildErrors()
    {
        if (StatusCode != HttpStatusCode.BadRequest)
        {
            return;
        }

        JsonNode jNode = JsonNode.Parse(AsaasResponse)!;

        if (jNode != null! && jNode["errors"] != null)
        {
            Errors = JsonSerializer.Deserialize<List<Error>>(jNode["errors"]!.ToString())!;
        }
    }

    public bool WasSucessfull()
    {
        return StatusCode == HttpStatusCode.OK;
    }
}