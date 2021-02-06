using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.Identity.IsAuthenticated is true)
            {
                name.InnerText = $"Greetings, {Context.User.Identity.Name}";
            }

            else
            {
                name.InnerText = "";
            }
        }
    }
}