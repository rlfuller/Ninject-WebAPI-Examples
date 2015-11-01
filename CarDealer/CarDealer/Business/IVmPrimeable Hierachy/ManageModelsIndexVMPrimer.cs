using Models;

namespace Business
{
    public class ManageModelsIndexVMPrimer:IViewModelPrimeable<ModelVM>
    {
        public Response<ModelVM> PrimeViewModel(Request<ModelVM> inRequest)
        {
            Response<ModelVM> result = new Response<ModelVM>();
            var modelBusiness = ReadAllBussinessFactory.NewReadAllModelBusiness();
            var respOfList = modelBusiness.ReadAll();
            result.Data.ListOfModel = respOfList.Data;

            var makeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            var respOfListMake = makeBusiness.ReadAll();
            result.Data.MakeDto.GetSelListOfMake(respOfListMake.Data);

            if (respOfList.Data.Count == 0 || respOfListMake.Data.Count == 0)
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