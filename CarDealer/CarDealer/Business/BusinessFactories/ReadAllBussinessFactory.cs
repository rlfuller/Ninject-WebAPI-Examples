using System.Collections.Generic;
using System.Configuration;
using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public static class ReadAllBussinessFactory
    {

        private static string repoMode = ConfigurationManager.AppSettings["repomode"];

        private static string _loadAllChassisSproc = "LoadAllChassis";
        private static string _loadAllDrivetrinSproc = "LoadAllDrivetrain";
        private static string _loadAllMakeSproc = "LoadAllMake";
        private static string _loadAllVehicle = "LoadAllVehicle";
        private static string _loadAllModelForDisplay = "LoadAllModelForDisplay";
        private static string _loadAllInventory = "LoadAllInventory";
        private static string _loadAdvertisedInventory = "LoadAdvertisedInventory";
        private static string _purchTimeFrame = "LoadPurchaseTimeframe";
        private static string _bestTime2Call = "LoadBestTimeToCall";
        private static string _how2Contact = "LoadHowToContact";
        private static string _loadLeadSummary = "LoadLeadSummary";
        private static string _loadAllSrS = "LoadAllSrS";


        public static ReadAllSrSBusiness NewReadAllSrSBusiness()
        {
            return new ReadAllSrSBusiness(new ReadAllSrSRepo(ConnStringGetter.GetConnString, _loadAllSrS), new Response<List<SalesRequestStatus>>());
        }

        public static ReadLeadSummaryBusiness NewReadLeadSummaryBusiness()
        {
            return new ReadLeadSummaryBusiness(new ReadLeadSummaryRepo(ConnStringGetter.GetConnString, _loadLeadSummary),new Response<List<LeadSummaryVM>>());
        }

        public static ReadAllBestTimeToCall NewBestTime2CallBusiness()
        {
            return new ReadAllBestTimeToCall(new ReadBestTime2CallRepo(ConnStringGetter.GetConnString, _bestTime2Call),new Response<List<BestTimeToCall>>());
        }

        public static ReadAllHow2Contact NewHowToContactBusiness()
        {
            return new ReadAllHow2Contact(new ReadAllHow2ContactRepo(ConnStringGetter.GetConnString, _how2Contact),new Response<List<HowToContact>>());
        }

        public static ReadAllTimeframeToPurchase NewTimeframeToPurchaseBusiness()
        {
            return new ReadAllTimeframeToPurchase(new ReadAllTimeframe2PurchRepo(ConnStringGetter.GetConnString, _purchTimeFrame),new Response<List<TimeFrameToPurchase>>());
        }

        public static ReadAllVehicleOnSprocBusiness NewLoadAdvertisedInvBusiness()
        {
            return new ReadAllVehicleOnSprocBusiness(new ReadAllVehicleOnSprocRepo(ConnStringGetter.GetConnString, _loadAdvertisedInventory), new Response<List<VehicleVM>>());
        }

        public static ReadAllVehicleOnSprocBusiness NewLoadAllInventoryBusiness()
        {
            return new ReadAllVehicleOnSprocBusiness(new ReadAllVehicleOnSprocRepo(ConnStringGetter.GetConnString, _loadAllInventory),new Response<List<VehicleVM>>());
        }

        public static ReadAllChassisBusiness NewReadAllChassisBusiness()
        {
            return new ReadAllChassisBusiness(new ReadAllChassisRepo(ConnStringGetter.GetConnString, _loadAllChassisSproc), new Response<List<Chassis>>());
        }

        public static ReadAllDrivetrainBusiness NewReadAllDrivetrainBusiness()
        {
            return new ReadAllDrivetrainBusiness(new ReadAllDrivetrainRepo(ConnStringGetter.GetConnString, _loadAllDrivetrinSproc), new Response<List<Drivetrain>>());
        }

        public static ReadAllMakeBusiness NewReadAllMakeBusiness()
        {
            return new ReadAllMakeBusiness(new ReadAllMakeRepo(ConnStringGetter.GetConnString, _loadAllMakeSproc), new Response<List<Make>>());
        }

        public static ReadAllVehicleForCustomerBusiness NewReadAllVehicleBusiness()
        {
            return new ReadAllVehicleForCustomerBusiness(new ReadAllVehicleForCustomerRepo(ConnStringGetter.GetConnString, _loadAllVehicle), new Response<List<VehicleVM>>());
        }

        public static ReadAllModelBusiness NewReadAllModelBusiness()
        {
            return new ReadAllModelBusiness(new ReadAllModelRepo(ConnStringGetter.GetConnString, _loadAllModelForDisplay),new Response<List<ModelVM>>());
        }
    }
}