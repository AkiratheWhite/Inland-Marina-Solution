<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="CPRG214.Marina.App.Controls.Registration" %>
<asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick" FinishCompleteButtonText="Register">
    <WizardSteps>
        <asp:WizardStep runat="server" title=" ">
            <br>
            <table class ="table">
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First name is required.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last name is required.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Phone No.:</td>
                    <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone number is required.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" ErrorMessage="City is required.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </asp:WizardStep>
    </WizardSteps>
</asp:Wizard>

<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />


