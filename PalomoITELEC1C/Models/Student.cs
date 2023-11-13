using System.ComponentModel.DataAnnotations;

namespace PalomoITELEC1C.Models
{
    public enum Major
    {
        BSIT,BSCS,BSIS
    }
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter your First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter your Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birthdate")]
        [Required(ErrorMessage = "Please Enter your Birthdate")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Major")]
        [Required(ErrorMessage = "What is your Major?")]
        public Major Major { get; set; }

        [Display(Name = "Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
    }
}
