﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.BookingDto
{
    public class GetBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string PersonelCount { get; set; }
        public DateTime Date { get; set; }
    }
}
