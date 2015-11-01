using System.Collections.Generic;
using System.Web.Mvc;

namespace Models
{
    public class Chassis
    {
        public int ChassisID { get; set; }
        public string ChassisType { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public Chassis()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelListOfChassis(List<Chassis> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.ChassisType,
                        Value = e.ChassisID.ToString()
                    }

                    );
            }
        }
    }
}