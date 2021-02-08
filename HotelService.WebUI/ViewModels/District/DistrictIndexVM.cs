using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.District
{
    public class DistrictIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PhoneCode { get; set; }
        public string City { get; set; }
    }
}
