using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Room
{
    public class RoomCreateVM
    {
    
        public string RoomNumber { get; set; }

        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
    }
}
