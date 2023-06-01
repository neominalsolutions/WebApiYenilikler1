
using MediatR;
using Net6WebAPI.Application.Dtos.Product;

namespace Net6WebAPI.Application.Features.Product.Delete
{
  public class ProductDeleteHandler : IRequestHandler<ProductDeleteDto>
  {
    public Task Handle(ProductDeleteDto request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
