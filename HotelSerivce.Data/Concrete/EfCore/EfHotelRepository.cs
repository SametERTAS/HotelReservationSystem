using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfHotelRepository : EfGenericRepository<Hotel>, IHotelRepository
    {
        public EfHotelRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
