using MediatR;
using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.StockIn
{
  /// <summary>
  /// 1 ayda kullanılmıyor.
  /// </summary>
  public class StockInHandler2 : IRequestHandler<StockInDto2>
  {
    public Task Handle(StockInDto2 request, CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }
  }
}
