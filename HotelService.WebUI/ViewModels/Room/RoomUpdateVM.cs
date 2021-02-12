using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Room
{
    public class RoomUpdateVM
    {
        public int Id { get; set; }
        [Display(Name = "Room Number")]
        [Required]
        public string RoomNumber { get; set; }
        [Display(Name = "Hotel")]
        public int HotelId { get; set; }
        [Display(Name = "Room Type")]
        public int RoomTypeId { get; set; }
    }
}
