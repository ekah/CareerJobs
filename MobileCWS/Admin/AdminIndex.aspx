<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMedAppointment.master" AutoEventWireup="true" CodeFile="AdminIndex.aspx.cs" Inherits="Admin_AdminIndex" %>

<%@ Register Src="~/Admin/Controls/AdminSignIn.ascx" TagName="AdminSignIn" TagPrefix="medAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphAdminMaster" Runat="Server">
<div align="center">
    <medAdmin:AdminSignIn ID="adminSignIn" runat="server" />
</div>
</asp:Content>

