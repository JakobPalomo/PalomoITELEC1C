using Microsoft.AspNetCore.Mvc;
using PalomoITELEC1C.Models;
namespace PalomoITELEC1C.Controllers
{
    public class StudentController : Controller
    {

        List<Student> StudentList = new List<Student>() {
            new Student()
                {
                    Id= 1,FirstName="Jakob",
                LastName="Palomo",
                Birthday=DateTime.Parse("12/08/2002"),
                Major=Major.BSIT,
                Email="jakob@gmail.com"
            },
            new Student()
                {
                    Id= 2,FirstName="Edmond",
                LastName="Garraton",
                Birthday=DateTime.Parse("12/12/2002"),
                Major=Major.BSIT,
                Email="fhourze@gmail.com"
            }
            };

        public IActionResult Student()
        {
            //var st = new Student();
            //st.Id = 1;
            //st.FirstName = "Palomo";
            //st.LastName = "Jakob Michael";
            //st.Birthday = DateTime.Now;
            //st.email = "palomo@gmail.com";
            //st.Major = Major.BSIT;

            //ViewBag.student = st;

            return View(StudentList);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

    }
}
