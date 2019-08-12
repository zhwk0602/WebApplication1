using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Domain;

namespace WebApplication1.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Detail(string id)
        {
            var entity = new NorthwindEntities();

            var item = entity.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(item);
        }
        [HttpPost]
        public ActionResult Detail(Customers viewModle)
        {
            if (!this.ModelState.IsValid)

            {
                return View(viewModle);
            }
            var entity = new NorthwindEntities();
            return this.View("Detail", viewModle);
        }
    }
}