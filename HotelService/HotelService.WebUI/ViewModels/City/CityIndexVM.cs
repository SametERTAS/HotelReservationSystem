using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.City
{
    public class CityIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Phone Code")]
        public int PhoneCode { get; set; }
        [Display(Name = "Plate Code")]
        public int PlateCode { get; set; }
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}
