

using System.ComponentModel.DataAnnotations;

namespace PalomoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {

        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please Enter your First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter your Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Is Tenured?")]
        public bool IsTenured { get; set; }

        [Required]
        [Display(Name = "Current Rank")]
        public Rank Rank { get; set; }

        [RegularExpression("[0-9]{2}-[0-9]{4}-[0-9]{4}", ErrorMessage ="you need proper phone format 00-0000-0000")]
        [Display(Name = "Telepono")]
        public string Phone { get; set; }

        [Display(Name = "Official Hring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        
    }
}
