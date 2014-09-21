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
                if (project.State == ProjectState.Finished)
                    projects.Add(new ShortProjectViewModel(project.Name, project.Description, project.Logo, project.Size));
            }

            return View(projects);
        }

        public ActionResult About()
        {
            var name = "";
            var procurer = "";
            var tel = "";

            if (User.Identity.IsAuthenticated)
            {
                name = User.Identity.Name;
                var current = Context.Orders.Where((x) => x.ProcurerId.Equals(User.Identity.Name)).FirstOrDefault();

                if (current != null)
                {
                    procurer = current.ProcurerName;
                    tel = current.Tel;
                }
            }

            var order = new Order()
            {
                ProcurerId = name,
                ProcurerName = procurer,
                Tel = tel
            };

            return View(order);
        }

        [HttpPost]
        public ActionResult About(Order order)
        {
            Context.Orders.Add(order);

            var project = new Project()
            {
                ProcurerId = order.ProcurerId,
                Name = order.ProjectName,
                Description = order.Description,
                Deadline = order.Deadline,
                State = ProjectState.WaitingForApproval,
                EmployeeId = Context.Employees.Where((x) => x.FullName.Equals("Simándi Gergely")).FirstOrDefault().EmployeeId,
                Logo = "http://softit.hu/Content/Images/placeholder.png"
            };

            Context.Projects.Add(project);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            return View();
        }

        [Authorize]
        public ActionResult Projects()
        {
            var proj = Context.Projects.Where((x) => x.ProcurerId.Equals(User.Identity.Name)).ToList();

            var projects = new List<ShortProjectViewModel>();

            foreach (var project in proj)
            {
                projects.Add(new ShortProjectViewModel(project.Name, project.Description, project.Logo, project.Size));
            }

            return View(projects);
        }

        public ActionResult Details(string modelName)
        {
            var fullModel = Context.Projects.Where((x) => x.Name.Equals(modelName)).FirstOrDefault();

            return View(fullModel);
        }

        [HttpPost]
        public ActionResult Details(Project project)
        {
            if (ModelState.IsValid)
            {
                var proj = Context.Projects.Where((x) => x.ProjectId == project.ProjectId).FirstOrDefault();
                proj.Rating = project.Rating;
                Context.SaveChanges();

                return View(proj);
            }

            return View(project);
        }
    }
}