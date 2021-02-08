using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfRoomTypeRepository : EfGenericRepository<RoomType>, IRoomTypeRepository
    {
        public EfRoomTypeRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
