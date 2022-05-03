using MediatR;
using System.Collections.Generic;

namespace OnionArchitecture.Application.Features.ProductEntity.Queries.GetAll
{
    public class GetAllProductQueryRequest:IRequest<List<GetAllProductQueryResponse>>
    {
        public decimal Price { get; set; }
    }
}
