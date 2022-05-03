using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.ProductEntity.Queries.GetById
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
