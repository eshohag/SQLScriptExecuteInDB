using SQLScriptExecuteInDB.DB;
using System.Diagnostics;
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

            var testANny = "Terst";
            var testANny1 = "Ters 2t";
            string[] viewsList = Directory.GetFiles(HostingEnvironment.MapPath("/DB/Scripts/Views"), "*.sql", SearchOption.AllDirectories);
            foreach (var filePath in viewsList)
            {
                var fullCmd = string.Format("sqlcmd -d VelocityAMLWorking -U sa -P aml123 -S 192.168.1.71 -i {0}", filePath); //use /c instead /k if you want to get output
                ExecuteCommand(fullCmd);
            }

            string[] spList = Directory.GetFiles(HostingEnvironment.MapPath("/DB/Scripts/SP"), "*.sql", SearchOption.AllDirectories);
            foreach (var filePath in spList)
            {
                var fullCmd = string.Format("sqlcmd -d VelocityAMLWorking -U sa -P aml123 -S 192.168.1.71 -i {0}", filePath); //use /c instead /k if you want to get output
                ExecuteCommand(fullCmd);
            }

            return View();
        }

        public void ExecuteCommand(string Command)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + Command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;

            Process = Process.Start(ProcessInfo);
        }
    }
}