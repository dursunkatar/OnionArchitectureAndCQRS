using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.ProductEntity.Queries.GetAll;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllProductQueryResponse>> Get()
        {
            return await _mediator.Send(new GetAllProductQueryRequest());
        }
    }
}
