using MediatR;
using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.StockIn
{
  public class StockInHandler : IRequestHandler<StockInDto>
  {
    private readonly IHttpContextAccessor httpContextAccessor;

    public StockInHandler(IHttpContextAccessor httpContextAccessor)
    {
      this.httpContextAccessor = httpContextAccessor;
    }
    public Task Handle(StockInDto request, CancellationToken cancellationToken)
    {
      return Task.CompletedTask;
    }
  }
}
