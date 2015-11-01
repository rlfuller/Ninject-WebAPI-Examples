using System.Collections.Generic;

namespace Models
{
    public class ModelVM
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public int MakeID { get; set; }
        public int ChassisID { get; set; }
        public int DrivetrainID { get; set; }
        public string Trim { get; set; }

        public Make MakeDto { get; set; }
        public Drivetrain DrivetrainDto { get; set; }
        public Chassis ChassisDto { get; set; }

        public string MakeName { get; set; }
        public string ChassisType { get; set; }
        public string DrivetrainType { get; set;}

        public List<ModelVM> ListOfModel { get; set; }

        public string ResponseMessage { get; set; }


        public ModelVM()
        {
            MakeDto = new Make();
            DrivetrainDto = new Drivetrain();
            ChassisDto = new Chassis();

            //testing

            //ModelName = "Test";
            //MakeID = 8;
            //ChassisID = 2;
            //DrivetrainID = 2;
            //Trim = "Test trim";
        }


    }
}