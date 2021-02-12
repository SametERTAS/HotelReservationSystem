using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.City
{
    public class CityUpdateVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} must be max {1}")]
        public string Name { get; set; }
        [Display(Name = "Phone Code")]
        public int PhoneCode { get; set; }
        [Display(Name = "Plakte Code")]
        public int PlateCode { get; set; }
        [Display(Name = "Country")]
        public int CountryId { get; set; }
    }
}
