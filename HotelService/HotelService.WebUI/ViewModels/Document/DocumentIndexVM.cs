using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Document
{
    public class DocumentIndexVM
    {
        public int Id { get; set; }
        public string CustomerInfo { get; set; }
        public string PhotoUrl { get; set; }
        public string IdentityCardCopy { get; set; }
    }
}
