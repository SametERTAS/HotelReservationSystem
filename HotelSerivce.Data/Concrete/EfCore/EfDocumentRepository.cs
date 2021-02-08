using System;
using System.Collections.Generic;
using System.Text;
using HotelSerivce.Data.Abstract;
using HotelService.Entity;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class EfDocumentRepository : EfGenericRepository<Document>, IDocumentRepository
    {
        public EfDocumentRepository(HotelServiceContext context) : base(context)
        {

        }
    }
}
