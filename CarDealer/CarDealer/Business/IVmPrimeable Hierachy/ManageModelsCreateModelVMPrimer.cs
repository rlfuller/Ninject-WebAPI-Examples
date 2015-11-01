using Models;

namespace Business
{
    public class ManageModelsCreateModelVMPrimer:IViewModelPrimeable<ModelVM>
    {
        public Response<ModelVM> PrimeViewModel(Request<ModelVM> inRequest)
        {
            var result = new Response<ModelVM>();

            var readMakeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            var respmakeList = readMakeBusiness.ReadAll();
            result.Data.MakeDto.GetSelListOfMake(respmakeList.Data);

            var readDrivetrainBusiness = ReadAllBussinessFactory.NewReadAllDrivetrainBusiness();
            var respDrivetrainList = readDrivetrainBusiness.ReadAll();
            result.Data.DrivetrainDto.GetSelListOfDrivetrain(respDrivetrainList.Data);

            var readChassisBusiness = ReadAllBussinessFactory.NewReadAllChassisBusiness();
            var respChassisList = readChassisBusiness.ReadAll();
            result.Data.ChassisDto.GetSelListOfChassis(respChassisList.Data);

            if (respmakeList.Data.Count == 0 || respChassisList.Data.Count == 0 || respDrivetrainList.Data.Count == 0)
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
}