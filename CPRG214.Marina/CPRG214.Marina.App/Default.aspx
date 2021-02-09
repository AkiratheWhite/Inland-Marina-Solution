<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CPRG214.Marina.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="jumbotron-div">
            <h1>Your next waterfaring adventure awaits...</h1>
            <p class="lead">Welcome to Inland Marina, located on the south shore Inland Lake, just a short commute from major centers in the south west!</p>
            <p><a href="/Register" class="btn btn-primary btn-lg">Register Now &raquo;</a></p>
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>About Us</h2>
            <p>
                Inland Marina was established in 1967 shortly after Inland Lake was created as a result of the South West dam.
                From its humble beginnings, it has grown to be the largest marina on Inland Lake.
            </p>
            <p>
                Due to the warm climate that extends year round, Inland Lake has become a popular tourist destination in the south west.
                Boat owners from California, Arizona, Nevada, and Utah are attracted to the area.
            </p>
            <p>
                Inland Marina has 90 slips ranging in size from 16 to 32 feet in length.  Dock services include electrical and fresh water.
            </p>
        </div>

        <div class="col-md-6">
            <h2>Available Slips</h2>
            <p>
                Our docks and slips can be viewed here.
            </p>
            <p>
                <p><a href="/AvailableSlips" class="btn btn-info">View Slips &raquo;</a></p>
            </p>
        </div>
    </div>

</asp:Content>
