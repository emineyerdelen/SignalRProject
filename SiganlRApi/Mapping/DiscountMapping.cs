using AutoMapper;
using SiganlR.EntityLayer.Entities;
using SignalR.DtoLayer.DiscountDto;

namespace SiganlRApi.Mapping
{
    public class DiscountMapping :Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
        
        }
    }
}
