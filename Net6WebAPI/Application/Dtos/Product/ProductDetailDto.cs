namespace Net6WebAPI.Application.Dtos.Product
{

    public class ProductPhotoDto
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

    }

    public class ProductDetailDto
    {
        public string ProductId { get; set; }
        public decimal ListPrice { get; set; }
        public int Stock { get; set; }

        public List<ProductPhotoDto> Photos { get; set; } = new List<ProductPhotoDto>();
    }
}
