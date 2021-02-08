using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelService.Entity
{
    public class Document : IEntity
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string IdentityCardCopy { get; set; }
        [ForeignKey("Id")]
        public Customer Customer { get; set; }
    }
}
