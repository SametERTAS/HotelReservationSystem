using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelService.Entity
{
    public class CustomerReservation : IEntity
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("ReservationId")]
        public Reservation Reservation { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
