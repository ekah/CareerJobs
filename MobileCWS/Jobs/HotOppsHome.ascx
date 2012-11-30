<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HotOppsHome.ascx.cs" Inherits="Job_HotOppsHome" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
   <style type="text/css">
         .RadGrid_Default{background:none!important; }
         .RadGrid_Default{border:none!important;}
         .textDecoration .RadGrid_Default .rgRow a, .RadGrid_Default .rgAltRow a, .RadGrid_Default .rgEditRow a, .RadGrid_Default tr.rgEditRow a, .RadGrid_Default tr.rgHoveredRow a, .RadGrid_Default tr.rgActiveRow a, .RadGrid_Default .rgFooter a, .RadGrid_Default .rgEditForm a{ text-decoration:underline!important; color:#ffffff!important;}
       
   </style>
<div class="textDecoration" style="width:280px; margin:0 auto;">
    <h2 style="color: #FFFFFF;">
        Recent Opportunities</h2>
    <telerik:RadGrid ID="rgHotOpps" runat="server" AllowSorting="True" AutoGenerateColumns="False" OnItemDataBound="rgHotOpps_ItemDataBound"
        ShowHeader="false" PageSize="8" ShowStatusBar="false" GridLines="None" CellPadding="0" 
        AllowPaging="true" OnNeedDataSource="rgHotOpps_NeedDataSource" ShowFooter="false">
        <MasterTableView CommandItemDisplay="none" DataKeyNames="jobid" BorderWidth="0" NoMasterRecordsText="No results matching your criteria."
            PagerStyle-Visible="false">
            <Columns>
                <telerik:GridTemplateColumn DataField="JobTitle" UniqueName="JobTitle" ItemStyle-Width="25%"
                    HeaderStyle-Width="200px" SortExpression="JobTitle">
                    <ItemTemplate>
                   
                        <a href='Jobs/Job_SearchDescription.aspx?return=1&cid=<%#Eval("ClientId") %>&JobId=<%#Eval("jobid") %>' title='Click here to view details' style="text-decoration:none;"
                            target="_self">
                            <asp:Label ID="lblJobTitle"  runat="server" style="color:#fff;"  Text='<%# LearnMoreTrim(DataBinder.Eval(Container.DataItem, "jobtitle").ToString()) %>'></asp:Label>
                         
                        </a>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                 <telerik:GridTemplateColumn DataField="country" UniqueName="country" ItemStyle-Width="25%"  
                    HeaderStyle-Width="200px" SortExpression="country">
                    <ItemTemplate>
                            <asp:Label ID="lblcountry" runat="server" style="color:#fff;" ToolTip='<%#Eval("country") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "country").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>  
                 <telerik:GridTemplateColumn DataField="state" UniqueName="state" ItemStyle-Width="25%"
                    HeaderStyle-Width="200px" SortExpression="state">
                    <ItemTemplate>
                            <asp:Label ID="lblstate" runat="server" style="color:#fff;" ToolTip='<%#Eval("state") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "state").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>  
                 <telerik:GridTemplateColumn DataField="city" UniqueName="city" ItemStyle-Width="25%"
                    HeaderStyle-Width="200px" SortExpression="city">
                    <ItemTemplate>
                            <asp:Label ID="lblcity" runat="server" style="color:#fff;" ToolTip='<%#Eval("city") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "city").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>  
                <telerik:GridTemplateColumn DataField="facility" UniqueName="facility" ItemStyle-Width="25%"
                    HeaderStyle-Width="200px" SortExpression="facility">
                    <ItemTemplate>
                            <asp:Label ID="lblfacility" runat="server" style="color:#fff;" ToolTip='<%#Eval("facility") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "facility").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>    
                  <telerik:GridTemplateColumn DataField="speciality" UniqueName="speciality" ItemStyle-Width="40%" 
                    HeaderStyle-Width="200px" SortExpression="speciality">
                    <ItemTemplate>
                            <asp:Label ID="lblspeciality" runat="server" style="color:#fff;" ToolTip='<%#Eval("speciality") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "speciality").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>   
                 <telerik:GridTemplateColumn DataField="posteddate" UniqueName="posteddate" ItemStyle-Width="25%"
                    HeaderStyle-Width="200px" SortExpression="posteddate">
                    <ItemTemplate>
                            <asp:Label ID="lblposteddate" runat="server" style="color:#fff;" ToolTip='<%#Eval("posteddate") %>' Text='<%# LearnMoreTrim1(DataBinder.Eval(Container.DataItem, "posteddate").ToString()) %>'></asp:Label>                       
                    </ItemTemplate>
                </telerik:GridTemplateColumn>                      
            </Columns>
        </MasterTableView>
        <ClientSettings>
            <Scrolling AllowScroll="false" />
        </ClientSettings>
    </telerik:RadGrid>
</div>
