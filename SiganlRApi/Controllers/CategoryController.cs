﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiganlR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;

namespace SiganlRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                CategoryStatus = true
            });
            return Ok("Kategori Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
               CategoryName=updateCategoryDto.CategoryName,
               CategoryID=updateCategoryDto.CategoryID,
               CategoryStatus = updateCategoryDto.CategoryStatus,   
            });
            return Ok("Kategori Güncellendi");
         
        }
    }
}
