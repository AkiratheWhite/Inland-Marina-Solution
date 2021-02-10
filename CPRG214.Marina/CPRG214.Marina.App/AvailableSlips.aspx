<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvailableSlips.aspx.cs" Inherits="CPRG214.Marina.App.AvailableSlips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>Available Slips</h3>
        <p>Register or login to lease a slip. Happy sailing!</p>
    </div>
    

    <asp:GridView 
        class="styled-table mx-auto w-75" 
        ID="uxAvailableSlips" 
        runat="server"
        AutoGenerateColumns="false"> 

        <Columns>
            <asp:BoundField DataField="ID" HeaderText="Purchase Number" />
            <asp:BoundField DataField="Width" HeaderText="Width of Dock" />
            <asp:BoundField DataField="Length" HeaderText="Length of Dock" />
        </Columns>
    </asp:GridView>

</asp:Content>



