using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.District
{
    public class DistrictUpdateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PhoneCode { get; set; }
        public int CityId { get; set; }
    }
}
