using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Models
{
    public class TimeFrameToPurchase
    {
      
        public int PurchTimeframeID { get; set; }


        public string PurchaseTimeframe { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public TimeFrameToPurchase()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelectList(List<TimeFrameToPurchase> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.PurchaseTimeframe,
                        Value = e.PurchTimeframeID.ToString()
                    }

                    );
            }
        }
    }
}