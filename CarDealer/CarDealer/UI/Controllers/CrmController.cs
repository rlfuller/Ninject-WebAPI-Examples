using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Models;

namespace UI.Controllers
{
    public class CrmController : Controller
    {
        // GET: complete list of inventory for which and add exists
        public ActionResult Index()
        {
            try
            {
                //var crmBusiness = IViewModelPrimeableFactory.NewCrmIndexVMPrimer();
                var crmBusiness = ReadAllBussinessFactory.NewLoadAdvertisedInvBusiness();
                var responseVM = crmBusiness.ReadAll();
                return View(responseVM);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }           
        }

        // single vehicle details from advertised list
        public ActionResult Details(int id)
        {
            try
            {
                var request = new Request<VehicleVM>();
                request.Data.VehID = id;
                var business = ProcessOneBussinesFactory.NewRead1VehicleOnIdBusiness();
                var response = business.Process(request);
                return View(response.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }           
        }

        public ActionResult GetDetails(int id)
        {
            try
            {
                var request = new Request<VehicleVM>();
                request.Data.VehID = id;
                var business = ProcessOneBussinesFactory.NewRead1VehicleOnIdBusiness();
                var response = business.Process(request);
                return Json(response.Data,JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }
        }

        public ActionResult Inquire(int id)
        {
            try
            {
                var request = new Request<InqueryVM>();
                request.Data.VehID = id;
                var areaBusiness = IViewModelPrimeableFactory.NewCrmInqueryVMPrimer();
                var response = areaBusiness.PrimeViewModel(request);

                return View(response.Data);

            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Inquire(InqueryVM inDto)
        {
            try
            {
                var request = new Request<InqueryVM>();
                request.Data = inDto;
                var inqueryBusiness = ProcessOneBussinesFactory.NewCreateInquerybusiness();
                var responseVM = inqueryBusiness.Process(request);
                return View("ThankYou", responseVM.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError","Crm",ex.Message);
            }            
        }
      
        // can use this to sort advertised inventory by make
        public ActionResult DisplayVehiclesForMake(int makeID)
        {
            try
            {
                var crmBusiness = IViewModelPrimeableFactory.NewCrmDisplayVehicleForMakeVMPrimer();
                var request = new Request<VehicleVM>();
                request.Data.MakeID = makeID;
                var responseVM = crmBusiness.PrimeViewModel(request);
                return View("DisplayVehiclesForMake", responseVM.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }            
        }

        public ActionResult ProcessError(string inExMessage)
        {
            var exMessgVm = new ExMessageVM();
            exMessgVm.ExMessage = inExMessage;
            return RedirectToAction("NoQuiere", "ManageModels", exMessgVm);
        }
    }
}