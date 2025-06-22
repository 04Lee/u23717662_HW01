using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace u23717662_HW01.Models
{
    public class Booking
    {
        [Key]
        public Guid BookingID { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Pickup Time is required")]
        public DateTime PickupTime { get; set; }

        [Required(ErrorMessage = "Pickup Address is required")]
        public string PickupAddress { get; set; }

        [Required(ErrorMessage = "SOS field is required")]
        public bool isSOS { get; set; }

        [Required(ErrorMessage = "Booking Date is required")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Driver ID is required")]
        public int DriverID { get; set; }

        [Required(ErrorMessage = "Vehicle ID is required")]
        public int VehicleID { get; set; }

        [Required(ErrorMessage = "Service ID is required")]
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Reason ID is required")]
        public int ReasonID { get; set; }
    }
}