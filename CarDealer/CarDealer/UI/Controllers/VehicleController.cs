using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using Business;
using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace UI.Controllers
{
    public class VehicleController : ApiController
    {
        [HttpGet]
        public List<Make> Makes()
        {
            var business = IViewModelPrimeableFactory.NewManageInvAddVehPrimer();
            var respVehicleVm = business.PrimeViewModel(new Request<VehicleVM>());
            return respVehicleVm.Data.ListOfMake;
        }

        [HttpGet]
        public List<ModelVM> Models(int id)
        {
            var readModelsOnMakeID = ReadManyBussinessFactory.NewReadModelOnMakeIDBusiness();
            var responseListModel = readModelsOnMakeID.ReadManyOnID(id);
            return responseListModel.Data;
        }

        [HttpPost]
        public VehicleVM Add(VehicleVM model)
        {
            var request = new Request<VehicleVM>();
            request.Data = model;
            var repo = new InsertVehicleRepo(ConnStringGetter.GetConnString);
            var response = repo.Process(request);
            model.VehID = response.Data.VehID;
            return model;

        }

        // edit vehicle methods...
        [HttpGet]
        public VehicleVM Edit(int id)
        {
            var request = new Request<VehicleVM>();
            request.Data.VehID = id;
            var business = ProcessOneBussinesFactory.NewRead1VehicleOnIdBusiness();
            var response = business.Process(request);

            return response.Data;
        }



        [HttpPost]
        public VehicleVM Edit(VehicleVM model)
        {
            var request = new Request<VehicleVM>();
            request.Data = model;
            var business = ProcessOneBussinesFactory.NewUpdateVehicleBusiness();
            var response = business.Process(request);

            return new VehicleVM() { AdHeader = "you're supposed to get this" };
        }

    }
}