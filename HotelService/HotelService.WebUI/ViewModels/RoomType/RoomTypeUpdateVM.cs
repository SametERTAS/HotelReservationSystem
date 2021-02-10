using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.RoomType
{
    public class RoomTypeUpdateVM
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
    }
}
