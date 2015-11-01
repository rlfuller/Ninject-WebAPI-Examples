using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Models;

namespace UI.Controllers
{
    public class ManageInventoryController : Controller
    {
        // GET: ManageInventory
        public ActionResult Index()
        {
            try
            {
                var business = ReadAllBussinessFactory.NewLoadAllInventoryBusiness();
                var responseModel = business.ReadAll();
                return View(responseModel);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ProcessError", "Crm", ex.Message);
            }
            
        }



        //var business = IViewModelPrimeableFactory.NewManageInvAddVehPrimer();
        //var respVehicleVm = business.PrimeViewModel(new Request<VehicleVM>());

        //response.Data.MakeDto.SelectList
        //return View(respVehicleVm.Data);

        //// for your poster view that will retrieve all models by make id
        //int id = 0; this will be your make id
        //var readModelsOnMakeID = ReadManyBussinessFactory.NewReadModelOnMakeIDBusiness();
        //var responseListModel = readModelsOnMakeID.ReadManyOnID(id);

        // for persistence look at Vehicle sql table, 
        // please provide all fields except InsertDate and AdId and IsDeleted

        [HttpPost]
        public JsonResult Add(VehicleVM model)
        {
            return Json(new { message = "duck" });

        }

        public ActionResult Edit()
        {
            // under construction
            return RedirectToAction("NoQuiere", "ManageModels");
        }
    }
}