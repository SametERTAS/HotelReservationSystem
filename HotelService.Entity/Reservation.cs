using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelService.Entity
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int PersonCount { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }
    }
}
