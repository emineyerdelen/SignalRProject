﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiganlR.EntityLayer.Entities;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using System.Net.Mail;

namespace SiganlRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values=_bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public  IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonelCount = createBookingDto.PersonelCount,
                Phone = createBookingDto.Phone,
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value= _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonelCount = updateBookingDto.PersonelCount,
                Phone = updateBookingDto.Phone,
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value=_bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
