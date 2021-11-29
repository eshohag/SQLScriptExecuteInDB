using SQLScriptExecuteInDB.DB;
using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;

namespace SQLScriptExecuteInDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext dbContext;

        public HomeController()
        {
            dbContext = new ApplicationDBContext();
        }
        public ActionResult Index()
        {
            string[] viewsList = Directory.GetFiles(HostingEnvironment.MapPath("/DB/Scripts/Views"), "*.sql", SearchOption.AllDirectories);
            foreach (var file in viewsList)
            {
                var textFile = System.IO.File.ReadAllText(file);

                dbContext.Database.ExecuteSqlCommand(textFile);
            }

            return View();
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