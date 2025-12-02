namespace WP.Asaas.Sdk.Models.PaymentPix.Responses
{
    public class PixAddressKeyListResponse
    {
        public List<PixAddressKeyResponse> Data { get; set; }
    }

    public class PixAddressKeyResponse
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string DateCreated { get; set; }
        public bool CanBeDeleted { get; set; }
        public string CannotBeDeletedReason { get; set; }
        public PixAddressKeyQrCode QrCode { get; set; }
    }

    public class PixAddressKeyQrCode
    {
        public string EncodedImage { get; set; }
        public string Payload { get; set; }
    }
}
