using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WP.Asaas.Sdk.Interfaces;
using WP.Asaas.Sdk.Models.PaymentPix.Requests;
using WP.Asaas.Sdk.Models.PaymentPix.Responses;
using WP.Asaas.Sdk.Models.Common;

namespace IntegrationTests.Controllers;

/// <summary>
/// Gerenciamento de PIX (QR Codes, Chaves PIX, Pagamentos)
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Tags("PIX")]
[AllowAnonymous]
public class PixController : ControllerBase
{
    private readonly IPixPaymentMethodService _pixPaymentMethodService;

    public PixController(IPixPaymentMethodService pixPaymentMethodService)
    {
        _pixPaymentMethodService = pixPaymentMethodService;
    }

    /// <summary>
    /// Criar QR Code PIX estático
    /// </summary>
    /// <param name="request">Dados do QR Code</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do QR Code criado</returns>
    /// <response code="200">QR Code criado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("qrCodes/static")]
    [ProducesResponseType(typeof(PixQrCodeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreatePaymentPixQrCodeStatic([FromBody] PixQRCodeRequest request, CancellationToken cancellationToken)
    {
        var result = await _pixPaymentMethodService.CreatePaymentPixQRCodeStaticAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Deletar QR Code PIX estático
    /// </summary>
    /// <param name="qrCodeId">ID do QR Code</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <response code="204">QR Code deletado com sucesso</response>
    /// <response code="404">QR Code não encontrado</response>
    [HttpDelete("qrCodes/static/{qrCodeId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePaymentPixQrCodeStatic(string qrCodeId, CancellationToken cancellationToken)
    {
        await _pixPaymentMethodService.DeletePaymentPixQRCodeStaticAsync(qrCodeId, cancellationToken);
        return NoContent();
    }

    /// <summary>
    /// Criar chave PIX
    /// </summary>
    /// <param name="request">Dados da chave PIX</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da chave criada</returns>
    /// <response code="200">Chave criada com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("addressKeys")]
    [ProducesResponseType(typeof(PixAddressKeyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreatePixAddressKey([FromBody] CreatePixAddressKeyRequest request, CancellationToken cancellationToken)
    {
        var result = await _pixPaymentMethodService.CreatePixAddressKeyAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Deletar chave PIX
    /// </summary>
    /// <param name="addressKeyId">ID da chave PIX</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <response code="204">Chave deletada com sucesso</response>
    /// <response code="404">Chave não encontrada</response>
    [HttpDelete("addressKeys/{addressKeyId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePixAddressKey(string addressKeyId, CancellationToken cancellationToken)
    {
        await _pixPaymentMethodService.DeletePixAddressKeyAsync(addressKeyId, cancellationToken);
        return NoContent();
    }

    /// <summary>
    /// Listar todas as chaves PIX
    /// </summary>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Lista de chaves PIX</returns>
    /// <response code="200">Lista retornada com sucesso</response>
    [HttpGet("addressKeys")]
    [ProducesResponseType(typeof(PixAddressKeyListResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetPixAddressKeys(CancellationToken cancellationToken)
    {
        var result = await _pixPaymentMethodService.GetPixAddressKeysAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Buscar uma chave PIX por ID
    /// </summary>
    /// <param name="addressKeyId">ID da chave PIX</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados da chave PIX</returns>
    /// <response code="200">Chave encontrada</response>
    /// <response code="404">Chave não encontrada</response>
    [HttpGet("addressKeys/{addressKeyId}")]
    [ProducesResponseType(typeof(PixAddressKeyResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPixAddressKeyById(string addressKeyId, CancellationToken cancellationToken)
    {
        var result = await _pixPaymentMethodService.GetPixAddressKeyByIdAsync(addressKeyId, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Realizar pagamento via QR Code PIX
    /// </summary>
    /// <param name="request">Dados do pagamento PIX</param>
    /// <param name="cancellationToken">Token de cancelamento</param>
    /// <returns>Dados do pagamento realizado</returns>
    /// <response code="200">Pagamento realizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    [HttpPost("qrCodes/pay")]
    [ProducesResponseType(typeof(PaymentPixQRCodeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PaymentPixQrCode([FromBody] PaymentPixQRCodeRequest request, CancellationToken cancellationToken)
    {
        var result = await _pixPaymentMethodService.PaymentPixQRCodeAsync(request, cancellationToken);
        return Ok(result);
    }
}

