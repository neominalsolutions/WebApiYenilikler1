using DataAnnotationsExtensions;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Net6WebAPI.Application.Dtos.Product
{
    public class StockInDto:IRequest
    {

        [Required(ErrorMessage = "Ürün Id si boş")]
        public string ProductId { get; set; }


        [Max(10, ErrorMessage = "Aynı üründen 10 adetten fazla stoklanamaz")]
        public int Amount { get; set; }

        public string StockType { get; set; } = "StockIn";



    }
}
