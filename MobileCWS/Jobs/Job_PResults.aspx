<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/HrMasterPage.Master"
    CodeFile="Job_PResults.aspx.cs" Inherits="Jobs_Job_PResults" %>

<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
<!--
.jobContTopBg{height:55px; background:url(../ImagesNew/jobs/jobPrResultPageTopBg.jpg) no-repeat left top;}
#lnkPrev{font-weight:bold; margin:0 5px 0 0; color:#333333!important;}
#lnkNext{font-weight:bold; margin:0 0 0 5px; color:#333333!important; }
#ctl00_MainContent_lnkNext{color:#333333; font-weight:bold;}
#ctl00_MainContent_lnkPrev{color:#333333; font-weight:bold;}
#ctl00_MainContent_lblstart{color:#333;}
.Hystatus a{color:#FF6600!important; font-weight:bold;}
.Hystatus a:hover{ text-decoration:none;}
#lblCreatedDate{color:#8F8F8F;}
#lblCreatedDate{color:#8F8F8F;}
.shareThis{float:left} 
.shareThis a{color:#005aa0!important; font-weight:bold; background:url("../ImagesNew/jobs/blocks-redarrow.jpg") no-repeat scroll left 4px transparent; padding:0 0 0 15px;}
.shareThis a:hover{ text-decoration:none;}
-->
</style>
    <div id="container">
        <!--content start -->
        <div class="content">
            <div class="fullWidthLeftPane">
                <div class="fullWidthPageCenterBg">
                    <div class="fullWidthPageTopbg">
                        <div class="fullWidthPageBottompbg">
                            <!--content Start -->
                            <div class="fullWidthPageContent">
                                <h3>
                                    Jobs by Hospital</h3>
                                <div style="width: 611px; margin: 0 auto;">
                                    <div class="jobContTopBg">
                                    </div>
                                    <div style="background: #fff; border: #3898e2 1px solid; padding: 20px; border-top: none;">
                                        <div style="text-align: right; padding: 0 0 10px 0;">
                                            <asp:LinkButton ID="lnkPrev" runat="server" Text="« Previous" OnClick="lnkPrev_Click"></asp:LinkButton>
                                            <asp:Label ID="lblstart" runat="server" Text="1 - 13 out of 13"></asp:Label>
                                            <asp:LinkButton ID="lnkNext" runat="server" Text=" Next »" OnClick="lnkNext_Click"></asp:LinkButton>
                                        </div>
                                        <div>
                                            <asp:GridView ID="grdResults" runat="server" AutoGenerateColumns="False" GridLines="None"
                                                AllowSorting="True" RowStyle-Wrap="true" AllowPaging="True" EmptyDataText="Please visit us often, as new opportunities are posted daily."
                                                PageSize="10" CellPadding="0" Width="100%" ForeColor="#333333">
                                                <Columns>
                                                    <asp:TemplateField SortExpression="JobTitle">
                                                        <ItemTemplate>
                                                            <div style="border: 1px solid #c9c9c9; margin: 0 0 10px 0; padding: 10px; background-color: #f5f3f2;">
                                                                <div class="Hystatus">
                                                                    <asp:HyperLink ID="Hystatus" runat="server" NavigateUrl='<%# "Job_PDescription.aspx?cid=" + DataBinder.Eval(Container.DataItem,"ClientId") + "&jobid=" + DataBinder.Eval(Container.DataItem,"Jobid")%>'
                                                                        Text='<%# DataBinder.Eval(Container.DataItem, "JobTitle")%>'></asp:HyperLink>
                                                                    <asp:Label ID="lblCreatedDate" runat="server" Text='<%# Eval("CreatedDate") %>'></asp:Label>
                                                                </div>
                                                                <div>
                                                                    <asp:Label ID="lblCompanyName" Font-Bold="true" runat="server" Text='<%# Eval("Client") + "," %>'></asp:Label>
                                                                    <%-- <asp:Label ID="lblCountry" Font-Bold="true" Font-Size="12px" runat="server" Text='<%# Eval("Country") + "," + Eval("State") + "," + Eval("City")   %>'></asp:Label><br /> --%>
                                                                    <asp:Label ID="lbldescription" Font-Size="12px" runat="server" Text='<%# Eval("Description")  %>'></asp:Label><br />
                                                                </div>
                                                                <div class="shareThis" style="margin: 0 10px 0 0;">
                                                                    <a href='<%# "Job_PSendToFriend.aspx?cid=" + DataBinder.Eval(Container.DataItem,"ClientId") + "&jobid=" + DataBinder.Eval(Container.DataItem,"Jobid")%>'>
                                                                        Share this job</a></div>
                                                                <div class="shareThis">
                                                                    <a href='<%# "Job_PApply.aspx?cid=" + DataBinder.Eval(Container.DataItem,"ClientId") + "&jobid=" + DataBinder.Eval(Container.DataItem,"Jobid")%>'>
                                                                        Apply</a></div>
                                                                <div class="clear">
                                                                </div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <PagerSettings Visible="false" />
                                                <RowStyle HorizontalAlign="Left" Wrap="True" />
                                                <EditRowStyle BackColor="#2461BF" />
                                            </asp:GridView>
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
</asp:Content>
