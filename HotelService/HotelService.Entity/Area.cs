using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelService.Entity
{
    public class Area : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int PhoneCode { get; set; }

    }
}
