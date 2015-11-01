using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Models
{
    public class BestTimeToCall
    {

        public int BestTimeToCallID { get; set; }

        public string BestTime { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public BestTimeToCall()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelectList(List<BestTimeToCall> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.BestTime,
                        Value = e.BestTimeToCallID.ToString()
                    }

                    );
            }
        }
    }
}