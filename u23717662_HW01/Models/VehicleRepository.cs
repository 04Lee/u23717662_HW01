using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace u23717662_HW01.Models
{
    public class VehicleRepository
    {
         public static List<Vehicle> Vehicles = new List<Vehicle>()
         {

            new Vehicle {
                VehicleID = 1,
                Type = "Advanced Life Support",
                RegNumber = "ALS-00156-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/ALS.jpeg"),
                ServiceID = 1
            },


            new Vehicle {
                VehicleID = 2,
                Type = "Basic Life Support",
                RegNumber = "BLS-00232-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/BLS.jpeg"),
                ServiceID = 2
            },


            new Vehicle {
                VehicleID = 3,
                Type = "Patient Transport",
                RegNumber = "PT-00355-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Patient.jpeg"),
                ServiceID = 3
            },


            new Vehicle {
                VehicleID = 4,
                Type = "Medical Utility Vehicle",
                RegNumber = "MUV-00488-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Medical.jpeg"),
                ServiceID = 4
            },


            new Vehicle {
                VehicleID = 5,
                Type = "Event Medical Ambulance",
                RegNumber = "EMA-00577-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Event.jpeg"),
                ServiceID = 5
            },

            new Vehicle {
                VehicleID = 6,
                Type = "Air Ambulance",
                RegNumber = "AIR-911-Gp",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Air.jpeg"),
                ServiceID = 6
            },

            new Vehicle {
                VehicleID = 7,
                Type = "Advanced Life Support",
                RegNumber = "ALS-00756-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/ALS.jpeg"),
                ServiceID = 1
            },

            new Vehicle {
                VehicleID = 8,
                Type = "Basic Life Support",
                RegNumber = "BLS-00856-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/BLS.jpeg"),
                ServiceID = 2
            },

            new Vehicle {
                VehicleID = 9,
                Type = "Patient Transport",
                RegNumber = "PT-00956-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Patient.jpeg"),
                ServiceID = 3
            },

            new Vehicle {
                VehicleID = 10,
                Type = "Medical Utility Vehicle",
                RegNumber = "MUV-01056-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Medical.jpeg"),
                ServiceID = 4
            },

            new Vehicle {
                VehicleID = 11,
                Type = "Event Medical Ambulance",
                RegNumber = "EMA-01156-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Event.jpeg"),
                ServiceID = 5
            },

            new Vehicle {
                VehicleID = 12,
                Type = "Air Ambulance",
                RegNumber = "AIR-01256-GP",
                ImagePath = "data:image/jpeg;base64," + ImageHelper.ImageToBase64("~/Content/Images/Vehicles/Air.jpeg"),
                ServiceID = 6
            }
         };

        public static class ImageHelper
        {
            public static string ImageToBase64(string relativePath)
            {
                var absolutePath = HostingEnvironment.MapPath(relativePath);
                if (absolutePath == null || !File.Exists(absolutePath))
                    return null;

                byte[] imageBytes = File.ReadAllBytes(absolutePath);
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}