using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelService.Entity
{
    public class RoomType : IEntity
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
    }
}
