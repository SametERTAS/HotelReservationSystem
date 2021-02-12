using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.WebUI.ViewModels.Customer
{
    public class CustomerCreateVM
    {
        public enum Gender
        {
            Male,
            Female
        }



        [Display(Name = "First Name")]
        [Required]
        
        public string FirstName { get; set; }



        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0} must be max {1}, min {2} character")]
        public string LastName { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }



        [Required]
        [StringLength(200, MinimumLength = 40, ErrorMessage = "{0} must be max {1}, min {2} character")]
        public string Adress { get; set; }


        [Display(Name = "Phone Number")]
        [Required]
        [StringLength(15, MinimumLength = 9, ErrorMessage = "{0} must be max {1}, min {2} character")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Identity Number")]
        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} must be max {1}, min {2} character")]
        public string IdentityNumber { get; set; }
        public Gender Genderr { get; set; }
    }
}
