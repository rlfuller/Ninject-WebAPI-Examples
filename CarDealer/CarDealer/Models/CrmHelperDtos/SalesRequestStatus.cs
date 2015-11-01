using System.Collections.Generic;
using System.Web.Mvc;

namespace Models
{
    public class SalesRequestStatus
    {
        public int SrsID { get; set; }
        public string SrSType { get; set;}

        public List<SelectListItem> SelectList { get; set; }


        public SalesRequestStatus()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelList(List<SalesRequestStatus> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.SrSType,
                        Value = e.SrsID.ToString()
                    }

                    );
            }
        }


    }
}