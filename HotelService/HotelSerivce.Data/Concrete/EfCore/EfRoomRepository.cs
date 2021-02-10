using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfRoomRepository : EfGenericRepository<Room>, IRoomRepository
    {
        public EfRoomRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
