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
        [HttpGet]
        public IActionResult EditStud(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditStud(Student studentChange)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChange.Id);
            if (student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Birthday = studentChange.Birthday;
                student.Major = studentChange.Major;
                student.Email = studentChange.Email;
               
            }

            return View("Student", StudentList);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {

            StudentList.Add(newStudent);
            return View("Student",StudentList);
        }

    }
    
}
