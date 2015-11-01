using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class VehicleVM
    {
        // persist / display
        public int VehID { get; set; }
        public string VinNo { get; set; }
        public int? ModelYear { get; set; }
        public bool? IsNew { get; set; }
        public string ImageUrl { get; set; }
        public int? Mileage { get; set; }
        public decimal? SellingPrice { get; set; }
        public int ModelID { get; set; }
        public bool? IsAvailable { get; set; }
        // display
        public int MakeID { get; set; }
        public string MakeName { get; set; }
        public string ModelName { get; set; }
        public string Trim { get; set; }
        public string ChassisType { get; set; }
        public string DrivetrainType { get; set; }
        public string AdHeader { get; set; }
        public string AdBody { get; set; }
        public int? ChassisID { get; set; }
        public int? DrivetrainID { get; set; }
        public DateTime InsertDate { get; set; }
        public bool IsDeleted { get; set; }
        public int? AdID { get; set; }
        // other dtos
        public Make MakeDto { get; set; }
        public List<VehicleVM> ListOfVehicle { get; set; }
        public List<Make> ListOfMake { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public string IsAvailSmartProp
        {
            get
            {
                if (IsAvailable == true) return "Yes";
                return IsAvailable == false ? "No" : "Unknown";
            }
        }

        public VehicleVM()
        {
            //VehID = 15;
            //VinNo = "124Blablalalb";
            //ModelYear = 1998;
            //IsNew = false;
            //ImageUrl = "testurlEdit";
            //Mileage = 99999;
            //SellingPrice = 999.95M;
            //IsDeleted = false;
            //ModelID = 22;
            //IsAvailable = false;

            MakeDto = new Make();
            SelectList = new List<SelectListItem>();
        }

        public void GetSelListOfVehicle(List<VehicleVM> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.MakeName,
                        Value = e.MakeID.ToString()
                    }

                    );
            }
        }
    }
}
