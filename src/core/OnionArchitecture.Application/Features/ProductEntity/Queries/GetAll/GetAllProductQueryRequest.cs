using MediatR;
using System.Collections.Generic;

namespace OnionArchitecture.Application.Features.ProductEntity.Queries.GetAll
{
    public class GetAllProductQueryRequest:IRequest<List<GetAllProductQueryResponse>>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
