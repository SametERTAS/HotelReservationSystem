using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Room
{
    public class RoomIndexVM
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }

        public int HotelName { get; set; }
        public int RoomType { get; set; }
    }
}
