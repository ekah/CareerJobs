<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminSideMenu.ascx.cs" Inherits="Admin_Controls_AdminSideMenu" %>

<div id="smoothmenu1" class="ddsmoothmenu">
<ul>
<%--<li><a href="#">View</a>
  <ul>
  <li><a href="AdminLoginView.aspx">Login</a></li>
  <li><a href="AdminProfilePageDetails.aspx">Account Status</a></li>
  <li><a href="AdminHospitalView.aspx">Hospital</a></li>
  <li><a href="AdminAppointmentView.aspx">Appointment</a></li>
  <li><a href="AdminPatientSearch.aspx">Patient Search</a></li>
  <li><a href="AdminNoProfile.aspx">Account without profiles</a></li>
  <li><a href="AdminOrganizationNoDoctor.aspx">Organization without Doctors / Services</a></li>
  </ul>
</li>
<li><a href="#">SMS</a>
  <ul>
  <li><a href="AdminSMSView.aspx">Group</a></li>
  <li><a href="AdminSMSIndividual.aspx">Individual</a></li>
  <li><a href="AdminRemainderSMS.aspx">Reminder</a></li>
  </ul>
</li>
<li><a href="AdminHospitalActivation.aspx">Hospital Account Activation</a></li>--%>
<%--<li><a href="#">Manage</a>--%>
<li><a href="../Jobs/Job_ManageAdmin.aspx">Jobs</a></li>
  <ul>
  <%--<li><a href="AdminMapDepartmentDiagnosis.aspx">Mapping</a></li>
  <li><a href="AdminListDepartment.aspx">Department</a></li>
  <li><a href="AdminListDiagnosis.aspx">Diagnosis</a></li>
  <li><a href="AdminListSymptom.aspx">Symptoms</a></li>--%>
  
  </ul>
</li>
<li><a href="AdminIndex.aspx">Logout</a></li>
</ul>
<br style="clear: left" />
</div>
<%--
<ul class="listItem" id="Admin" runat="server">
    <li><a href="AdminLoginView.aspx">Login - Detail View</a></li>
    <li><a href="AdminHospitalActivation.aspx">Hospital Account Activation</a></li>  
    <li><a href="../Jobs/Job_ManageAdmin.aspx">Manage Admin Jobs</a></li>
    <li><a href="AdminMapDepartmentDiagnosis.aspx">Mapping - Department</a></li>
    <li><a href="AdminListDepartment.aspx">List Department</a></li>
    <li><a href="AdminListDiagnosis.aspx">List Diagnosis</a></li>
    <li><a href="AdminListSymptom.aspx">List Symptoms</a></li>    
    <li><a href="AdminSMSView.aspx">SMS - Detail View</a></li>
    <li><a href="AdminHospitalView.aspx">Hospital - Detail View</a></li> 
    <li><a href="AdminAppointmentView.aspx">Appointment - Detail View</a></li> 
    <li><a href="AdminPatientSearch.aspx">Patient Search - Detail View</a></li>
    <li><a href="AdminRemainderSMS.aspx">Remainder SMS - Detail View</a></li>
    <li><a href="AdminIndex.aspx">Logout</a></li>
</ul>
--%>