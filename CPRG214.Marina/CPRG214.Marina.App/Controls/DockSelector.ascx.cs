using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.Marina.Data;

namespace CPRG214.Marina.App.Controls
{
    public partial class DockSelector : System.Web.UI.UserControl
    {
        //declare the event
        public event DockSelectionHandler DockSelect;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = new DockManager();
                uxDockSelector.DataSource = mgr.GetAllAsListItem();
                uxDockSelector.DataTextField = "Name";
                uxDockSelector.DataValueField = "ID";
                uxDockSelector.DataBind();
            }
        }

        protected void uxDockSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //the event is invoked here
            if (DockSelect != null)
            {
                //retrieve ID from drop down menu 
                var id = Convert.ToInt32(uxDockSelector.SelectedValue);

                //call manager class to retrieve slip

                //set the state of the form
            }
        

        }
    }
}

