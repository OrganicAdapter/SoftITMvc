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
        public ProjectModelEntities Entities { get; set; }

        public HomeController()
        {
            Entities = new ProjectModelEntities();
        }

        public ActionResult Index()
        {
            var shortProjectList = new List<ShortProjectVeiwModel>();

            foreach (var project in Entities.ProjectSet)
            {
                if (project.State == ProjectState.Ready)
                {
                    var shortProject = new ShortProjectVeiwModel()
                    {
                        Name = project.Name,
                        Description = project.Description,
                        Logo = project.Logo
                    };

                    shortProjectList.Add(shortProject);
                }
            }

            return View(shortProjectList);
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