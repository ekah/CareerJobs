<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_HrJobs.aspx.cs" Inherits="Jobs_Job_HrJobs" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function OnClientLoad(editor, args) {
        var style = editor.get_contentArea().style;
        style.backgroundImage = "none";
        style.backgroundColor = "White";
        style.color = "black";
    }
</script>
<style>
    .fullWidthPageContent{padding:0!important;}
    .fullWidthPageTopbg .fullWidthPageContent h3{line-height: 40px!important;}
    .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
            .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    
    </style>
    <asp:UpdatePanel ID="upJob_HrJobs" runat="server">
    <ContentTemplate>
    <div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">
<div class="jobs_content">
 <div class="innerpanel">
    <div class="adminpanel">
         
        <div class="adminpage_cntbgmid">
            <div class="adminheadingbg">
                <h3>Admin Jobs</h3>
                <div class="adminlogoutpanel">
                <ul>
                <li style="background:none;"><asp:LinkButton ID="lnkManageAdmin" CausesValidation="false" runat="server" Text="Job Manage Admin" 
                                onclick="lnkManageAdmin_Click"></asp:LinkButton></li> 
                 </ul>
                 </div>
            </div>
         <div class="gridpanelpadd" >   
          <div class="gridpanel">
                <telerik:RadGrid ID="rgjobs" runat="server" AutoGenerateColumns="False" GridLines="None" Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12"
                    CellPadding="0" OnInsertCommand="rgjobs_InsertCommand"
                    OnUpdateCommand="rgjobs_UpdateCommand" OnNeedDataSource="rgjobs_NeedDataSource"
                    OnItemDataBound="rgjobs_ItemDataBound">
                    <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                        DataKeyNames="Jid,JobId">
			            <CommandItemSettings AddNewRecordText="Add Job"  /> 
                        <EditFormSettings EditColumn-InsertText="Save" EditColumn-UpdateText="Save"></EditFormSettings>  
                        <Columns>
                            <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn">
                                <ItemStyle CssClass="imgedit" />
                            </telerik:GridEditCommandColumn>
                            <%--<telerik:GridBoundColumn DataField="jobid" HeaderText="Job ID" SortExpression="jobid"
                                UniqueName="jobid" ColumnEditorID="GridTextBoxColumnEditor1">
                            </telerik:GridBoundColumn>--%>
                            <telerik:GridTemplateColumn HeaderText="Job ID" SortExpression="jobid" UniqueName="jobid"
                                ItemStyle-Height="30px">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblJobId" Text='<%# Eval("jobid") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadTextBox ID="rtbJobId" Text='<%# Eval("jobid") %>' runat="server" Width="154px" />
                                    <asp:RequiredFieldValidator ID="rfvJobId" runat="server" ControlToValidate="rtbJobId"
                                        ErrorMessage="Please enter job id" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <%--<telerik:GridBoundColumn DataField="jobtitle" HeaderText="Job Title" SortExpression="jobtitle"
                                UniqueName="jobtitle" ColumnEditorID="GridTextBoxColumnEditor1">
                            </telerik:GridBoundColumn>--%>
                            <telerik:GridTemplateColumn HeaderText="Job Title" SortExpression="jobtitle" UniqueName="jobtitle"
                                ItemStyle-Height="30px">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblJobTitle" Text='<%# Eval("jobtitle") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadTextBox ID="rtbJobTitle" Text='<%# Eval("jobtitle") %>' runat="server" Width="154px" />
                                    <asp:RequiredFieldValidator ID="rfvJobTitle" runat="server" ControlToValidate="rtbJobTitle"
                                        ErrorMessage="Please enter job title" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="Facility" SortExpression="facility" UniqueName="facility">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbfacility" Width="125px" Text='<%# Eval("facility") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbfacility" DataTextField="facility" DataValueField="facility" runat="server"/>
                                    <asp:RequiredFieldValidator ID="rfvFacility" runat="server" InitialValue="--Select--" ControlToValidate="rcbfacility"
                                        ErrorMessage="Please select facility" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="Country" SortExpression="country" UniqueName="country">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblcountry" Text='<%# Eval("country") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbcountry" DataTextField="country" CausesValidation="false" DataValueField="country" OnSelectedIndexChanged="rcbcountry_SelectedIndexChanged"
                                        AutoPostBack="true" runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvCountry" runat="server" InitialValue="--Select--" ControlToValidate="rcbcountry"
                                        ErrorMessage="Please select Country" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="State" SortExpression="state" UniqueName="state">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblstate" Text='<%# Eval("state") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbstate" DataTextField="state" CausesValidation="false" DataValueField="state" OnSelectedIndexChanged="rcbstate_SelectedIndexChanged"
                                        AutoPostBack="true" runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvState" runat="server" InitialValue="--Select--" ControlToValidate="rcbstate"
                                        ErrorMessage="Please select state" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                              <telerik:GridTemplateColumn HeaderText="City" SortExpression="state" UniqueName="city">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblcity" Text='<%# Eval("city") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbcity" DataTextField="city" DataValueField="city"
                                        runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" InitialValue="--Select--" ControlToValidate="rcbcity"
                                        ErrorMessage="Please select city" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                             <telerik:GridTemplateColumn HeaderText="Speciality"  ItemStyle-Width="175px" SortExpression="speciality" UniqueName="speciality">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbspeciality" Text='<%# Eval("speciality") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbspeciality" DataTextField="speciality" DataValueField="speciality" 
                                        runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvSpeciality" runat="server" InitialValue="--Select--" ControlToValidate="rcbspeciality"
                                        ErrorMessage="Please select speciality" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>  
                            <telerik:GridTemplateColumn Visible="false" HeaderText="Description" ItemStyle-Width="175px" SortExpression="description" UniqueName="description">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbdescription" Text='<%# Eval("description") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                   <telerik:RadEditor ID="rddescription" runat="server" OnClientLoad="OnClientLoad">
 				                    <Tools>
                                    <telerik:EditorToolGroup>       
                                    </telerik:EditorToolGroup>                                    
                                   </Tools> 
                                   </telerik:RadEditor>
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn> 
                             <telerik:GridTemplateColumn HeaderText="Visibility" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" SortExpression="visibility" UniqueName="visibility">
                                <ItemTemplate>
                                <asp:Image ID="imgVisibility" runat="server" />                               
                                <asp:Label runat="server" ID="lbvisibility" Width="125px" Visible="false" Text='<%# Eval("visibility") %>'></asp:Label>                                
                                 </ItemTemplate>     
                                  <EditItemTemplate>
                                  <asp:CheckBox ID="chkVisibilty" runat="server"  />
                                </EditItemTemplate>                         
                            </telerik:GridTemplateColumn>                           
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </div>
             </div>
        </div>
   </div>
</div>
</div>
</div>
</div>
</div>
    </div>
</div> 
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
