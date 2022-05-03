using AutoMapper;
using MediatR;
using OnionArchitecture.Application.Interfaces.UnitOfWoks;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.ProductEntity.Queries.GetAll
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        ~GetAllProductQueryHandler()
        {
            _unitOfWork.Dispose();
        }

        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.ProductRepository.GetAllAsync(x => x.Price == request.Price);
            return products.Select(p => _mapper.Map<GetAllProductQueryResponse>(p)).ToList();

        }
    }
}
