﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CPRG214.Marina.App.Register" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:Registration runat="server" ID="Registration" />
</asp:Content>