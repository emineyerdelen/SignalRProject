using AutoMapper;
using SiganlR.EntityLayer.Entities;
using SignalR.DtoLayer.ProductDto;

namespace SiganlRApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
        }
    }
}
