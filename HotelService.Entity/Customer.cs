using HotelService.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelService.Entity
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public string FullName { get { return FirstName + " " + LastName; } }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }
        public Gender Gender { get; set; }

        public Document Document { get; set; }
    }

}
