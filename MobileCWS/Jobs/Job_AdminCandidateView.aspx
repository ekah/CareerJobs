<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/AdminMasterPage.Master"
    CodeFile="Job_AdminCandidateView.aspx.cs" Inherits="Jobs_Job_AdminCandidateView" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .fullWidthPageContent
        {
            padding: 0 !important;
        }
        .fullWidthPageTopbg .fullWidthPageContent h3
        {
            line-height: 40px !important;
        }
        .RadGrid_Hay .rgHeader, .RadGrid_Hay .rgHeader a{color: #FFFFFF !important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{padding-bottom:3px!important;}
    .RadGrid .rgHeader, .RadGrid th.rgResizeCol{border-right: 0 solid #406EB9 !important; }
    .RadGrid_Hay .rgHeader, .RadGrid_Hay th.rgResizeCol{background:url("../../ImagesNew/jobs/gridbg_adminpage.gif") repeat-x scroll 0 -2300px #2DAFE3 !important}
    </style>
    <asp:UpdatePanel runat="server" ID="upJob_AdminCandidateView">
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
                                                Candidate View</h3>
                                            <div class="adminlogoutpanel">
                                                <ul>
                                                    <li style="background: none;">
                                                        <asp:LinkButton ID="lnkManageAdmin" runat="server" Text="Job Manage Admin" OnClick="lnkManageAdmin_Click"></asp:LinkButton></li>
                                                    <li style="background: none;">
                                                    <asp:LinkButton ID="lnklogout" runat="server" Text="Logout" OnClick="lnklogout_Click"></asp:LinkButton></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="gridpanelpadd">
                                            <div class="gridpanel">
                                                <telerik:RadGrid ID="rgcandidate" runat="server" AutoGenerateColumns="False" GridLines="None"
                                                    Skin="Hay" AllowSorting="true" AllowPaging="true" PageSize="12" CellPadding="0"
                                                    OnUpdateCommand="rgcandidate_UpdateCommand" OnDeleteCommand="rgcandidate_DeleteCommand"
                                                    OnNeedDataSource="rgcandidate_NeedDataSource" OnItemDataBound="rgcandidate_ItemDataBound" Width="918px" >
                                                    <MasterTableView CommandItemDisplay="Top" InsertItemDisplay="Top" AutoGenerateColumns="false"
                                                        DataKeyNames="Aid,jobid,uploadresume">
                                                        <CommandItemSettings ShowAddNewRecordButton="false" />
                                                        <Columns>
                                                            <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn" ItemStyle-Height="30px" ItemStyle-Width="25px">
                                                                <ItemStyle CssClass="imgedit" />
                                                            </telerik:GridEditCommandColumn>
                                                             <telerik:GridBoundColumn DataField="applieddate" HeaderText="Applied Date" SortExpression="applieddate"
                                                                UniqueName="applieddate" ColumnEditorID="GridTextBoxColumnEditor1" ItemStyle-Height="30px" ItemStyle-Width="50px">
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="Client" HeaderText="Client" SortExpression="Client"
                                                                UniqueName="Client" ColumnEditorID="GridTextBoxColumnEditor1">
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="jobid" HeaderText="Job ID" SortExpression="jobid"
                                                                UniqueName="jobid" ColumnEditorID="GridTextBoxColumnEditor1" ItemStyle-Height="30px" ItemStyle-Width="75px">
                                                            </telerik:GridBoundColumn>
                                                            <%--<telerik:GridBoundColumn DataField="candidatename" HeaderText="Candidate Name" SortExpression="candidatename"
                                                                UniqueName="candidatename" ColumnEditorID="GridTextBoxColumnEditor1" ItemStyle-Height="30px" ItemStyle-Width="75px">
                                                            </telerik:GridBoundColumn>--%>
                                                            <telerik:GridTemplateColumn HeaderText="Candidate Name" SortExpression="candidatename" UniqueName="candidatename">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblcandidatename1" Text='<%# Eval("candidatename") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadTextBox ID="rtbcandidatename" Enabled="false" Width="146px" Text='<%# Eval("candidatename") %>' runat="server" />
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridBoundColumn DataField="specialization" HeaderText="Specialization" SortExpression="specialization"
                                                                UniqueName="specialization" ColumnEditorID="GridTextBoxColumnEditor1" ItemStyle-Height="30px" ItemStyle-Width="75px">
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridBoundColumn DataField="experience" HeaderText="Experience" SortExpression="experience"
                                                                UniqueName="experience" ColumnEditorID="GridTextBoxColumnEditor1" ItemStyle-Height="30px" ItemStyle-Width="75px">
                                                            </telerik:GridBoundColumn>
                                                            <telerik:GridTemplateColumn HeaderText="Status" SortExpression="hrstatus" UniqueName="hrstatus" ItemStyle-Height="30px" ItemStyle-Width="110px">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblstatus"  Text='<%# Eval("hrstatus") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadComboBox ID="rcbstatus" DataTextField="hrstatus" DataValueField="hrstatus"
                                                                        runat="server" Width="250px">
                                                                        <Items>
                                                                            <telerik:RadComboBoxItem Text="New" Value="New" />
                                                                            <telerik:RadComboBoxItem Text="For Review" Value="For Review" />
                                                                            <telerik:RadComboBoxItem Text="Short Listed" Value="Short Listed" />
                                                                            <telerik:RadComboBoxItem Text="Review Completed" Value="Review Completed" />
                                                                            <telerik:RadComboBoxItem Text="Interview Scheduled" Value="Interview Scheduled" />
                                                                            <telerik:RadComboBoxItem Text="Interview Completed" Value="Interview Completed" />
                                                                            <telerik:RadComboBoxItem Text="Hired" Value="Hired" />
                                                                            <telerik:RadComboBoxItem Text="Rejected" Value="Rejected" />
                                                                        </Items>
                                                                    </telerik:RadComboBox>
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="Final Status" SortExpression="finalstatus"
                                                                UniqueName="finalstatus" ItemStyle-Height="30px" ItemStyle-Width="75px">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lblfinalstatus"  Text='<%# Eval("finalstatus") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadComboBox ID="rcbfinalstatus" DataTextField="status" DataValueField="status"
                                                                        runat="server" Width="250px">
                                                                        <Items>
                                                                            <telerik:RadComboBoxItem Text="New" Value="New" />
                                                                            <telerik:RadComboBoxItem Text="On Hold" Value="On Hold" />
                                                                            <telerik:RadComboBoxItem Text="Hired" Value="Hired" />
                                                                            <telerik:RadComboBoxItem Text="Management" Value="Management" />
                                                                            <telerik:RadComboBoxItem Text="Rejected" Value="Rejected" />
                                                                        </Items>
                                                                    </telerik:RadComboBox>
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="Notes" SortExpression="notes" UniqueName="notes" ItemStyle-Height="30px" ItemStyle-Width="75px">
                                                                <ItemTemplate>
                                                                    <asp:Label runat="server" ID="lbnotes"  Text='<%# Eval("notes") %>'></asp:Label>
                                                                </ItemTemplate>
                                                                <EditItemTemplate>
                                                                    <telerik:RadEditor ID="rcbnotes" runat="server">
                                                                        <CssFiles>
                                                                            <telerik:EditorCssFile Value="EditorContentArea.css" />
                                                                        </CssFiles>
                                                                        <Tools>
                                                                            <telerik:EditorToolGroup>
                                                                            </telerik:EditorToolGroup>
                                                                        </Tools>
                                                                    </telerik:RadEditor>
                                                                </EditItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="View Candidate Details" SortExpression="candidatename"
                                                                UniqueName="candidatename" ItemStyle-Height="30px" ItemStyle-Width="110px">
                                                                <ItemTemplate>
                                                                    <a href='Job_AdminCandidateDetails.aspx?ClientId=<%#Eval("ClientId") %>&Id=<%#Eval("Aid") %>'
                                                                        target="_blank">
                                                                        <asp:Label ID="lblcandidatename" runat="server" Text='View'></asp:Label>
                                                                    </a>
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <telerik:GridTemplateColumn HeaderText="View Resume" SortExpression="uploadresume"
                                                                UniqueName="uploadresume" ItemStyle-Height="30px" ItemStyle-Width="110px">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lnkViewResume" runat="server" CommandArgument='<%# Eval("uploadresume") %>'
                                                                        OnClick="lnkViewResume_Click">View Resume</asp:LinkButton>
                                                                </ItemTemplate>
                                                            </telerik:GridTemplateColumn>
                                                            <%--<telerik:GridButtonColumn ConfirmText="Delete this Candidate?" ConfirmDialogType="RadWindow"
                                                                ConfirmTitle="Delete" ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                                                                UniqueName="DeleteColumn" ItemStyle-Height="30px" ItemStyle-Width="25px">
                                                                <ItemStyle HorizontalAlign="Center" CssClass="MyImageButton" />
                                                            </telerik:GridButtonColumn>--%>
                                                            <telerik:GridTemplateColumn HeaderText="Delete" ItemStyle-HorizontalAlign="Center"
                                                                HeaderStyle-HorizontalAlign="Center" UniqueName="DeleteColumn" ItemStyle-VerticalAlign="Middle"
                                                                HeaderStyle-Width="70px">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" ToolTip="click here to delete"
                                                                        CssClass="MyImageButton"><img src="../ImagesNew/Jobs/jobCloseButton.png" border="0px" alt="delete" /></asp:LinkButton>
                                                                </ItemTemplate>
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
