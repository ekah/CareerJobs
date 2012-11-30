<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HotOppsRight.ascx.cs" Inherits="Job_HotOppsRight" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<div>
    <h2 style="color: #FFFFFF;">
        Recent Opportunities</h2>
    <telerik:RadGrid ID="rgHotOpps" runat="server" AllowSorting="True" AutoGenerateColumns="False" OnItemDataBound="rgHotOpps_ItemDataBound"
        ShowHeader="false" PageSize="8" ShowStatusBar="false" GridLines="None" CellPadding="0"
        AllowPaging="true" OnNeedDataSource="rgHotOpps_NeedDataSource" ShowFooter="false">
        <MasterTableView CommandItemDisplay="none" DataKeyNames="jobid" BorderWidth="0" NoMasterRecordsText="No results matching your criteria."
            PagerStyle-Visible="false">
            <Columns>
                <telerik:GridTemplateColumn DataField="JobTitle" UniqueName="JobTitle" ItemStyle-Width="250px"
                    HeaderStyle-Width="200px" SortExpression="JobTitle">
                    <ItemTemplate>
                        <a href='Job_SearchDescription.aspx?return=1&cid=<%#Eval("ClientId") %>&JobId=<%#Eval("jobid") %>' title='<%#Eval("jobtitle") %>'
                            target="_self">
                            <asp:Label ID="lblJobTitle" runat="server" Text='<%# LearnMoreTrim(DataBinder.Eval(Container.DataItem, "jobtitle").ToString()) %>'></asp:Label>
                        </a>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                 <telerik:GridTemplateColumn DataField="country" UniqueName="country" ItemStyle-Width="210px"
                    HeaderStyle-Width="200px" SortExpression="country">
                    <ItemTemplate>
                            <asp:Label ID="lblcountry" runat="server" ToolTip='<%#Eval("country") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "country").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>  
                 <telerik:GridTemplateColumn DataField="state" UniqueName="state" ItemStyle-Width="210px"
                    HeaderStyle-Width="200px" SortExpression="state">
                    <ItemTemplate>
                            <asp:Label ID="lblstate" runat="server" ToolTip='<%#Eval("state") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "state").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>  
                 <telerik:GridTemplateColumn DataField="city" UniqueName="city" ItemStyle-Width="210px"
                    HeaderStyle-Width="200px" SortExpression="city">
                    <ItemTemplate>
                            <asp:Label ID="lblcity" runat="server" ToolTip='<%#Eval("city") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "city").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>  
                <telerik:GridTemplateColumn DataField="facility" UniqueName="facility" ItemStyle-Width="210px"
                    HeaderStyle-Width="200px" SortExpression="facility">
                    <ItemTemplate>
                            <asp:Label ID="lblfacility" runat="server" ToolTip='<%#Eval("facility") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "facility").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>    
                  <telerik:GridTemplateColumn DataField="speciality" UniqueName="speciality" ItemStyle-Width="210px"
                    HeaderStyle-Width="200px" SortExpression="speciality">
                    <ItemTemplate>
                            <asp:Label ID="lblspeciality" runat="server" ToolTip='<%#Eval("speciality") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "speciality").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>   
                 <telerik:GridTemplateColumn DataField="posteddate" UniqueName="posteddate" ItemStyle-Width="210px"
                    HeaderStyle-Width="200px" SortExpression="posteddate">
                    <ItemTemplate>
                            <asp:Label ID="lblposteddate" runat="server" ToolTip='<%#Eval("posteddate") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "posteddate").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>                      
            </Columns>
        </MasterTableView>
        <ClientSettings>
            <Scrolling AllowScroll="false" />
        </ClientSettings>
    </telerik:RadGrid>
</div>
