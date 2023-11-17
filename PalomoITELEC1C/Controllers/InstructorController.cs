using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PalomoITELEC1C.Data;
using PalomoITELEC1C.Models;
using PalomoITELEC1C.Services;

namespace PalomoITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;
        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       
        public IActionResult Instructor()
        {

            return View(_dbContext.Instructors);
            
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

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
        {   if (!ModelState.IsValid) {
                return View(); }
                

            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }

        [HttpGet]
        public IActionResult EditInst(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditInst(Instructor studentChange)
        {
            Instructor? instructor= _dbContext.Instructors.FirstOrDefault(st => st.Id == studentChange.Id);
            if (instructor != null)
            {
                instructor.Id = studentChange.Id;
                instructor.FirstName = studentChange.FirstName;
                instructor.LastName = studentChange.LastName;
                instructor.Rank = studentChange.Rank;
                instructor.IsTenured = studentChange.IsTenured;
                instructor.HiringDate = studentChange.HiringDate;
                instructor.Phone = studentChange.Phone;

            }
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(instructor => instructor.Id == id);
            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();

        }

        [HttpPost]
        public IActionResult Delete(Instructor delInst)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == delInst.Id);
            _dbContext.Instructors.Remove(instructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Instructor");

        }
    }
}
