using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.Domain;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DetailController : Controller
    {
       

        // GET: Detail
        public ActionResult Edit(string id)
        {
            var entity = new NorthwindEntities();

            var item = entity.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            return View(item);
        }
      
        public ActionResult Select()
        {
            var entity = new NorthwindEntities();

            var item = entity.Categories;
            
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();

            foreach (var x in item)
            {
                mySelectItemList.Add(new SelectListItem()
                {
                    Value = x.CategoryID.ToString(),
                    Text = x.CategoryName,
                    
                    Selected = false
                });
            }

            ViewModel model = new ViewModel() //上面的 Model
            {
                MyList = mySelectItemList
            };

            return Json(model, JsonRequestBehavior.AllowGet);
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