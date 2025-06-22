using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static u23717662_HW01.Models.VehicleRepository;

namespace u23717662_HW01.Models
{
    public class DriverRepository
    {
        public static List<Driver> Drivers = new List<Driver>
        {
        
            new Driver
            {
                DriverID = 1,
                FirstName = "William",
                LastName = "Test",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0745263846",
                ServiceID = 1
            },
            new Driver
            {
                DriverID = 2,
                FirstName = "Mabutho",
                LastName = "Mchunu",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0694266837",
                ServiceID = 1
            },

            new Driver
            {
                DriverID = 3,
                FirstName = "Gwen",
                LastName = "Stacey",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver2.png"),
                PhoneNumber = "0785563985",
                ServiceID = 2
            },
            new Driver
            {
                DriverID = 4,
                FirstName = "Gugu",
                LastName = "Zwane",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver2.png"),
                PhoneNumber = "0856344545",
                ServiceID = 2
            },

            new Driver
            {
                DriverID = 5,
                FirstName = "Zulu",
                LastName = "Mashabela",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0896567789",
                ServiceID = 3
            },
            new Driver
            {
                DriverID = 6,
                FirstName = "Tumelo",
                LastName = "Meke",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver2.png"),
                PhoneNumber = "0866563342",
                ServiceID = 3
            },

            new Driver
            {
                DriverID = 7,
                FirstName = "Pretty",
                LastName = "Khonza",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver2.png"),
                PhoneNumber = "0787888559",
                ServiceID = 4
            },
            new Driver
            {
                DriverID = 8,
                FirstName = "Junior",
                LastName = "Drake",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0882345678",
                ServiceID = 4
            },

            new Driver
            {
                DriverID = 9,
                FirstName = "Travis",
                LastName = "Scott",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Drivers/driver1.png"),
                PhoneNumber = "0892345678",
                ServiceID = 5
            },
            
        };
    }
}