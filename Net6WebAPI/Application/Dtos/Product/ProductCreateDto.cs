namespace Net6WebAPI.Application.Dtos.Product
{
    public class ProductCreateDto
    {
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? ListPrice { get; set; }
        public int Stock { get; set; }


    }
}
