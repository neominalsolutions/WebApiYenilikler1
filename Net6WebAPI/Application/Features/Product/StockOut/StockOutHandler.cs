using MediatR;
using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.StockOut
{
  public class StockOutHandler : IRequestHandler<StockOutDto>
  {
    public Task Handle(StockOutDto request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
