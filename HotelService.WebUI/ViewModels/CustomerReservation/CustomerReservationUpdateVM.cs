using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.CustomerReservation
{
    public class CustomerReservationUpdateVM
    {
        public int Id { get; set; }
        [Display(Name = "Reservation")]
        public int ReservationId { get; set; }
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
    }
}
