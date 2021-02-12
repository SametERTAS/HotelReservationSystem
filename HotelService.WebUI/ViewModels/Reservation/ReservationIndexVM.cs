using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Reservation
{
    public class ReservationIndexVM
    {
        public int Id { get; set; }
        [Display(Name = "Room Type")]
        public string RoomInfo { get; set; }
        [Display(Name = "Person Count")]
        public int PersonCount { get; set; }
        [Display(Name = "Check-in Date")]
        public DateTime CheckInDate { get; set; }
        [Display(Name = "Check-out Date")]
        public DateTime CheckOutDate { get; set; }
        public decimal Price { get; set; }
    }
}
