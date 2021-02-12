using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.RoomType
{
    public class RoomTypeUpdateVM
    {
        public int Id { get; set; }
        [Display(Name = "Room Name")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "{0} must be max {1}, min {2} character")]
        [Required]
        public string RoomName { get; set; }
        [Range(1, 15)]
        public int Capacity { get; set; }
    }
}
