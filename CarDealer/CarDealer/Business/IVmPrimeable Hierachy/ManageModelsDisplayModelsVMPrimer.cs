using System;
using Models;

namespace Business
{
    public class ManageModelsDisplayModelsVMPrimer:IViewModelPrimeable<ModelVM>
    {
        public Response<ModelVM> PrimeViewModel(Request<ModelVM> inRequest)
        {
            var readBusiness = ReadManyBussinessFactory.NewReadModelOnMakeIDBusiness();
            var result = new Response<ModelVM>();

            var respListModel = readBusiness.ReadManyOnID(inRequest.Data.MakeID);
            result.Data.ListOfModel = respListModel.Data;

            var readMakeBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            var respListOfMakes = readMakeBusiness.ReadAll();
            result.Data.MakeDto.GetSelListOfMake(respListOfMakes.Data);

            if (respListModel.Data.Count == 0 || respListOfMakes.Data.Count == 0)
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