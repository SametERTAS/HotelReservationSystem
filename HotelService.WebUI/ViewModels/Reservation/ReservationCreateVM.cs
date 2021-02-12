using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Reservation
{
    public class ReservationCreateVM
    {
        [Display(Name = "Room Number")]
        public int RoomId { get; set; }
        [Display(Name = "Person Count")]
        public int PersonCount { get; set; }
        [Display(Name = "Chech-In Date")]
        public DateTime CheckInDate { get; set; }
        [Display(Name = "Chech-Out Date")]
        public DateTime CheckOutDate { get; set; }
        public decimal Price { get; set; }

    }
}
