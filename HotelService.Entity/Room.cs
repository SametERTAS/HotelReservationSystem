using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelService.Entity
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }

        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        [ForeignKey("HotelId")]
        public Hotel Hotel { get; set; }
        [ForeignKey("RoomTypeId")]
        public RoomType RoomType { get; set; }
    }
}
