using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Document
{
    public class DocumentUpdateVM
    {
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }
        [Display(Name = "Identity Card")]
        public string IdentityCardCopy { get; set; }
    }
}
