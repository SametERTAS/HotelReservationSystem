using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository City { get; }
        ICountryRepository Country { get; }
        ICustomerRepository Customer { get;  }
        ICustomerReservationRepository CustomerReservation { get;  }
        IDistrictRepository District { get;  }
        IDocumentRepository Document { get;  }
        IHotelRepository Hotel { get;  }
        IReservationRepository Reservation { get;  }
        IRoomRepository Room { get;  }
        IRoomTypeRepository RoomType { get;  }
        
        int SaveChanges();
    }
}
