using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using WebApplication1.Domain;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();
        private int pageSize = 5;
        //public ActionResult Index()

        //{



        //    return View(db.Customers.ToList());
        //}
        public ActionResult Index(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;

            var customer = db.Customers.OrderBy(x => x.CustomerID);
            var t = new Customers();
            t.total = customer.Count();
            var s = t.total / pageSize;
            var result = customer.ToPagedList(currentPage, pageSize);
            var totall = new Models.Totall(s,result);
            return View(totall);
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