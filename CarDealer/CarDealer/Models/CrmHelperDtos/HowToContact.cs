using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Models
{
    public class HowToContact
    {
       
        public int HowToContactID { get; set; }

        
        public string ContactMethod { get; set; }

        public List<SelectListItem> SelectList { get; set; }

        public HowToContact()
        {
            SelectList = new List<SelectListItem>();
        }

        public void GetSelectList(List<HowToContact> inList)
        {
            foreach (var e in inList)
            {
                SelectList.Add(
                    new SelectListItem
                    {
                        Text = e.ContactMethod,
                        Value = e.HowToContactID.ToString()
                    }

                    );
            }
        }
    }
}