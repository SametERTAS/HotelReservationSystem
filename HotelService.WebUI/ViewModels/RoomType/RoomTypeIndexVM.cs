using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.RoomType
{
    public class RoomTypeIndexVM
    {
        public int Id { get; set; }
        [Display(Name = "Room Name")]
        public string RoomName { get; set; }
        public int Capacity { get; set; }
    }
}
