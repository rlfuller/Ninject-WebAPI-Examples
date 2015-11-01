using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Business;
using DataAccess;
using DataAccess.DapperReaders;
using Models;
using NUnit.Framework;

namespace Tests
{

    // PLEASE NOTE:
    // remember - to run tests - need to know the answers (look in db) AND
    // need to prime DTO's with test data if neccessary...
    // when priming DTO's with data - must adhere to FK data
    // constraints eg. cannot Ad chassis ID 59 in the FK model table 
    // where such an id does not exist in the PK chassis table
    // if running writer tests, make sure to tear down!!!

    [TestFixture]
    public class DataAccessObjectsTesting
    {

        // must check count in DB before running!!!
        [Test]
        public void ReadAllChassisSuccessful()
        {
            var chassisBusiness = ReadAllBussinessFactory.NewReadAllChassisBusiness();
            var response = chassisBusiness.ReadAll();
            Assert.IsTrue(response.Success);
            Assert.AreEqual(response.Data.Count, 5);
        }

        [Test]
        public void ReadAllDrivetrainSuccessful()
        {
            var areaBusiness = ReadAllBussinessFactory.NewReadAllDrivetrainBusiness();
            var response = areaBusiness.ReadAll();
            Assert.IsTrue(response.Success);
            Assert.AreEqual(response.Data.Count, 5);
        }

        [Test]
        public void ReadAllMakeSuccessful()
        {
            var areaBusiness = ReadAllBussinessFactory.NewReadAllMakeBusiness();
            var response = areaBusiness.ReadAll();
            Assert.IsTrue(response.Success);
            Assert.AreEqual(response.Data.Count, 7);
        }

        [Test]
        public void ReadLeadOnIdSuccessful()
        {
            var areaBusiness = ProcessOneBussinesFactory.NewReadLeadOnIDBusiness();
            var request = new Request<LeadUpdateVM>();
            request.Data.LeadID = 3;
            var response = areaBusiness.Process(request);
            Assert.IsTrue(response.Success);
            Assert.AreEqual("john smithedit", response.Data.LeadName);
        }

        [Test]
        public void ManageInvAddVehVMPrimerSuccess()
        {
            var areaBusiness = new ManageInvAddVehVMPrimer();
            var request = new Request<VehicleVM>();
            var response = areaBusiness.PrimeViewModel(request);
            Assert.IsTrue(response.Success);
            //Assert.AreEqual(8,response.Data.MakeDto.SelectList.Count());
        }
        [Test]
        public void InsertVehicleSuccess()
        {
            var repo = new InsertVehicleRepo(ConnStringGetter.GetConnString);
            var request = new Request<VehicleVM>();
            var dto = new VehicleVM();
            request.Data = dto;
            var response = repo.Process(request);
            //Assert.IsTrue(response.Success);
            Assert.AreEqual(15, response.Data.VehID);
        }

        [Test]
        public void UpdateVehicleSuccess()
        {
            var repo = new UpdateVehicleRepo(ConnStringGetter.GetConnString);
            var request = new Request<VehicleVM>();
            var dto = new VehicleVM();
            request.Data = dto;
            var response = repo.Process(request);
            Assert.IsTrue(response.Success = false);
        }

        [Test]
        public void ContactHistOnIDSuccess()
        {
            var business = ReadManyBussinessFactory.NewReadContHistOnIdBusiness();
            var respListOfContHist = business.ReadManyOnID(3);
            Assert.AreEqual(4, respListOfContHist.Data.Count);
        }





        /// <summary>
        /// objects tested below have been decomissioned / refactored
        /// </summary>


        //    [Test]
        //    public void ReadAllVehicleSuccessful()
        //    {
        //        var areaBusiness = BussFactory.NewReadAllVehicleBusiness();
        //        var response = areaBusiness.ReadAll();
        //        Assert.IsTrue(response.Success);
        //        Assert.AreEqual(response.Data.Count, 2);
        //    }

        //    [Test]
        //    public void ReadAllModelSuccessful()
        //    {
        //        var areaBusiness = BussFactory.NewReadAllRawModelsBusiness();
        //        var response = areaBusiness.ReadAll();
        //        Assert.IsTrue(response.Success);
        //        Assert.AreEqual(response.Data.Count, 2);
        //    }

        //    [Test]
        //    public void ReadAllModelByBrandSuccessful()
        //    {
        //        var areaBusiness = BussFactory.NewReadAllModelBusiness();
        //        var response = areaBusiness.ReadAll();
        //        Assert.IsTrue(response.Success);
        //        Assert.AreEqual(response.Data.Count, 2);
        //    }


        //    [Test]
        //    public void InsertModelAndOutNewIDSuccessful()
        //    {
        //        var dto = new ModelVM();
        //        var request = new Request<ModelVM>();
        //        request.Data = dto;
        //        var areaBusiness = BussFactory.NewInsertModelBusiness();
        //        var response = areaBusiness.Process(request);
        //        Assert.IsTrue(response.Success);
        //        Assert.AreEqual(response.Data.ModelID, 5);
        //    }

        //    [Test]
        //    public void ReadModelByMakeSuccessful()
        //    {
        //        var dto = new ModelVM();
        //        var request = new Request<ModelVM>();
        //        request.Data = dto;
        //        var areaBusiness = BussFactory.NewReadModelForOneMakeBusiness();
        //        var response = areaBusiness.ReadMany(request);
        //        Assert.IsTrue(response.Success);
        //        Assert.AreEqual(response.Data.Count,2);
        //    }


        //    [Test]
        //    public void ReadModelByIDSucessFul()
        //    {
        //        var dto = new ModelVM();
        //        var request = new Request<ModelVM>();
        //        request.Data.ModelID = 8;
        //        var areaBusiness = BussFactory.NewReadModelByIdBusiness();
        //        var response = areaBusiness.Process(request);
        //        Assert.AreEqual(8,response.Data.ModelID);
        //    }

        //    [Test]
        //    public void ReadAllVehicleSccessful()
        //    {
        //        var areaBusiness = BussFactory.NewReadAllVehicleBusiness();
        //        var responseList = areaBusiness.ReadAll();
        //        var vehicle = responseList.Data.Where(x => x.Mileage >= 21355);
        //        Assert.AreEqual(21355, vehicle.ElementAt(0).Mileage);
        //    }
    }
}
