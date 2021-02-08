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
            <td><uc1:dockselector runat="server" id="DockSelector" /></td>
        </tr>
    </table>
    

    <asp:GridView class="table" ID="uxDockByID" runat="server"></asp:GridView>


 
</asp:Content>
