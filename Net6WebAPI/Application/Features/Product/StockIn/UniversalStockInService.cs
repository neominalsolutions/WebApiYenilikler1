using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.StockIn
{

  // uluslar arası firmalar üzerinden alınan ürünleri envantere eklerken kullanılacak service
  public class UniversalStockInService : IStockInService
  {
    public async Task StockIn(StockInDto stockInDto)
    {
      throw new NotImplementedException();
    }
  }
}
