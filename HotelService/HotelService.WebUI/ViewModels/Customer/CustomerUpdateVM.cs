using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Customer
{
    public class CustomerUpdateVM
    {
        public enum Gender
        {
            Male,
            Female
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string FullName { get { return FirstName + " " + LastName; } }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }
        public Gender Genderr { get; set; }
    }
}
