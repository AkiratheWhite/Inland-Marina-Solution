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

            List<Slip> availSlip = SlipManager.FindAvailableSlip();
            uxAvailableSlips.DataSource = availSlip;
            uxAvailableSlips.DataBind();

        }
    }
}