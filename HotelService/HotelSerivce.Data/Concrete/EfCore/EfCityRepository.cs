using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfCityRepository : EfGenericRepository<City>, ICityRepository
    {
        public EfCityRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
