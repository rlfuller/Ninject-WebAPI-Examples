using System.Configuration;
using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public static class ProcessOneBussinesFactory
    {
        private static string repoMode = ConfigurationManager.AppSettings["repomode"];
        private static ProcessOneBusiness<ModelVM> _modelBusiness;
        private static ProcessOneBusiness<VehicleVM> _vehicleBusiness;
        private static ProcessOneBusiness<InqueryVM> _inqueryBusiness;
        private static ProcessOneBusiness<LeadUpdateVM> _LeadUpdateBusiness;

        public static ProcessOneBusiness<VehicleVM> NewUpdateVehicleBusiness()
        {
            _vehicleBusiness = new UpdateVehicleBusiness(new UpdateVehicleRepo(ConnStringGetter.GetConnString),new Response<VehicleVM>() );
            return _vehicleBusiness;
        }

        public static ProcessOneBusiness<LeadUpdateVM> NewLeadUpdateBusiness()
        {
            return new LeadUpdateBusiness();
        }

        public static ProcessOneBusiness<LeadUpdateVM> NewReadLeadOnIDBusiness()
        {
            _LeadUpdateBusiness = new ReadLeadOnIDBusiness(new ReadLeadOnIDRepo(ConnStringGetter.GetConnString), new Response<LeadUpdateVM>());
            return _LeadUpdateBusiness;
        }


        public static ProcessOneBusiness<InqueryVM> NewCreateInquerybusiness()
        {
            _inqueryBusiness = new CreateInqueryBusiness();
            return _inqueryBusiness;
        }

        public static ProcessOneBusiness<VehicleVM> NewRead1VehicleOnIdBusiness()
        {
            _vehicleBusiness = new Read1VehicleOnIDBusiness(new Read1VehicleOnIDRepo(ConnStringGetter.GetConnString),new Response<VehicleVM>());
            return _vehicleBusiness;
        }

        public static ProcessOneBusiness<ModelVM> NewInsertModelBusiness()
        {
            _modelBusiness = new InsertModelBusiness(new InsertModelRepo(ConnStringGetter.GetConnString), new Response<ModelVM>());
            return _modelBusiness;
        }

        public static ProcessOneBusiness<ModelVM> NewReadOneModelOnIdBusiness()
        {
            _modelBusiness = new ReadOneModelOnIDBusiness(new ReadModelByIDRepo(ConnStringGetter.GetConnString),new Response<ModelVM>() );
            return _modelBusiness;
        }

        public static ProcessOneBusiness<ModelVM> NewUpdateModelBusiness()
        {
            _modelBusiness = new UpdateModelBusiness(new UpdateModelRepo(ConnStringGetter.GetConnString),new Response<ModelVM>());
            return _modelBusiness;
        }
    }
}