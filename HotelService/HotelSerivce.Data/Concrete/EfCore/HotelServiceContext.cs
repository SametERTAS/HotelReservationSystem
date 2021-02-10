using HotelService.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSerivce.Data.Concrete.EfCore
{
    public class HotelServiceContext : DbContext
    {
        public HotelServiceContext(DbContextOptions<HotelServiceContext> options) : base(options)
        {

        }

        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<CustomerReservation> CustomerReservation { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
