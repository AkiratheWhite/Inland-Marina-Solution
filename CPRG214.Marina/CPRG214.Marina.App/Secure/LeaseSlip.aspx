<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="CPRG214.Marina.App.Secure.LeaseSlip" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Lease Slips</h3>
    <br />
    <br />

    <div class="mb-4">
        <h4>Currently available</h4>
        <div class="d-inline">
            <div class="d-inline">Choose a dock: </div>
            <div class="d-inline">
                <uc1:dockselector runat="server" id="DockSelector" AllowPostBack="true" />
            </div>
        </div>
    </div>

    <h5>Available Slips for Lease</h5>
    <asp:GridView 
        class="styled-table mx-auto w-75 mb-6" 
        ID="uxAvailSlipSortedByDock1" 
        runat="server" 
        AutoGenerateSelectButton="True" 
        AutoGenerateColumns="false" OnSelectedIndexChanged="uxAvailSlipSortedByDock1_SelectedIndexChanged1"> 

        <Columns>
            <asp:BoundField DataField="ID" HeaderText="Slip Number" />
            <asp:BoundField DataField="Width" HeaderText="Width of Dock" />
            <asp:BoundField DataField="Length" HeaderText="Length of Dock" />
            <asp:BoundField DataField="DockID" HeaderText="Dock Number" />
        </Columns>
    </asp:GridView>
     
    <h5>Previously Leased</h5>
    <asp:GridView class="styled-table mx-auto w-75" AutoGenerateColumns="false" ID="uxPreviouslyLeased" runat="server">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="Purchase Number" />
            <asp:BoundField DataField="SlipID" HeaderText="Slip Number" />
        </Columns>
    </asp:GridView>
    





 
</asp:Content>
