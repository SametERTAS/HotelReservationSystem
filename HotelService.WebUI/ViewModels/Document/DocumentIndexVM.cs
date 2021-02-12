using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Document
{
    public class DocumentIndexVM
    {
        public int Id { get; set; }
        [Display(Name = "Customer")]
        public string CustomerInfo { get; set; }
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }
        [Display(Name = "Identity Card")]
        public string IdentityCardCopy { get; set; }
    }
}
