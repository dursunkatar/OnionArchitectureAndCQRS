using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Application.Interfaces.UnitOfWoks;

namespace OnionArchitecture.Application.Features.ProductEntity.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ~CreateProductCommandHandler()
        {
            _unitOfWork.Dispose();
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                ProductName = request.ProductName,
                Price = request.Price
            };

            var result = await _unitOfWork.ProductRepository.AddAsync(product);

            return new CreateProductCommandResponse
            {
                Succed = result != null,
                Message = "Başarıyla Eklendi"
            };
        }
    }
}
