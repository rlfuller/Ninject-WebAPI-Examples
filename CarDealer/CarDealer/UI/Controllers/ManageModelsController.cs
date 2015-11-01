using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace UI.Controllers
{
    public class ManageModelsController : Controller
    {
        private IViewModelPrimeable<ModelVM> _modelBusiness;

        // GET: CreateModel
        public ActionResult Index()
        {
            try
            {
                _modelBusiness = IViewModelPrimeableFactory.NewIndexVmPrimer();
                var emptyRequest = new Request<ModelVM>();
                var response = _modelBusiness.PrimeViewModel(emptyRequest);
                return View(response.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }
        }

        //[HttpPost]
        public ActionResult DisplayModelsForMake(int makeID)
        {
            try
            {
                _modelBusiness = IViewModelPrimeableFactory.NewDisplayModlesVmPrimer();
                var requestWithID = new Request<ModelVM>();
                requestWithID.Data.MakeID = makeID;
                var response = _modelBusiness.PrimeViewModel(requestWithID);
                return View("DisplayModelsForMake", response.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }           
        }

        public ActionResult CreateModel()
        {
            try
            {
                _modelBusiness = IViewModelPrimeableFactory.NewCreateModelVmPrimer();
                var response = _modelBusiness.PrimeViewModel(new Request<ModelVM>());
                return View(response.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }            
        }


        [HttpPost]
        public ActionResult CreateModel(ModelVM inDto)
        {
            try
            {
                var request = new Request<ModelVM>();
                request.Data = inDto;
                var insertBusiness = ProcessOneBussinesFactory.NewInsertModelBusiness();
                insertBusiness.Process(request);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }            
        }
              
        public ActionResult EditModel(int id)
        {
            try
            {
                var request = new Request<ModelVM>();
                request.Data.ModelID = id;
                var primeBusiness = IViewModelPrimeableFactory.NewEditModelVMPrimer();
                var response = primeBusiness.PrimeViewModel(request);
                return View(response.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }           
        }

        [HttpPost]
        public ActionResult EditModel(ModelVM inModel)
        {
            try
            {
                var request = new Request<ModelVM>();
                var editBusiness = ProcessOneBussinesFactory.NewUpdateModelBusiness();
                request.Data = inModel;
                editBusiness.Process(request);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }            
        }

        public ActionResult NoQuiere(ExMessageVM inExVm)
        {
            return View("NoQuiere", inExVm);
        }
    }
}