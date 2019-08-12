using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using WebApplication1.Domain;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindEntities DB = new NorthwindEntities();
        private int PageSize = 5;
        //public ActionResult Index()

        //{



        //    return View(db.Customers.ToList());
        //}
        public ActionResult Index(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;

            var customer = DB.Customers.OrderBy(x => x.CustomerID);
            
            var result = customer.ToPagedList(currentPage, PageSize);
     
            return View(result);
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