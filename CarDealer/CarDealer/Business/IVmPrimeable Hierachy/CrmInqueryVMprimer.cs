using Models;

namespace Business
{
    public class CrmInqueryVMprimer:IViewModelPrimeable<InqueryVM>
    {
        public Response<InqueryVM> PrimeViewModel(Request<InqueryVM> inRequest)
        {
            var result = new Response<InqueryVM>();

            // get vehicle
            var vehBusiness = ProcessOneBussinesFactory.NewRead1VehicleOnIdBusiness();
            var requestOfVeh = new Request<VehicleVM>();
            requestOfVeh.Data.VehID = inRequest.Data.VehID;
            var respOfVehicle = vehBusiness.Process(requestOfVeh);
            result.Data.VehicleDto = respOfVehicle.Data;
            // get select lists
            var timeframeBus = ReadAllBussinessFactory.NewTimeframeToPurchaseBusiness();
            var respListOfTimeframe = timeframeBus.ReadAll();
            result.Data.PurchTimeFrameDto.GetSelectList(respListOfTimeframe.Data);

            var how2ContactBus = ReadAllBussinessFactory.NewHowToContactBusiness();
            var respListOfHow2Cont = how2ContactBus.ReadAll();
            result.Data.HowToContactDto.GetSelectList(respListOfHow2Cont.Data);

            var bestTimeBusiness = ReadAllBussinessFactory.NewBestTime2CallBusiness();
            var respListOfbestTime = bestTimeBusiness.ReadAll();
            result.Data.BestTimeToCallDto.GetSelectList(respListOfbestTime.Data);

            return result;

        }
    }
}