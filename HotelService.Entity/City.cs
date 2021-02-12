using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelService.Entity
{
    public class City : Area
    {
        
        public int PlateCode { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        
        public Country Country { get; set; }
    }
}
