using HotelService.Entity;
using System;

namespace HotelService.WebUI.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
       
    }
}
