<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/SubAdminMasterPage.Master"  CodeFile="Job_Jobs.aspx.cs" Inherits="Job_Job_Jobs" %>
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
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    </style>
<asp:UpdatePanel ID="upJobs" runat="server">
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
                    
                  	    <li style="background:none;"><asp:LinkButton ID="lnkManageAdmin" runat="server" CausesValidation="false" Text="Job Manage Admin" 
                                onclick="lnkManageAdmin_Click"></asp:LinkButton></li> 
                 </ul>
                 </div>
            </div>
         <div class="gridpanelpadd" >   
          <div class="gridpanel">
                <telerik:RadGrid ID="rgjobs" runat="server" AutoGenerateColumns="False" GridLines="None" Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12"
                    CellPadding="0" OnDeleteCommand="rgjobs_DeleteCommand" OnInsertCommand="rgjobs_InsertCommand"
                    OnUpdateCommand="rgjobs_UpdateCommand" OnNeedDataSource="rgjobs_NeedDataSource"
                    OnItemDataBound="rgjobs_ItemDataBound" OnItemCommand="rgjobs_ItemCommand">
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
                            <telerik:GridTemplateColumn HeaderText="Job ID" HeaderStyle-Width="80px" SortExpression="jobid" UniqueName="jobid"
                                ItemStyle-Height="30px">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblJobId" Text='<%# Eval("jobid") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadTextBox ID="rtbJobId" Text='<%# Eval("jobid") %>' runat="server"
                                        Width="244px" />
                                    <asp:RequiredFieldValidator ID="rfvJobId" runat="server" ControlToValidate="rtbJobId"
                                        ErrorMessage="Please enter job id" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <%--<telerik:GridBoundColumn DataField="jobtitle" HeaderText="Job Title" SortExpression="jobtitle"
                                UniqueName="jobtitle" ColumnEditorID="GridTextBoxColumnEditor1">
                            </telerik:GridBoundColumn>--%>
                            <telerik:GridTemplateColumn HeaderText="Job Title" HeaderStyle-Width="80px" SortExpression="jobtitle" UniqueName="jobtitle"
                                ItemStyle-Height="30px">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblJobTitle" Text='<%# Eval("jobtitle") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadTextBox ID="rtbJobTitle" Text='<%# Eval("jobtitle") %>' runat="server"
                                        Width="244px" />
                                    <asp:RequiredFieldValidator ID="rfvJobTitle" runat="server" ControlToValidate="rtbJobTitle"
                                        ErrorMessage="Please enter job title" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="Facility" ItemStyle-Width="75px" SortExpression="facility" UniqueName="facility">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbfacility" Text='<%# Eval("facility") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbfacility" DataTextField="facility" Width="250px" DataValueField="facility" 
                                        runat="server" />
                                    <asp:RequiredFieldValidator ID="rfvFacility" runat="server" InitialValue="--Select--" ControlToValidate="rcbfacility"
                                        ErrorMessage="Please select facility" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="Country" ItemStyle-Width="125px" SortExpression="country" UniqueName="country">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblcountry" Text='<%# Eval("country") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbcountry" DataTextField="country" CausesValidation="false" DataValueField="country" OnSelectedIndexChanged="rcbcountry_SelectedIndexChanged"
                                        AutoPostBack="true" runat="server" Width="250px" />
                                    <asp:RequiredFieldValidator ID="rfvCountry" runat="server" InitialValue="--Select--" ControlToValidate="rcbcountry"
                                        ErrorMessage="Please select Country" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="State" ItemStyle-Width="125px" SortExpression="state" UniqueName="State">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblstate" Text='<%# Eval("state") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbstate" DataTextField="state" DataValueField="state" CausesValidation="false" OnSelectedIndexChanged="rcbstate_SelectedIndexChanged"
                                        AutoPostBack="true" runat="server" Width="250px" />
                                    <asp:RequiredFieldValidator ID="rfvState" runat="server" InitialValue="--Select--" ControlToValidate="rcbstate"
                                        ErrorMessage="Please select state" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                              <telerik:GridTemplateColumn HeaderText="City" ItemStyle-Width="75px" SortExpression="city" UniqueName="city">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblcity" Text='<%# Eval("city") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbcity" DataTextField="city" CausesValidation="false" DataValueField="city"
                                        runat="server" Width="250px" />
                                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" InitialValue="--Select--" ControlToValidate="rcbcity"
                                        ErrorMessage="Please select city" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>
                             <telerik:GridTemplateColumn HeaderText="Speciality" ItemStyle-Width="175px" SortExpression="speciality" UniqueName="speciality">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lbspeciality" Text='<%# Eval("speciality") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <telerik:RadComboBox ID="rcbspeciality" DataTextField="speciality" CausesValidation="false" DataValueField="speciality" 
                                        runat="server" Width="250px" />
                                    <asp:RequiredFieldValidator ID="rfvSpeciality" runat="server" InitialValue="--Select--" ControlToValidate="rcbspeciality"
                                        ErrorMessage="Please select speciality" Display="Dynamic" SetFocusOnError="true" />
                                </EditItemTemplate>
                            </telerik:GridTemplateColumn>  
                            <telerik:GridTemplateColumn Visible="false" HeaderText="Description" SortExpression="description" UniqueName="description">
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
                             <telerik:GridTemplateColumn HeaderText="Visibility" HeaderStyle-Width="80px" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" SortExpression="visibility" UniqueName="visibility">
                                <ItemTemplate>
                                <asp:Image ID="imgVisibility" runat="server" />                               
                                <asp:Label runat="server" ID="lbvisibility" Visible="false" Text='<%# Eval("visibility") %>'></asp:Label>                                
                                 </ItemTemplate>     
                                  <EditItemTemplate>
                                  <asp:CheckBox ID="chkVisibilty" runat="server"  />
                                </EditItemTemplate>                         
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                HeaderStyle-HorizontalAlign="Center" UniqueName="DeleteColumn" ItemStyle-VerticalAlign="Middle"
                                HeaderStyle-Width="70px">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" ToolTip="click here to delete"
                                        CssClass="MyImageButton"><img src="../ImagesNew/Jobs/jobCloseButton.png" border="0px" alt="delete" /></asp:LinkButton>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                            <%--<telerik:GridButtonColumn ConfirmText="Delete this Job?" ConfirmDialogType="RadWindow" 
                                ConfirmTitle="Delete" ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                                UniqueName="DeleteColumn">
                                <ItemStyle HorizontalAlign="Center" CssClass="MyImageButton" />
                            </telerik:GridButtonColumn>   --%>
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
