using System.Linq;
using Models;

namespace Business
{
    public class CrmIndexVMPrimer:IViewModelPrimeable<VehicleVM>
    {
        public Response<VehicleVM> PrimeViewModel(Request<VehicleVM> inRequest)
        {
            var result = new Response<VehicleVM>();
            var modelBusiness = ReadAllBussinessFactory.NewReadAllVehicleBusiness();
            result.Data.ListOfVehicle = modelBusiness.ReadAll().Data;

            var makeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            result.Data.MakeDto.GetSelListOfMake(makeBusiness.ReadAll().Data);

            if (result.Data.SelectList.Count == 0 || result.Data.MakeDto.SelectList.Count == 0)
            {
                result.Success = false;
                result.Message = "No Data! Something went wrong";                
            }

            else
            {
                result.Success = true;
                result.Message = "Data transfer status: OK";                
            }
            return result;
        }
    }
}