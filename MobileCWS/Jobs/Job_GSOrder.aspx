<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Jobs/HrMasterPage.Master" CodeFile="Job_GSOrder.aspx.cs" Inherits="Jobs_Job_GSOrder" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="ct_adminjobs" ContentPlaceHolderID="MainContent" runat="server">
 <style>
        .fullWidthPageTopbg .fullWidthPageContent h3{width:500px; float:left;}
        .headerLink{float:right; font-style:italic; line-height:95px; color:#fff; font-weight:bold;}
        .headerLink a{color:#fff;}
        .headerLink a:hover{text-decoration:none;}
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
                                    Jobs by Speciality
                                </h3>
                                <p class="headerLink"><a href="Job_AllHospital.aspx">By Hospital</a></p>
                                <div class="clear"></div>
                                <table id="YahooTab" width="700" cellspacing="0" cellpadding="0" border="0">
                                    <tbody>
                                        <tr>
                                            <td>
                                                &nbsp;
                                            </td>
                                            <td valign="top" align="center">
                                                <table width="100%" cellspacing="0" cellpadding="0" border="0">
                                                    <tbody>
                                                        <tr>
                                                            <td valign="top" height="30" class="profileTab">
                                                                <table width="100%" cellspacing="0" cellpadding="0" border="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td valign="top" height="7">
                                                                                <div style="float: left; background: url(../ImagesNew/Jobs/icon.png) -47px 0px; width: 4px;
                                                                                    height: 4px;">
                                                                                    <img width="4px" height="4px" src="../ImagesNew/Jobs/trans.gif"></div>
                                                                                <div style="float: right; background: url(../ImagesNew/Jobs/icon.png) -51px 0px;
                                                                                    width: 4px; height: 4px;">
                                                                                    <img width="4px" height="4px" src="../ImagesNew/Jobs/trans.gif"></div>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td valign="bottom" class="txt_white" style="padding: 0px 10px 0px 10px; text-align: left;">
                                                                                <span class="txt_13 txt_white">&nbsp;Jobs by <span class="bold">Speciality</span></span>
                                                                                &nbsp;&nbsp;&nbsp;- Click the alphabet you wish to see Speciality of -
                                                                                <img width="1" height="7" src="../ImagesNew/Jobs/trans.gif">
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                                <!-- other window -->
                                                                <div id="other" class="border_darkgreen" style="float: left; position: absolute;
                                                                    width: 559px; margin: -30px 0px 0px 0px; *margin: -30px 0px 0px -280px; display: none;">
                                                                    <!-- other window end -->
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td width="24" valign="top" align="right">
                                                <table width="24" cellspacing="0" cellpadding="0" border="0">
                                                    <tbody>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_AllSpeciality.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                             
                                                                    <img width="13" hspace="0" height="12" border="0" src="../ImagesNew/Jobs/icon_home.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_ASOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                A
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_BSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                B
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_CSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                C
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_DSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                D
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_ESOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                E
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_FSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                F
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" class="bg_green border_green">
                                                                G
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_HSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                H
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_ISOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                I
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_JSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                J
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_KSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                K
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_LSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                L
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_MSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                M
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_NSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                N
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_OSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                O
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_PSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                P
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_QSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                Q
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_RSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                R
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_SSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                S
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_TSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                T
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_USOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                U
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_VSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                V
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_WSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                W
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_XSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                X
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_YSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                Y
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td width="30" height="20" align="center" onclick="document.location='Job_ZSOrder.aspx'"
                                                                onmouseout="this.className='bg_lightgreen3 border_green'" onmouseover="this.className='bg_green border_green txt_white'"
                                                                style="cursor: pointer; border-right: none;" class="bg_lightgreen3 border_green">
                                                                Z
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center">
                                                                <img width="1" height="4" src="../ImagesNew/Jobs/trans.gif">
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                            <td valign="top" align="center" style="padding-left: none;" class="border_green">
                                                <table width="100%" cellspacing="0" cellpadding="10" border="0">
                                                    <tbody>
                                                        <tr>
                                                            <td class="bg_grey" style="font-weight: bold;">
                                                                Speciality starting with: <span class="txt_16 bold">G</span>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                                <table width="100%" style="padding: 15px; text-align: left;" cellspacing="0" cellpadding="0">
                                                    <tr>
                                                        <td>
                                                            <p>
                                                                <asp:Repeater runat="server" ID="rpJobList" onitemdatabound="rpJobList_ItemDataBound">
                                                                    <ItemTemplate>
                                                                        <div style="position: relative;">
                                                                            <ul>
                                                                                <li id="licolor" runat="server">
                                                                                    <asp:Label Visible="false" ID="lblstatus" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Status")%>'></asp:Label>
                                                                                    <asp:HyperLink ID="Hystatus" runat="server" NavigateUrl='<%# "Job_PClientResults.aspx?did=" + DataBinder.Eval(Container.DataItem,"DepartmentId")%>'
                                                                                    Text='<%# DataBinder.Eval(Container.DataItem, "DepartmentName")%>'></asp:HyperLink>                                                                                  
                                                                                </li>
                                                                            </ul>
                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:Repeater>
                                                            </p>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

