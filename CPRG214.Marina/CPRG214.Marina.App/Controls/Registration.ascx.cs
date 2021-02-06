using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.Marina.Data;

namespace CPRG214.Marina.App.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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

            //Pass the new customer object to the authentication manager to insert in to DataContext.
            AuthManager.Add(customer);

            //Redirect the user to a confirmation page.
            Response.Redirect("~/Confirm");
        }
    }
}