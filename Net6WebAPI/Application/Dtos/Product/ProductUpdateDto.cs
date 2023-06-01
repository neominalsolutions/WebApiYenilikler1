namespace Net6WebAPI.Application.Dtos.Product
{
    public class ProductUpdateDto
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public bool IsContinued { get; set; } = true; // false;

    }

}
