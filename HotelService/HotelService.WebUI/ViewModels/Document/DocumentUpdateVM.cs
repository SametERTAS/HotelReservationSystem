using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Document
{
    public class DocumentUpdateVM
    {
        public int CustomerId { get; set; }
        public string PhotoUrl { get; set; }
        public string IdentityCardCopy { get; set; }
    }
}
