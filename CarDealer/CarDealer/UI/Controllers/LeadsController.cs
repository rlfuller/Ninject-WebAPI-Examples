using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Business;
using Models;

namespace UI.Controllers
{
    public class LeadsController : Controller
    {
        // GET: Leads
        public ActionResult Index()
        {
            try
            {
                var leadBusiness = ReadAllBussinessFactory.NewReadLeadSummaryBusiness();
                var responseList = leadBusiness.ReadAll();
                return View(responseList);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }            
        }

        public ActionResult Manage(int id, int vehID)
        {
            try
            {
                var leadBus = IViewModelPrimeableFactory.NewLeadUpdatePrimer();
                var request = new Request<LeadUpdateVM>();
                request.Data.VehID = vehID;
                request.Data.LeadID = id;
                var responseVM = leadBus.PrimeViewModel(request);
                return View(responseVM.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }          
        }

        [HttpPost]
        public ActionResult Manage(LeadUpdateVM inVm)
        {
            try
            {
                var updateBusiness = ProcessOneBussinesFactory.NewLeadUpdateBusiness();
                var request = new Request<LeadUpdateVM>();
                request.Data = inVm;
                updateBusiness.Process(request);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }           
        }


        public ActionResult GetVehicleDetails(int id)
        {
            try
            {
                var request = new Request<VehicleVM>();
                request.Data.VehID = id;
                var business = ProcessOneBussinesFactory.NewRead1VehicleOnIdBusiness();
                var response = business.Process(request);
                return Json(response.Data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }
        }

        public ActionResult GetContactHistory(int id)
        {
            var business = ReadManyBussinessFactory.NewReadContHistOnIdBusiness();
            var response = business.ReadManyOnID(id);
            return Json(response.Data, JsonRequestBehavior.AllowGet);
        }
    }
}