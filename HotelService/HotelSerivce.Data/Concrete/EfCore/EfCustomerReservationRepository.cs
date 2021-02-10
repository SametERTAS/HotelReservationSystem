using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfCustomerReservationRepository : EfGenericRepository<CustomerReservation>, ICustomerReservationRepository
    {
        public EfCustomerReservationRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
