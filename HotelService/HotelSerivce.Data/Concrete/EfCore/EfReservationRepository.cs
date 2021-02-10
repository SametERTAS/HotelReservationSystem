using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfReservationRepository : EfGenericRepository<Reservation>, IReservationRepository
    {
        public EfReservationRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
