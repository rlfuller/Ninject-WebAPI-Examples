using System.Collections.Generic;
using System.Configuration;
using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public static class ReadManyBussinessFactory
    {

        private static string repoMode = ConfigurationManager.AppSettings["repomode"];

        private static ReadManyOnIDBusiness<ModelVM> _readManyModelBusiness;
        private static ReadVehicleOnMakeIDBusiness _readManyVehicleBusiness;
        private static ReadManyOnIDBusiness<ContactHistVM> _contHistBusiness; 


        // model on make id 
        private static string _loadModelOnIDSproc = "dbo.LoadModelOnMakeID";
        private static string _loadModelOnIDParam = "@MakeID";
        // vehicle on make id
        private static string _loadVehicleOnIDSproc = "dbo.LoadVehicleByMake";
        private static string _loadVehicleOnIDParam = "@mkID";

        private static string _loadContHistOnIDSproc = "dbo.ContactHistOnID";
        private static string _contHistOnIDParam = "@lID";


        public static ReadManyOnIDBusiness<ContactHistVM> NewReadContHistOnIdBusiness()
        {
            _contHistBusiness = new ReadContHistOnIDBusiness(new ReadContactHistOnIDRepo(ConnStringGetter.GetConnString, _loadContHistOnIDSproc, _contHistOnIDParam),new Response<List<ContactHistVM>>());
            return _contHistBusiness;
        }

        public static ReadManyOnIDBusiness<ModelVM> NewReadModelOnMakeIDBusiness()
        {
            _readManyModelBusiness = new ReadModelOnMakeIDBusiness(new ReadModelOnMakeIDRepo(ConnStringGetter.GetConnString, _loadModelOnIDSproc, _loadModelOnIDParam),new Response<List<ModelVM>>());
            return _readManyModelBusiness;
        }

        public static ReadManyOnIDBusiness<VehicleVM> NewReadVehicleOnMakeIDBusiness()
        {
            _readManyVehicleBusiness = new ReadVehicleOnMakeIDBusiness(new ReadVehicleOnMakeIDRepo(ConnStringGetter.GetConnString, _loadVehicleOnIDSproc, _loadVehicleOnIDParam),new Response<List<VehicleVM>>());
            return _readManyVehicleBusiness;
        }


    }
}