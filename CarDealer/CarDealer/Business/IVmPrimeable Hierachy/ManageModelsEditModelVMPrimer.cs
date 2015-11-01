using System.Linq;
using System.Runtime.InteropServices;
using Models;

namespace Business
{
    public class ManageModelsEditModelVMPrimer : IViewModelPrimeable<ModelVM>
    {
        public Response<ModelVM> PrimeViewModel(Request<ModelVM> inRequest)
        {
            var result = new Response<ModelVM>();
            

            var readModelBusiness = ProcessOneBussinesFactory.NewReadOneModelOnIdBusiness();
            result = readModelBusiness.Process(inRequest);

            var makeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            var respOfListMake = makeBusiness.ReadAll();
            result.Data.MakeDto.GetSelListOfMake(respOfListMake.Data);

            var readDrivetrainBusiness = ReadAllBussinessFactory.NewReadAllDrivetrainBusiness();
            var respDrivetrainList = readDrivetrainBusiness.ReadAll();
            result.Data.DrivetrainDto.GetSelListOfDrivetrain(respDrivetrainList.Data);

            var readChassisBusiness = ReadAllBussinessFactory.NewReadAllChassisBusiness();
            var respChassisList = readChassisBusiness.ReadAll();
            result.Data.ChassisDto.GetSelListOfChassis(respChassisList.Data);

            if (result.Data.ModelID == 0 || result.Data.MakeDto.SelectList.Count == 0 ||
                result.Data.DrivetrainDto.SelectList.Count == 0 || result.Data.ChassisDto.SelectList.Count == 0)
            {
                result.Success = false;
                result.Message = "No Data! Something went wrong";
                result.Data.ResponseMessage = result.Message;
            }

            else
            {
                result.Success = true;
                result.Message = "Data transfer status: OK";
                result.Data.ResponseMessage = result.Message;
            }
            return result;
        }
    }

    public class LeadsManageVMPrimer:IViewModelPrimeable<LeadUpdateVM>
    {
        public Response<LeadUpdateVM> PrimeViewModel(Request<LeadUpdateVM> inRequest)
        {
            var result = new Response<LeadUpdateVM>();

            var leadReader = ProcessOneBussinesFactory.NewReadLeadOnIDBusiness();
            
            // got individual lead here
            result = leadReader.Process(inRequest);
            var srsReader = ReadAllBussinessFactory.NewReadAllSrSBusiness();
            
            // got select list for dropdown here
            result.Data.SrSDto.GetSelList(srsReader.ReadAll().Data);

            var vehReader = ProcessOneBussinesFactory.NewRead1VehicleOnIdBusiness();
            var vehReq = new Request<VehicleVM>();
            vehReq.Data.VehID = inRequest.Data.VehID;
            var respOfVeh = vehReader.Process(vehReq);
            // got vehicle here
            result.Data.VehicleDto = respOfVeh.Data;

            return result;
        }
    }
}