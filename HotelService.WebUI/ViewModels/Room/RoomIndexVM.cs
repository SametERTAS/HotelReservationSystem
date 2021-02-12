using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Room
{
    public class RoomIndexVM
    {
        public int Id { get; set; }
        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        [Display(Name = "Room Type")]
        public string RoomType { get; set; }
    }
}
