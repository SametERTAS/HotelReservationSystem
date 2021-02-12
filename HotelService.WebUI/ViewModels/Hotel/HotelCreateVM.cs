using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Hotel
{
    public class HotelCreateVM
    {
        [Required]
        public string Name { get; set; }
        public int Capacity { get; set; }
        [Display(Name = "District")]
        public int DistrictId { get; set; }
    }
}
