using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Country
{
    public class CountryCreateVM
    {


        [Required(ErrorMessage = "Please type a name")]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }



        [Display(Name = "Phone Code")]
        [Range(0, 1000)]
        public int PhoneCode { get; set; }
    }
}
