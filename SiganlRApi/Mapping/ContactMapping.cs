using AutoMapper;
using SignalR.DtoLayer.ContactDto;

namespace SiganlRApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<ContactMapping,ResultContactDto>().ReverseMap();
            CreateMap<ContactMapping,CreateContactDto>().ReverseMap();
            CreateMap<ContactMapping,UpdateContactDto>().ReverseMap();
            CreateMap<ContactMapping,GetContactDto>().ReverseMap();
        }
    }
}
