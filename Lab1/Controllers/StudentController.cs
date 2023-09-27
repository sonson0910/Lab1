using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Lab1.Controllers
{
    public class StudentController : Controller
    {
        [Route("Admin/Student/Index")]
        public IActionResult Index() { return View(ListStudents); }


        private List<Student> listStudents = new List<Student>()
        {
            new Student() {Id = 101, Name = "Son", Branch = Branch.IT, Gender = Gender.Female, IsRegular = true, Address = "433", Email = "Sonlearn155@gmail.com", Diem = 9.4},
            new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT,
            Gender = Gender.Male, IsRegular=true,
            Address = "A1-2018", Email = "nam@g.com", Diem = 8.2},

            new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
            Gender = Gender.Female, IsRegular=true,
            Address = "A1-2019", Email = "tu@g.com", Diem = 7.6 },

            new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
            Gender = Gender.Male, IsRegular=false,
            Address = "A1-2020", Email = "phong@g.com" , Diem = 8.0},

            new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
            Gender = Gender.Female, IsRegular = false,
            Address = "A1-2021", Email = "mai@g.com", Diem = 3.6 }
        };

        public List<Student> ListStudents { get => listStudents; set => listStudents = value; }

        [HttpGet("Admin/Student/List")]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem {Text = "IT", Value = "1"},
                new SelectListItem {Text = "BE", Value="2"},
                new SelectListItem{Text = "CE", Value = "3"},
                new SelectListItem{Text = "EE", Value = "4"}
            };
            return View();
        }
        
        [HttpPost("Admin/Student/List")]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = ListStudents.Last().Id + 1;
                ListStudents.Add(s);
                return View("Index", ListStudents);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem {Text = "IT", Value = "1"},
                new SelectListItem {Text = "BE", Value="2"},
                new SelectListItem{Text = "CE", Value = "3"},
                new SelectListItem{Text = "EE", Value = "4"}
            };
            return View();
        }

        
    }
}
