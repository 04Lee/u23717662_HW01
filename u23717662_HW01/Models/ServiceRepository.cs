﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
    public class ServiceRepository
    {
        public static List<Service> Services = new List<Service>
    {
        new Service {
            ServiceID = 1,
            Name = "Advanced Life Support",
            Description = "ALS ambulance is staffed by a Paramedic and isuded to transport patients who require high level of care",
            ImagePath = "~/Content/Images/Vehicles/ALS.jpeg",
            Drivers = new List<Driver>(),
            Vehicles = new List<Vehicle>()
        },
        new Service {
            ServiceID = 2,
            Name = "Basic Life Support",
            Description = "BLS ambulance provides transport to patient swho are in a non life threatening condition",
            ImagePath = "~/Content/Images/Vehicles/BLS.jpeg",
            Drivers = new List<Driver>(),
            Vehicles = new List<Vehicle>()
        },
        new Service {
            ServiceID = 3,
            Name = "Patient Support",
            Description = "The most basic type of transport for patients requireing ambulatory support to and from the hospital",
            ImagePath = "~/Content/Images/Vehicles/Patient.jpeg",
            Drivers = new List<Driver>(){

            },

        },
        new Service {
            ServiceID = 4,
            Name = "Medical Utility Vehicle",
            Description = "A state-of-the-art small of large van that is designed to facilitate the mvement and transport of patients",
            ImagePath = "~/Content/Images/Vehicles/Medical.jpeg",
            Drivers = new List<Driver>(),
            Vehicles = new List<Vehicle>()
        },
        new Service {
            ServiceID = 5,
            Name = "Event Medical Ambulance",
            Description = "Ambulances that are stationed at events, such as concerts, sports games, and festivals, to provide medical assistance ",
            ImagePath = "~/Content/Images/Vehicles/Event.jpeg",
            Drivers = new List<Driver>(),
            Vehicles = new List<Vehicle>()
        },
        new Service {
            ServiceID = 6,
            Name = "Air Ambulance",
            Description  = "Air ambulance help in the transfer of patients across long distances in both emergency and non-emergency situations",
            ImagePath = "~/Content/Images/Vehicles/Air.jpeg",
            Drivers = new List<Driver>(),
            Vehicles = new List<Vehicle>()
        }
    };

        public static List<Booking> Bookings = new List<Booking>();


        public static List<Reason> reasons = new List<Reason>
        {
            new Reason { ReasonID = 1, Description = "Urgent medical condition" },
            new Reason { ReasonID = 2, Description = "Non-life-threatening event" },
            new Reason { ReasonID = 3, Description = "Standard transit" },
            new Reason { ReasonID = 4, Description = "Other" }
        };


    }
}