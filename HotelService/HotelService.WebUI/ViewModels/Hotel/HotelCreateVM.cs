using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Hotel
{
    public class HotelCreateVM
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int DistrictId { get; set; }
    }
}
