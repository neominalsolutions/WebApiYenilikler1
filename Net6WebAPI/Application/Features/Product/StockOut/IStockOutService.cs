using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.StockOut
{
  public interface IStockOutService
  {
    Task StockOut(StockOutDto stockOutDto);
  }
}
