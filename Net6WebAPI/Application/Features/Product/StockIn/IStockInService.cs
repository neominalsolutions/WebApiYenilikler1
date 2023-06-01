using Net6WebAPI.Application.Dtos.Product;
using Net6WebAPI.Application.Features.Product.StockOut;

namespace Net6WebAPI.Application.Features.Product.StockIn
{

  public interface IStockService:IStockInService, IStockOutService
  {

  }

  public interface IStockInService
  {
    public Task StockIn(StockInDto stockInDto);
  }
}
