<%@ Control Language="C#" AutoEventWireup="true" CodeFile="JobSearchRight.ascx.cs" Inherits="Job_JobSearchRight" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:UpdatePanel ID="upJobSearchRight" runat="server">
<ContentTemplate>
<div>
    <h2>
        Career Search</h2>
    <div style="font-size: 11px;">
        Product greater career success.<br />
        Find your perfect position with us now.
    </div>
    <div id="divFacility" runat="server" style="padding:7px 0;">
        <telerik:RadComboBox ID="rcbfacility" runat="server" style="width:247px;" >
        </telerik:RadComboBox>
    </div>
    <div style="padding:7px 0;">
        <telerik:RadComboBox ID="rcbspeciality" runat="server" style="width:247px;" >
        </telerik:RadComboBox>
    </div>
    <div id="divCountry" runat="server" style="padding:7px 0;">
        <telerik:RadComboBox ID="rcbcountry" runat="server" AutoPostBack="true" 
          style="width:247px;" 
            OnSelectedIndexChanged="rcbcountry_SelectedIndexChanged" CausesValidation="false">
        </telerik:RadComboBox>
    </div>
      <div id="divState" runat="server" style="padding:7px 0;">
        <telerik:RadComboBox ID="rcbstate" runat="server" AutoPostBack="true" 
             style="width:247px;" 
              OnSelectedIndexChanged="rcbstate_SelectedIndexChanged"  CausesValidation="false">
        </telerik:RadComboBox>
    </div>
      <div id="divCity" runat="server" style="padding:7px 0;">
        <telerik:RadComboBox ID="rcbcity" runat="server"  style="width:247px;" >
        </telerik:RadComboBox>
    </div>
    <div style="width: 247px; padding:7px 0;">
        <input name="txtKeyword" type="text" title="Keyword" runat="server" id="txtKeyword"
            onblur="this.value=(this.value=='') ? 'Keyword' : this.value;" onfocus="this.value=(this.value=='Keyword') ? '' : this.value;"
            value="Keyword" style="float: left; width:136px; color:#333333; font-family:Segoe UI,arial,sans-serif;  margin:0 10px 0 0; "  />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"
            CausesValidation="false" Style="float: left; width:95px;" />
    </div>
</div>
</ContentTemplate>
</asp:UpdatePanel>
