using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security; //Needed for redirecting.
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.Marina.Data;

namespace CPRG214.Marina.App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event handler for when a user clicks the login button.
        /// If the user's information exist in the database, authenticate them.
        /// If the user's information does not match any records in the database, inform them and tell them to try again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Pass user login information to the authentication manager.
            var authAttempt = (userDTO)AuthManager.Authenticate(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtCity.Text);

            if (authAttempt != null)
            {
                //If the authorization is successful, add the customer's ID to the session.
                Session.Add("custID", authAttempt.custID);

                //Redirect user after successful login.
                FormsAuthentication.RedirectFromLoginPage(authAttempt.FullName, false);
            }
            
            else
            {
                //Sends an error message to the ValidationSummary.
                ModelState.AddModelError("", "No customer with this information was found. Please try again.");
            }
        }
    }
}