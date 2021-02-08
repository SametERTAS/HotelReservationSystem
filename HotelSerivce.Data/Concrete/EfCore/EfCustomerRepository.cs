using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
   public class EfCustomerRepository : EfGenericRepository<Customer>,ICustomerRepository
    {
        public EfCustomerRepository(HotelServiceContext context):base(context)
        {

        }
    }
}
