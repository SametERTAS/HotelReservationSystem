using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.CustomerReservation
{
    public class CustomerReservationIndexVM
    {
        public int Id { get; set; }
        [Display(Name = "Reservation")]
        public string ReservationInfo { get; set; }
        [Display(Name = "Customer")]
        public string CustomerInfo { get; set; }
    }
}
