using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfCountryRepository : EfGenericRepository<Country>, ICountryRepository
    {
        public EfCountryRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
