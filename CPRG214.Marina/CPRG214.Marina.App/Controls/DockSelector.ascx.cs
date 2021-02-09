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
       
        public Slip slip { get; set; }

        public bool AllowPostBack
        {
            get { return uxDockSelector.AutoPostBack; }
            set { uxDockSelector.AutoPostBack = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = new DockManager();
                uxDockSelector.DataSource = mgr.GetAllAsListItem();
                uxDockSelector.DataTextField = "Name";
                uxDockSelector.DataValueField = "ID";
                uxDockSelector.DataBind();
                uxDockSelector.SelectedIndex = 0;
                uxDockSelector_SelectedIndexChanged(this, e);
            }
        }

        protected void uxDockSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DockSelect != null)
            {
                var dockID = Convert.ToInt32(uxDockSelector.SelectedValue);
                Dock dock = DockManager.Find(dockID);
                var arg = new DockEventArgs
                {
                    ID = dock.ID,
                    Name = dock.Name,
                    WaterService = dock.WaterService,
                    ElectricalService = dock.ElectricalService

                };
                DockSelect.Invoke(this, arg);

            }
            
        }
    }
}

