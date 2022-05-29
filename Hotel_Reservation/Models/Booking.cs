using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Reservation.Models
{
    public class Booking
    {  

        public int Id { get; set; }

        [ForeignKey("customer")]
        
        public string customerId { get; set; }

        [Required(ErrorMessage = "Booking From Date IS Required")]

        public DateTime From { get; set; }
        [Required(ErrorMessage = "Booking To Date IS Required")]
        [Remote(action: "ToGreaterThanFrom", controller: "Validations", AdditionalFields = "From", ErrorMessage = "To Date Must be Greater Than From Date")]

        public DateTime To { get; set; }


        [ForeignKey("RoomType")]
        
        public int RoomTypeId { get; set; }
        [ForeignKey("Room")]
        public int? RoomId { get; set; }

        public int? Status { get; set; }
        public virtual RoomType RoomType { get; set; }

        public virtual User customer { get; set; }
        public virtual Room Room { get; set; }

        

    }
}
