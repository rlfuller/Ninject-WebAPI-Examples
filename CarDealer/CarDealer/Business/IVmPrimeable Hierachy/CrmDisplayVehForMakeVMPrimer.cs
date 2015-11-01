using System.Linq;
using Models;

namespace Business
{
    public class CrmDisplayVehForMakeVMPrimer:IViewModelPrimeable<VehicleVM>
    {
        public Response<VehicleVM> PrimeViewModel(Request<VehicleVM> inRequest)
        {
         
            var result = new Response<VehicleVM>();
            var vehiclBusiness = ReadManyBussinessFactory.NewReadVehicleOnMakeIDBusiness();
            result.Data.ListOfVehicle = vehiclBusiness.ReadManyOnID(inRequest.Data.MakeID).Data;

            var makeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            result.Data.MakeDto.GetSelListOfMake(makeBusiness.ReadAll().Data);

            if(result.Data.ListOfVehicle.Count == 0 || result.Data.MakeDto.SelectList.Count == 0)
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