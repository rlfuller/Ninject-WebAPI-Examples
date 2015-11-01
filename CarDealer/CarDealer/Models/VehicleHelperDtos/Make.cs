using System.Collections.Generic;
using System.Web.Mvc;

namespace Models
{
    public class Make
    {
        public int MakeID { get; set; }
        public string MakeName { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public Make()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelListOfMake(List<Make> inList)
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