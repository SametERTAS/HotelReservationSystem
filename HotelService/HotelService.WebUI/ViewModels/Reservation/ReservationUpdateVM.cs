using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Reservation
{
    public class ReservationUpdateVM
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int PersonCount { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal Price { get; set; }
    }
}
