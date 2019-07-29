using System;
using System.Web.Mvc;
using UniManagementApp.entities.ViewModels;
using UniManagementApp.service;

namespace UniManagementApp.web.Controllers
{
    public class PlaceController : Controller
    {

        private PlaceService service=new PlaceService();
        
        // GET: Place
        public ActionResult HouseApply()
        {
            var viewModel = new PlaceViewModel
            {
                ApplyFors=service.GetApplyFor(),
                Designations=service.GetDesignation(),
                Departments=service.GetDepartment(),
                Domiciles=service.GetDomicile(),
                Statuses=service.GetStatus(),

            };
            
            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult HouseApply(PlaceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PlaceViewModel
                {
                    Places=model.Places,
                    ApplyFors = service.GetApplyFor(),
                    Designations = service.GetDesignation(),
                    Departments = service.GetDepartment(),
                    Domiciles = service.GetDomicile(),
                    Statuses = service.GetStatus()
                };
                return View("HouseApply", viewModel);
            }
            else
            {
                service.SaveApply(model.Places);
                return Redirect("HouseApply");
            }
        }

        public JsonResult GetScales(int id)
        {
            var scale=service.GetScaleNo(id);
            return Json(scale, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetJobTitle(int id)
        {
            var scale = service.GetJobTitle(id);
            return Json(scale, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewRecord()
        {
            var list = service.GetRecord();
            return View(list);
        }

        public ActionResult ViewDetail(string cnic)
        {
            var list = service.GetRecord(cnic);
            var viewModel = new PlaceViewModel
            {
                Places = list,
                ApplyFors = service.GetApplyFor(),
                Designations = service.GetDesignation(),
                Departments = service.GetDepartment(),
                Domiciles = service.GetDomicile(),
                Statuses = service.GetStatus()
            };
            return View(viewModel);
        }

        public JsonResult GetDays(DateTime StartDate, DateTime EndDate)
        {
            TimeSpan differnce = StartDate - EndDate;
            var day = differnce.TotalDays;
            var days = day;
            return Json(days, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Merit()
        {
            //Here i have to send start and end date to get merit
            var list = service.GetRecord();
            return View(list);
        }


    }
}