<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Jobs/AdminMasterPage.Master" CodeFile="Job_AdminJobs.aspx.cs" Inherits="Jobs_Job_AdminJobs" %>
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
    #ctl00_MainContent_rgjobs_ctl00_ctl02_ctl03_EditCell__jobid input{width:242px; height:30px; line-height:30px; padding:0 5px;  background:url(../ImagesNew/jobs/facilityTextBox-Bg.jpg) no-repeat left top; border:none; border-spacing:none!important; color: #333333; font: 12px "Segoe UI",Arial,sans-serif;}
    #ctl00_MainContent_rgjobs_ctl00_ctl02_ctl03_EditCell__jobtitle input{width:242px; height:30px; line-height:30px; padding:0 5px;  background:url(../ImagesNew/jobs/facilityTextBox-Bg.jpg) no-repeat left top; border:none; border-spacing:none!important; color: #333333; font: 12px "Segoe UI",Arial,sans-serif;}
    .Default.reWrapper{border: 1px solid #c0d3e2!important;}
    
    .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    .RadGrid_Hay .rgHeader, .RadGrid_Hay th.rgResizeCol{background:url("../../ImagesNew/jobs/gridbg_adminpage.gif") repeat-x scroll 0 -2300px #2DAFE3 !important}    
    </style>
    <asp:UpdatePanel runat="server" ID="upJobs">
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
                                                    <h3>
                                                        Admin Jobs</h3>
                                                    <div class="adminlogoutpanel">
                                                        <ul>
                                                            <li style="background: none;">
                                                                <asp:LinkButton ID="lnkManageAdmin" CausesValidation="false" runat="server" Text="Job Manage Admin" OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                            <li>
                                                                <asp:LinkButton ID="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="gridpanelpadd">
                                                    <div class="gridpanel">
                                                        <telerik:RadGrid ID="rgjobs" runat="server" AutoGenerateColumns="False" GridLines="None"
                                                            Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12" Width="918px"
                                                            CellPadding="0" OnDeleteCommand="rgjobs_DeleteCommand" OnInsertCommand="rgjobs_InsertCommand"
                                                            OnUpdateCommand="rgjobs_UpdateCommand" OnNeedDataSource="rgjobs_NeedDataSource"
                                                            OnItemDataBound="rgjobs_ItemDataBound" OnItemCommand="rgjobs_ItemCommand">
                                                            <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                                                                DataKeyNames="Jid,JobId,ClientId">
                                                                <CommandItemSettings AddNewRecordText="Add Job" />
                                                                <EditFormSettings EditColumn-InsertText="Save" EditColumn-UpdateText="Save">
                                                                </EditFormSettings>
                                                                <Columns>
                                                                    <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn"
                                                                        ItemStyle-Height="30px" ItemStyle-HorizontalAlign="Center">
                                                                        <ItemStyle CssClass="imgedit" />
                                                                    </telerik:GridEditCommandColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Client" SortExpression="Client" UniqueName="Client"
                                                                        ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblClient" Text='<%# Eval("Client") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbclient" CausesValidation="false" DataTextField="Client" runat="server" Width="250px"
                                                                                DataValueField="Client" AutoPostBack="true" Filter="Contains" OnSelectedIndexChanged="rcbclient_SelectedIndexChanged" />
                                                                            <asp:RequiredFieldValidator ID="rfvClient" runat="server" ControlToValidate="rcbclient"
                                                                                ErrorMessage="Please select client" Display="Dynamic" InitialValue="--Select--" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Job ID" SortExpression="jobid" UniqueName="jobid"
                                                                        ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblJobId" Text='<%# Eval("jobid") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadTextBox ID="rtbJobId" Text='<%# Eval("jobid") %>' runat="server" Width="247px" />
                                                                            <asp:RequiredFieldValidator ID="rfvJobId" runat="server" ControlToValidate="rtbJobId"
                                                                                ErrorMessage="Please enter job id" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Job Title" SortExpression="jobtitle" UniqueName="jobtitle"
                                                                        ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblJobTitle" Text='<%# Eval("jobtitle") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadTextBox ID="rtbJobTitle" Text='<%# Eval("jobtitle") %>' runat="server" Width="247px" />
                                                                            <asp:RequiredFieldValidator ID="rfvJobTitle" runat="server" ControlToValidate="rtbJobTitle"
                                                                                ErrorMessage="Please enter job title" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Facility" SortExpression="facility" UniqueName="facility"
                                                                        ItemStyle-Width="75px" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lbfacility" Text='<%# Eval("facility") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbfacility" Width="250px" DataTextField="facility" DataValueField="facility"
                                                                                runat="server" />
                                                                            <asp:RequiredFieldValidator ID="rfvFacility" runat="server" ControlToValidate="rcbfacility"
                                                                                ErrorMessage="Please select facility" InitialValue="--Select--" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Country" SortExpression="country" UniqueName="country"
                                                                        ItemStyle-Width="75px" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblcountry" Text='<%# Eval("country") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbcountry" CausesValidation="false" DataTextField="country" Width="250px" DataValueField="country"
                                                                                OnSelectedIndexChanged="rcbcountry_SelectedIndexChanged" AutoPostBack="true"
                                                                                runat="server" />
                                                                            <asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="rcbcountry"
                                                                                ErrorMessage="Please select country" InitialValue="--Select--" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="State" SortExpression="state" UniqueName="state"
                                                                        ItemStyle-Width="75px" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblstate" Text='<%# Eval("state") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbstate" CausesValidation="false" DataTextField="state" Width="250px" DataValueField="state"
                                                                                OnSelectedIndexChanged="rcbstate_SelectedIndexChanged" AutoPostBack="true" runat="server" />
                                                                            <asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="rcbstate"
                                                                                ErrorMessage="Please select state" InitialValue="--Select--" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="City" SortExpression="state" UniqueName="city"
                                                                        ItemStyle-Width="75px" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lblcity" Text='<%# Eval("city") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbcity" Width="250px" CausesValidation="false" DataTextField="city" DataValueField="city"
                                                                                runat="server" />
                                                                            <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="rcbcity"
                                                                                ErrorMessage="Please select city" InitialValue="--Select--" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Speciality" SortExpression="speciality" UniqueName="speciality"
                                                                        ItemStyle-Width="75px" ItemStyle-Height="30px">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lbspeciality" Text='<%# Eval("speciality") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadComboBox ID="rcbspeciality" DataTextField="speciality" DataValueField="speciality"
                                                                                runat="server" Width="250px" />
                                                                            <asp:RequiredFieldValidator ID="rfvSpeciality" runat="server" ControlToValidate="rcbspeciality"
                                                                                ErrorMessage="Please select speciality" InitialValue="--Select--" Display="Dynamic" SetFocusOnError="true" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn Visible="false" HeaderText="Description" SortExpression="description"
                                                                        UniqueName="description">
                                                                        <ItemTemplate>
                                                                            <asp:Label runat="server" ID="lbdescription" Text='<%# Eval("description") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <telerik:RadEditor ID="rddescription" Width="600px" runat="server" OnClientLoad="OnClientLoad">
                                                                                <Tools>
                                                                                    <telerik:EditorToolGroup>
                                                                                    </telerik:EditorToolGroup>
                                                                                </Tools>
                                                                            </telerik:RadEditor>
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Visibility" SortExpression="visibility" UniqueName="visibility"
                                                                        HeaderStyle-Width="80px" HeaderStyle-HorizontalAlign="Center" ItemStyle-Height="30px"
                                                                        ItemStyle-HorizontalAlign="Center">
                                                                        <ItemTemplate>
                                                                            <asp:Image ID="imgVisibility" runat="server" />
                                                                            <asp:Label runat="server" ID="lbvisibility" Visible="false" Text='<%# Eval("visibility") %>'></asp:Label>
                                                                        </ItemTemplate>
                                                                        <EditItemTemplate>
                                                                            <asp:CheckBox ID="chkVisibilty" runat="server" />
                                                                        </EditItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                                                        HeaderStyle-HorizontalAlign="Center" UniqueName="DeleteColumn" ItemStyle-VerticalAlign="Middle" HeaderStyle-Width="70px">
                                                                        <ItemTemplate>
                                                                            <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete"
                                                                                ToolTip="click here to delete"  CssClass="MyImageButton" ><img src="../ImagesNew/Jobs/jobCloseButton.png" border="0px" alt="delete" /></asp:LinkButton>
                                                                        </ItemTemplate>
                                                                    </telerik:GridTemplateColumn>
                                                                    <%--<telerik:GridButtonColumn ConfirmText="Delete this Job?" ConfirmDialogType="RadWindow"
                                                                        ConfirmTitle="Delete" ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                                                                        UniqueName="DeleteColumn" HeaderStyle-Width="80px" HeaderStyle-HorizontalAlign="Center"
                                                                        ItemStyle-Height="30px" ItemStyle-HorizontalAlign="Center">
                                                                        <ItemStyle HorizontalAlign="Center" CssClass="MyImageButton" />
                                                                    </telerik:GridButtonColumn>--%>
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