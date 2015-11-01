using Models;

namespace Business
{
    public class ManageInvAddVehVMPrimer : IViewModelPrimeable<VehicleVM>
    {
        public Response<VehicleVM> PrimeViewModel(Request<VehicleVM> inRequest)
        {
            Response<VehicleVM> result = new Response<VehicleVM>();
       
            var makeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            var respOfListMake = makeBusiness.ReadAll();
            result.Data.MakeDto.GetSelListOfMake(respOfListMake.Data);
            result.Data.ListOfMake = respOfListMake.Data;

            if (respOfListMake.Data.Count == 0 || respOfListMake.Data.Count == 0)
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