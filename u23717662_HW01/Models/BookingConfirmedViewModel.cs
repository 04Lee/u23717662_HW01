﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
    public class BookingConfirmedViewModel
    {
        public Booking Booking { get; set; }
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}