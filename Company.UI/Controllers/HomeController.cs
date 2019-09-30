using Company.BLL;
using Company.IBLL;
using Company.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.UI.Controllers
{
    public class HomeController : Controller
    {
        private IStaffService staffService = BLLContainer.Container.Resolve<IStaffService>();
        public ActionResult Index()
        {
            List<Staff> list = staffService.GetModels(p => true).ToList();
            //staffService.GetModelsByPage<int>(1,1,true, p => p.Id, p=>true);
            return View(list);
        }

        public ActionResult Add(Staff staff)
        {
            if (staffService.Add(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Update(Staff staff)
        {
            if (staffService.Update(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
        public ActionResult Delete(int Id)
        {
            var staff = staffService.GetModels(p => p.Id == Id).FirstOrDefault();
            if (staffService.Delete(staff))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
    }
}