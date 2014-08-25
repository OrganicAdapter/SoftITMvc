using SoftITMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftITMvc.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext Context { get; set; }


        public HomeController()
        {
            Context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            var projects = new List<ShortProjectViewModel>();

            foreach (var project in Context.Projects)
            {
                projects.Add(new ShortProjectViewModel(project.Name, project.Description, project.Logo, project.Size));
            }

            return View(projects);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}