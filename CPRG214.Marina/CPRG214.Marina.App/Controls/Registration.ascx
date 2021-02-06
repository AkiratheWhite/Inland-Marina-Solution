<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="CPRG214.Marina.App.Controls.Registration" %>
<asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick">
    <WizardSteps>
        <asp:WizardStep runat="server" title="Enter your information.">
            <br>
            <table class ="table">
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone No.:</td>
                    <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </asp:WizardStep>
    </WizardSteps>
</asp:Wizard>

