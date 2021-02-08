using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.City
{
    public class CityUpdateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneCode { get; set; }
        public int PlateCode { get; set; }
        public int CountryId { get; set; }
    }
}
