using MediatR;
using OnionArchitecture.Application.Interfaces.UnitOfWoks;
using OnionArchitecture.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.ProductEntity.Commands.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        ~UpdateProductCommandHandler()
        {
            _unitOfWork.Dispose();
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            using var transaction = await _unitOfWork.BeginTransactionAsync();
            try
            {
                Product product = await _unitOfWork.ProductRepository.GetByIdAsync(request.Id);
                product.ProductName = request.ProductName;
                product.Price = request.Price;
                await _unitOfWork.SaveChangesAsync();
                await transaction.CommitAsync();
                return new UpdateProductCommandResponse
                {
                    Succed = true,
                    Message = "Başaıyla güncellendi"
                };
            }
            catch
            {
                await transaction.RollbackAsync();
                return new UpdateProductCommandResponse
                {
                    Succed = false,
                    Message = "hata"
                };
            }
        }
    }
}
