using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TyrellStudyGroup.Models;

namespace TyrellStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> Students = new List<Student>
            {
                new Student { StudentNumber = "u23540819", Name = "Tyrell", Surname = "Moodley", EmailAddress = "u23540819@tuks.co.za"},
                new Student { StudentNumber = "u23843022", Name = "Newo", Surname = "Munyai", EmailAddress = "u23843022@tuks.co.za"},
                new Student { StudentNumber = "u23613875", Name = "Kael", Surname = "Stainbank", EmailAddress = "u23613875@tuks.co.za"},
                new Student { StudentNumber = "u23671904", Name = "Morobi", Surname = "Bonyana", EmailAddress = "u23671904tuks.co.za"},
                new Student { StudentNumber = "u23638746", Name = "Declan", Surname = "Hart", EmailAddress = "u23638746@tuks.co.za"}
            };
            return View(Students);
        }
    }
}