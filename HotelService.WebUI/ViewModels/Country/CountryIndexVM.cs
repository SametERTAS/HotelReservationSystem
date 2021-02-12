using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Country
{
    public class CountryIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Phone Code")]
        public int PhoneCode { get; set; }
    }
}
