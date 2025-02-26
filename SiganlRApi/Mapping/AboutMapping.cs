﻿using AutoMapper;
using SiganlR.EntityLayer.Entities;
using SignalR.DtoLayer.AboutDto;

namespace SiganlRApi.Mapping
{
    public class AboutMapping :Profile
    {
        public AboutMapping()
        {
            CreateMap<About,ResultAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
            CreateMap<About,GetAboutDto>().ReverseMap();
        }
    }
}
