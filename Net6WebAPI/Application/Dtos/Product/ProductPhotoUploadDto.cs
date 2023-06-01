namespace Net6WebAPI.Application.Dtos.Product
{
    public class ProductPhotoUploadDto
    {

        public IFormFile Image { get; set; }

        public string ProductId { get; set; }


    }
}
