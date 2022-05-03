using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.ProductEntity.Commands.Create;
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


        [HttpPost]
        public async Task<CreateProductCommandResponse> Post([FromBody] CreateProductCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("search/{Name}")]
        public async Task<List<GetAllProductQueryResponse>> Get([FromQuery] GetAllProductQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("ara")]
        public async Task<List<GetAllProductQueryResponse>> Search([FromQuery] GetAllProductQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
