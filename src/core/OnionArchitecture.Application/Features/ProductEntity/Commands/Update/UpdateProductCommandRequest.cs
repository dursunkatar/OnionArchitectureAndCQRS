using MediatR;
using System;

namespace OnionArchitecture.Application.Features.ProductEntity.Commands.Update
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
