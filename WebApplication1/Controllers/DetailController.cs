using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Domain;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DetailController : Controller
    {
        private NorthwindEntities DB = new NorthwindEntities();

        // GET: Detail
        public ActionResult Edit(string id)
        {
            var entity = new NorthwindEntities();

            var item = entity.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Customers viewModle)
        {
            if (!this.ModelState.IsValid)

            {
                return View(viewModle);
            }
            using (var e = new NorthwindEntities())
            {
            };
            //var result = new ApiResult<string> {
            //    Result = "更新成功",
            //    IsSuccess =true
            //};
            var result = new ApiResult<string>
            {
                ErrorMessage = new List<string>
                {
                    //"更新失敗"
                }
            };

            return this.Json(result);
        }
    }
}