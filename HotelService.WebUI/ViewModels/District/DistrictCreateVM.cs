using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.District
{
    public class DistrictCreateVM
    {
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} must be max {1}, min {2} character")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Phone Code")]
        public int PhoneCode { get; set; }
        [Display(Name = "City")]
        public int CityId { get; set; }
    }
}
