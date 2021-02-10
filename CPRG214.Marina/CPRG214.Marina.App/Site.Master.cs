using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Marina.App
{
    /***
     * Code written by: Tony Li
     * Last Modified (MM/DD/YY): 02/09/21 
     ***/
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If the user is authenticated and signed in, execute the following code.
            if (Context.User.Identity.IsAuthenticated is true)
            {
                //Displays a greeting with the customer's full name.
                name.InnerText = $"Greetings, {Context.User.Identity.Name}";

                //The Secure Lease Slip page becomes visible.
                LeaseSlip.Visible = true;

                //The login button's text is changed to "logout".
                login.InnerText = "Logout";
                
                //The register button is removed when a user is signed in.
                register.Visible = false;
            }

            else
            {
                //No message is displayed if the user is not signed in.
                name.InnerText = "";

                //The Secure Lease Slip page is not visible to non-authenticated users.
                LeaseSlip.Visible = false;

                //The login button's text is set to "login".
                login.InnerText = "Login";

                //The register button is visible to non-registered users.
                register.Visible = true;
            }
        }

        /// <summary>
        /// This method gives functionality to the login button.
        /// If the use is logged in, it logs them out. If they're not logged in, they are redirected to the login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnLoginClick(object sender, EventArgs e)
        {
            //Check if the user is authenticated. If they are authenticated, sign them out, clear session. Redirect to homepage.
            if (Context.User.Identity.IsAuthenticated is true)
            {
                FormsAuthentication.SignOut();
                Session.Clear();
                Response.Redirect("~/");
            }
            else
            {
                //If the user is not authenticated, redirect to login page.
                Response.Redirect("~/Login");
            }
        }
    }
}