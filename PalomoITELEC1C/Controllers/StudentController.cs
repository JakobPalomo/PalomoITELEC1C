using Microsoft.AspNetCore.Mvc;
using PalomoITELEC1C.Data;
using PalomoITELEC1C.Models;
using PalomoITELEC1C.Services;
using System.Reflection.Metadata;

namespace PalomoITELEC1C.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _dbContext;
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Student()
        {

            return View(_dbContext.Students);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult EditStud(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditStud(Student studentChange)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == studentChange.Id);
            if (student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Birthday = studentChange.Birthday;
                student.Major = studentChange.Major;
                student.Email = studentChange.Email;
               
            }
            _dbContext.SaveChanges();

            return RedirectToAction("Student");
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid) { 
                return View(); }
               

            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Student");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(student => student.Id == id);
            if (student != null)//was an student found?
                return View(student);
           
            return NotFound();

        }

        [HttpPost]
        public IActionResult Delete(Student delStudent)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == delStudent.Id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
            return RedirectToAction("Student");

        }

    }
    
}
