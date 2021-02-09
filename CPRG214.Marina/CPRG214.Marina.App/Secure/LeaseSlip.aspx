<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlip.aspx.cs" Inherits="CPRG214.Marina.App.Secure.LeaseSlip" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Lease Slips</h3>
    <br />
    <br />

    <h4>Currently available</h4>
    <table>
        <tr>
            <td>Choose a dock:  </td>
            <td>
        <uc1:DockSelector runat="server" ID="DockSelector" AllowPostBack="True" />
            </td>
        </tr>
    </table>

    </br>
    <p>Available Slips for Lease</p>
    <asp:GridView ID="uxAvailSlipSortedByDock1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="869px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="uxAvailSlipSortedByDock1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    
    </br>
    <p >Selected Slips</p>
     <asp:GridView ID="uxSelectedSlip" runat="server"></asp:GridView>   
    <asp:Button ID="btnLease" runat="server" Text="Lease" OnClick="btnLease_Click" />
    
    
        <p>Previously Leased</p>
    <asp:GridView ID="uxPreviouslyLeased" runat="server" ></asp:GridView>
    
    



 
</asp:Content>
