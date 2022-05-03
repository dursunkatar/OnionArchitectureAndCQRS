using AutoMapper;
using OnionArchitecture.Application.Features.ProductEntity.Queries.GetAll;
using OnionArchitecture.Application.Features.ProductEntity.Queries.GetById;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, GetAllProductQueryResponse>()
                .ReverseMap();
            CreateMap<Product, GetByIdProductQueryResponse>()
                .ReverseMap();
        }
    }
}
