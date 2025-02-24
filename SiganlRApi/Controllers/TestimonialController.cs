using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;

using SignalR.EntityLayer.Entities;

namespace SiganlRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
               Comment=createTestimonialDto.Comment,
               ImageUrl=createTestimonialDto.ImageUrl,
               Name=createTestimonialDto.Name,
               TestimonialStatus=createTestimonialDto.TestimonialStatus,
               Title=createTestimonialDto.Title
            });
            return Ok("Referans Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Referans Silindi");
        }

        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
               TestimonialID=updateTestimonialDto.TestimonialID,
               Comment=updateTestimonialDto.Comment,
               ImageUrl=updateTestimonialDto.ImageUrl,
               Name= updateTestimonialDto.Name,
               TestimonialStatus= updateTestimonialDto.TestimonialStatus,
               Title = updateTestimonialDto.Title
            });
            return Ok("Referans Güncellendi");

        }
    }
}
