using MediatR;

namespace Net6WebAPI.Application.Dtos.Product
{
  public class ProductDeleteDto:IRequest
  {
    public string ProductId { get; set; }
    public string Reason { get; set; }

  }
}
