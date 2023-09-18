using Microsoft.AspNetCore.Mvc;
using PalomoITELEC1C.Models;

namespace PalomoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>() {
            new Instructor()
                {
                Id= 1,
                FirstName="Jakob",
                LastName="Palomo",
                IsTenured=true,
                Rank=Rank.Professor,
                HiringDate=DateTime.Parse("05/05/2023")
            },
            new Instructor()
                {
                    Id= 2,
                FirstName="Zeke",
                LastName="Gonzalez",
                IsTenured=true,
                Rank=Rank.AssistantProfessor,
                HiringDate=DateTime.Parse("05/05/2023")
            }

            };


        public IActionResult Instructor()
        {

            return View(InstructorList);
            
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {

            InstructorList.Add(newInstructor);
            return View("Instructor", InstructorList);
        }
    }
}
