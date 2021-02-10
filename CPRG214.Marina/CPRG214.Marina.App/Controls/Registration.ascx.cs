using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.Marina.Data;

namespace CPRG214.Marina.App.Controls
{
    /***
     * Code written by: Tony Li
     * Last Modified (MM/DD/YY): 02/09/21 
     ***/
    public partial class Registration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for when the user clicks the finish button on the wizard.
        /// Checks to see if the customer record already exists, and if it does not, add the user to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //Creates a new customer object from the information entered into the wizard.
            var customer = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                City = txtCity.Text
            };

            //Checks to see if the user is already registered. If they are, prevent them from registering again.
            if (AuthManager.Exists(customer.FirstName, customer.LastName, customer.Phone, customer.City)) {
                //Model state belongs to the page, not the user control. Have to declare Page.ModelState
                Page.ModelState.AddModelError("", "A record for this customer already exists. Please sign in with your information.");
            }

            else
            {
                //Pass the new customer object to the authentication manager to insert in to DataContext.
                AuthManager.Add(customer);

                //Redirect the user to a confirmation page.
                Response.Redirect("~/Confirm");
            }
        }
    }
}