using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Hotel
{
    public class HotelUpdateVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Capacity { get; set; }
        [Display(Name = "District")]
        public int DistrictId { get; set; }
    }
}
