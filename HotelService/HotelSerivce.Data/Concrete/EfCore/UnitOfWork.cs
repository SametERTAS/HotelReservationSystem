using HotelSerivce.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelServiceContext _context;
        public UnitOfWork(HotelServiceContext context)
        {
            _context = context;
        }


        private ICityRepository _city;
        private ICountryRepository _country;
        private ICustomerRepository _customer;
        private ICustomerReservationRepository _customerReservation;
        private IDistrictRepository _district;
        private IDocumentRepository _document;
        private IHotelRepository _hotel;
        private IReservationRepository _reservation;
        private IRoomRepository _room;
        private IRoomTypeRepository _roomType;


        public ICityRepository City { get { return _city ?? (_city = new EfCityRepository(_context)); } }
        public ICountryRepository Country { get { return _country ?? (_country = new EfCountryRepository(_context)); } }
        public ICustomerRepository Customer { get { return _customer ?? (_customer = new EfCustomerRepository(_context)); } }
        public ICustomerReservationRepository CustomerReservation { get { return _customerReservation ?? (_customerReservation = new EfCustomerReservationRepository(_context)); } }
        public IDistrictRepository District { get { return _district ?? (_district = new EfDistrictRepository(_context)); } }
        public IDocumentRepository Document { get { return _document ?? (_document = new EfDocumentRepository(_context)); } }
        public IHotelRepository Hotel { get { return _hotel ?? (_hotel = new EfHotelRepository(_context)); } }
        public IReservationRepository Reservation { get { return _reservation ?? (_reservation = new EfReservationRepository(_context)); } }
        public IRoomRepository Room { get { return _room ?? (_room = new EfRoomRepository(_context)); } }
        public IRoomTypeRepository RoomType { get { return _roomType ?? (_roomType = new EfRoomTypeRepository(_context)); } }






        public void Dispose() => _context.Dispose();

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
