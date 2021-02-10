using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using CPRG214.Marina.Data;
using CPRG214.Marina.App.Controls;

namespace CPRG214.Marina.App.Secure
{
    public partial class LeaseSlip : System.Web.UI.Page
    {
        List<Slip> selectedSlipList;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack || Session["leaseslip"] is null)
            {
                selectedSlipList = new List<Slip>();
                Session.Add("leaseslip", selectedSlipList);
                
            }

            DockSelector.DockSelect += DockSelector_DockSelect;
            uxPreviouslyLeased.DataSource = LeaseManager.Find(Convert.ToInt32(Session["custID"]));
            uxPreviouslyLeased.DataBind();
        }

        private void DockSelector_DockSelect(object sender, DockEventArgs e)
        {
            var dockID = e.ID;
            var availableSlips = SlipManager.FindAvailableSlipByDock(dockID);

            uxAvailSlipSortedByDock1.DataSource = availableSlips;
            uxAvailSlipSortedByDock1.DataBind();

            foreach (GridViewRow row in uxAvailSlipSortedByDock1.Rows)
            {
                LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
                lb.Text = "Lease";

            }
        }

        protected void uxAvailSlipSortedByDock1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Slip selectedSlip = buildSelectedSlip();
            addSelectedSlipToDatabase(selectedSlip);

            addToLeasManager(selectedSlip.ID);
            Response.Redirect(Request.RawUrl.ToString());
        }

        private void addToLeasManager(int selectedSlipId)
        {
            int slipID = Convert.ToInt32(selectedSlipId);
            int custID = Convert.ToInt32(Session["custID"]);

            LeaseManager.Add(slipID, custID);
        }

        private Slip buildSelectedSlip()
        {
            Slip selectedSlip = new Slip();

            selectedSlip.ID = Convert.ToInt32(uxAvailSlipSortedByDock1.SelectedRow.Cells[1].Text);
            selectedSlip.Width = Convert.ToInt32(uxAvailSlipSortedByDock1.SelectedRow.Cells[2].Text);
            selectedSlip.Length = Convert.ToInt32(uxAvailSlipSortedByDock1.SelectedRow.Cells[3].Text);
            selectedSlip.DockID = Convert.ToInt32(uxAvailSlipSortedByDock1.SelectedRow.Cells[4].Text);

            return selectedSlip;
        }

        private void addSelectedSlipToDatabase(Slip selectedSlip)
        {
            selectedSlipList = (List<Slip>)Session["leaseslip"];
            selectedSlipList.Add(selectedSlip);
        }
    }
}