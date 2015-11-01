using Models;

namespace Business
{
    public static class IViewModelPrimeableFactory
    {

        private static IViewModelPrimeable<ModelVM> _modelVmPrimer;
        private static IViewModelPrimeable<VehicleVM> _vehiclePrimer;
        private static IViewModelPrimeable<InqueryVM> _inqueryPrimer;
        private static IViewModelPrimeable<LeadUpdateVM> _leadUpdatePrimer;


        public static IViewModelPrimeable<VehicleVM> NewManageInvAddVehPrimer()
        {
            _vehiclePrimer = new ManageInvAddVehVMPrimer();
            return _vehiclePrimer;
        }


        public static IViewModelPrimeable<LeadUpdateVM> NewLeadUpdatePrimer()
        {
            _leadUpdatePrimer = new LeadsManageVMPrimer();
            return _leadUpdatePrimer;
        }

        // ManageModelController view primer objects
        public static IViewModelPrimeable<ModelVM> NewIndexVmPrimer()
        {
            _modelVmPrimer = new ManageModelsIndexVMPrimer();
            return _modelVmPrimer;
        }

        public static IViewModelPrimeable<ModelVM> NewDisplayModlesVmPrimer()
        {
            _modelVmPrimer = new ManageModelsDisplayModelsVMPrimer();
            return _modelVmPrimer;
        }

        public static IViewModelPrimeable<ModelVM> NewCreateModelVmPrimer()
        {
            _modelVmPrimer = new ManageModelsCreateModelVMPrimer();
            return _modelVmPrimer;
        }

        public static IViewModelPrimeable<ModelVM> NewEditModelVMPrimer()
        {
            _modelVmPrimer = new ManageModelsEditModelVMPrimer();
            return _modelVmPrimer;
        }

        // CrmController view primer objects
        public static IViewModelPrimeable<VehicleVM> NewCrmIndexVMPrimer()
        {
            _vehiclePrimer = new CrmIndexVMPrimer();
            return _vehiclePrimer;
        }

        public static IViewModelPrimeable<VehicleVM> NewCrmDisplayVehicleForMakeVMPrimer()
        {
            _vehiclePrimer = new CrmDisplayVehForMakeVMPrimer();
            return _vehiclePrimer;
        }

        public static IViewModelPrimeable<InqueryVM> NewCrmInqueryVMPrimer()
        {
            _inqueryPrimer = new CrmInqueryVMprimer();
            return _inqueryPrimer;
        }

    }
}