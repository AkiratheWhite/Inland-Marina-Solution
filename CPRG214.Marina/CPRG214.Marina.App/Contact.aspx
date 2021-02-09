<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CPRG214.Marina.App.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <hr />
    <address>

    <h3>Address:</h3>
    Inland Lake Marina<br />
    Box 123<br />
    Inland Lake, Arizona, 86038<br />
    
    <hr />

    <h3>Staff:</h3>
    <strong>Manager: </strong>Glenn Cooke<br />
    <strong>Slip Amanger: </strong> Kimberley Carson<br />

    <hr />

    <h3>Contact Info:</h3>
    <strong>Office Phone: </strong>928-555-2234<br />
    <strong>Leasing Phone: </strong>928-555-2235<br />
    <strong>Fax: </strong>928-555-2236<br />
    <strong>Email: </strong><a href="mailto:info@inlandmarina.com">info@inlandmarina.com</a>
    
    </address>

</asp:Content>
