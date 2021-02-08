using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.Marina.Data;


namespace CPRG214.Marina.App
{
    public partial class AvailableSlips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            var db = new MarinaEntities();
            var allSlips = db.Slips.ToList();
            var leaseSlips = db.Leases.ToList();
            List<Slip> availSlips = new List<Slip>();
            //checks only for available slips

            foreach (var lease in leaseSlips)
            {
                foreach (var slip in allSlips)
                {
                    if (slip.ID != lease.SlipID)
                    {
                        availSlips.Add(slip);
                        uxAvailableSlips.DataSource = availSlips;
                        uxAvailableSlips.DataBind();
                    }
                }
            }

            
                


            

        }
    }
}