using MediatR;

namespace OnionArchitecture.Application.Features.ProductEntity.Commands.Create
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
