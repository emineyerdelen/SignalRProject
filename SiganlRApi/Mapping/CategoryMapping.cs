﻿using AutoMapper;
using SiganlR.EntityLayer.Entities;
using SignalR.DtoLayer.CategoryDto;

namespace SiganlRApi.Mapping
{
    public class CategoryMapping :Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryDto>().ReverseMap();
        }
    }
}
