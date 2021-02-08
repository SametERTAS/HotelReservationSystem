using HotelSerivce.Data.Abstract;
using HotelService.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfDistrictRepository : EfGenericRepository<District>, IDistrictRepository
    {
        public EfDistrictRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
