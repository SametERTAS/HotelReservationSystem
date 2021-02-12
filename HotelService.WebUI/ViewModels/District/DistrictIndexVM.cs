using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.District
{
    public class DistrictIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Phone Code")]
        public int PhoneCode { get; set; }
        public string City { get; set; }
    }
}
