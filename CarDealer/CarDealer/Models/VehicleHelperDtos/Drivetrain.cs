using System.Collections.Generic;
using System.Web.Mvc;

namespace Models
{
    public class Drivetrain
    {
        public int DrivetrainID { get; set; }
        public string DrivetrainType { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public Drivetrain()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelListOfDrivetrain(List<Drivetrain> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.DrivetrainType,
                        Value = e.DrivetrainID.ToString()
                    }

                    );
            }
        }
    }
}