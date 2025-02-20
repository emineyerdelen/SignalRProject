using AutoMapper;
using SiganlR.EntityLayer.Entities;
using SignalR.DtoLayer.BookingDto;

namespace SiganlRApi.Mapping
{
    public class BookingMapping :Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking,ResultBookingDto>().ReverseMap();
            CreateMap<Booking,UpdateBookingDto>().ReverseMap();
            CreateMap<Booking,CreateBookingDto>().ReverseMap();
            CreateMap<Booking,GetBookingDto>().ReverseMap();
        }
    }
}
