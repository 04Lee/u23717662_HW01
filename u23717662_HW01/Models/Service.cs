using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}