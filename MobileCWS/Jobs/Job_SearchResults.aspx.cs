using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;

public partial class Job_Job_SearchResults : System.Web.UI.Page
{
    public const string strjobs = "Search Results ";
    DataView dv = new DataView();
    int _pagecount = 0;
    int _clientid = 0;
    string _facility = string.Empty;
    string _speciality = string.Empty;
    string _country = string.Empty;
    string _state = string.Empty;
    string _city = string.Empty;
    string _keyword = string.Empty;
    Job_SearchResultsColVisibleBAL objSearchResultsColVisibleBAL = new Job_SearchResultsColVisibleBAL();
    Job_SearchResultsBAL objSearchResultsBAL = new Job_SearchResultsBAL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void rgSearchResults_ItemDataBound(object sender, GridItemEventArgs e)
    {

        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }

        if (e.Item is GridHeaderItem)
        {
            GridHeaderItem dataitem = (GridHeaderItem)e.Item;
            DataSet dsdisplay = objSearchResultsColVisibleBAL.SRColVisibleSelectByVisible(Convert.ToInt32(_clientid));
            if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
            {
                if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
                {
                    dataitem["country"].Visible = true;

                }
                else
                {
                    dataitem["country"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
                {
                    dataitem["state"].Visible = true;
                }
                else
                {
                    dataitem["state"].Visible = false;

                }
                if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
                {
                    dataitem["city"].Visible = true;
                }
                else
                {
                    dataitem["city"].Visible = false;
                }
                if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
                {
                    dataitem["facility"].Visible = true;
                }
                else
                {
                    dataitem["facility"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
                {
                    dataitem["speciality"].Visible = true;
                }
                else
                {
                    dataitem["speciality"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["postdate"].ToString() == "True")
                {
                    dataitem["posteddate"].Visible = true;
                }
                else
                {
                    dataitem["posteddate"].Visible = false;
                }
            }
        }

        if (e.Item is GridDataItem)
        {
            GridDataItem dataitem = (GridDataItem)e.Item;
            DataSet dsdisplay = objSearchResultsColVisibleBAL.SRColVisibleSelectByVisible(Convert.ToInt32(_clientid));
            if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
            {
                if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
                {
                    dataitem["country"].Visible = true;

                }
                else
                {
                    dataitem["country"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
                {
                    dataitem["state"].Visible = true;
                }
                else
                {
                    dataitem["state"].Visible = false;

                }
                if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
                {
                    dataitem["city"].Visible = true;
                }
                else
                {
                    dataitem["city"].Visible = false;
                }
                if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
                {
                    dataitem["facility"].Visible = true;
                }
                else
                {
                    dataitem["facility"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
                {
                    dataitem["speciality"].Visible = true;
                }
                else
                {
                    dataitem["speciality"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["postdate"].ToString() == "True")
                {
                    dataitem["posteddate"].Visible = true;
                }
                else
                {
                    dataitem["posteddate"].Visible = false;
                }
            }
        }
        if (e.Item is GridFooterItem)
        {
            GridFooterItem dataitem = (GridFooterItem)e.Item;
            DataSet dsdisplay = objSearchResultsColVisibleBAL.SRColVisibleSelectByVisible(Convert.ToInt32(_clientid));
            if (dsdisplay.Tables.Count > 0 && dsdisplay.Tables[0].Rows.Count > 0)
            {
                if (dsdisplay.Tables[0].Rows[0]["country"].ToString() == "True")
                {
                    dataitem["country"].Visible = true;

                }
                else
                {
                    dataitem["country"].Visible = false;
                }

                if (dsdisplay.Tables[0].Rows[0]["state"].ToString() == "True")
                {
                    dataitem["state"].Visible = true;
                }
                else
                {
                    dataitem["state"].Visible = false;

                }
                if (dsdisplay.Tables[0].Rows[0]["city"].ToString() == "True")
                {
                    dataitem["city"].Visible = true;
                }
                else
                {
                    dataitem["city"].Visible = false;
                }
                if (dsdisplay.Tables[0].Rows[0]["facility"].ToString() == "True")
                {
                    dataitem["facility"].Visible = true;
                }
                else
                {
                    dataitem["facility"].Visible = false;
                }
                if (dsdisplay.Tables[0].Rows[0]["speciality"].ToString() == "True")
                {
                    dataitem["speciality"].Visible = true;
                }
                else
                {
                    dataitem["speciality"].Visible = false;
                }
                if (dsdisplay.Tables[0].Rows[0]["postdate"].ToString() == "True")
                {
                    dataitem["posteddate"].Visible = true;
                }
                else
                {
                    dataitem["posteddate"].Visible = false;
                }
            }
        }
    }
    protected void rgSearchResults_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        if (!e.IsFromDetailTable)
        {
            populategrid();
        }
    }

    public string LabelDisplay()
    {
        string Pagedisplay;
        int PageIndex = rgSearchResults.CurrentPageIndex;
        _pagecount = dv.Count;
        string RecCount;
        int Pagindex;
        int RecCountPage;
        lblDisplay.Text = "";
        RecCountPage = rgSearchResults.Items.Count - 1;
        RecCount = "";
        Pagindex = PageIndex;

        if (Pagindex != rgSearchResults.PageCount - 1)
        {
            if (Pagindex == 0)
            {
                if (rgSearchResults.CurrentPageIndex == 0 && _pagecount >= rgSearchResults.PageSize)
                {
                    RecCount = Convert.ToString(PageIndex + 1) + " - " + Convert.ToString(rgSearchResults.PageSize) + " of ";
                }
                else
                {
                    RecCount = ((Pagindex * rgSearchResults.PageSize) + 1) + " - " + _pagecount + " of ";
                }
            }
            else
            {
                if (_pagecount >= rgSearchResults.PageSize)
                {
                    RecCount = ((Pagindex * rgSearchResults.PageSize) + 1) + " - " + _pagecount + " of ";
                }
                else
                {
                    RecCount = ((Pagindex * rgSearchResults.PageSize) + 1) + " - " + ((Pagindex + 1) * rgSearchResults.PageSize) + " of ";
                }
            }
        }
        else
        {


            if (rgSearchResults.CurrentPageIndex == 0 && _pagecount >= rgSearchResults.PageSize)
            {
                RecCount = Convert.ToString(PageIndex + 1) + " - " + Convert.ToString(rgSearchResults.PageSize) + " of ";
            }
            else
            {
                RecCount = ((Pagindex * rgSearchResults.PageSize) + 1) + " - " + _pagecount + " of ";

            }

        }
        Pagedisplay = RecCount + _pagecount;
        return Pagedisplay;

    }

    public void PageButtons(ImageButton ImgNext, ImageButton ImgBack)
    {
        int PageIndex = rgSearchResults.CurrentPageIndex;
        _pagecount = dv.Count;

        if (rgSearchResults.PageCount < 1)
        {
            ImgNext.Visible = false;
            ImgBack.Visible = false;
        }
        else if (rgSearchResults.CurrentPageIndex == 0 && rgSearchResults.PageCount >= 1 && _pagecount <= rgSearchResults.PageSize)
        {
            ImgNext.Visible = false;
            ImgBack.Visible = false;
        }
        else if (rgSearchResults.CurrentPageIndex > 0 && rgSearchResults.PageCount >= 1 && _pagecount >= rgSearchResults.PageSize)
        {
            ImgNext.Visible = false;
            ImgBack.Visible = true;
        }
        else if (PageIndex <= 0 && _pagecount >= rgSearchResults.PageSize)
        {
            ImgNext.Visible = true;
            ImgBack.Visible = false;
        }
        else if (PageIndex == 0 && _pagecount == rgSearchResults.PageSize)
        {
            ImgNext.Visible = false;
            ImgBack.Visible = false;
        }
        else if (PageIndex == rgSearchResults.PageCount - 1)
        {
            ImgNext.Visible = false;
            ImgBack.Visible = true;
        }
        else
        {
            ImgNext.Visible = true;
            ImgBack.Visible = true;
        }
    }
    public void populategrid()
    {
        DataSet dsresults = new DataSet();       
            if (Request.QueryString.Count > 0)
            {
                _facility = Request.QueryString["facility"].ToString();
                _speciality = Request.QueryString["speciality"].ToString();
                 _country = Request.QueryString["country"].ToString();
                 _state = Request.QueryString["state"].ToString();
                _city = Request.QueryString["city"].ToString();
                _keyword = Request.QueryString["keyword"].ToString();
                if (Request.QueryString["cid"] != null)
                {
                    if (Request.QueryString["cid"].ToString() != string.Empty)
                    {
                        Session["clientId"] = Request.QueryString["cid"].ToString();
                        _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                    }
                }

                dsresults = objSearchResultsBAL.SearchResults(_clientid, _facility, _speciality, _country,_state,_city, _keyword);

                if (dsresults.Tables.Count > 0 && dsresults.Tables[0].Rows.Count > 0)
                {
                    dv = dsresults.Tables[0].DefaultView;


                    if (this.ViewState["SortExp"] != null)
                    {
                        dv.Sort = this.ViewState["SortExp"].ToString();
                    }

                    lblnorecords.Visible = false;
                    divnorecords.Visible = false;
                    rgSearchResults.DataSource = dv;
                    string dismsg = LabelDisplay();
                    lblDisplay.Text = strjobs + dismsg;
                    PageButtons(ImgNext, ImgBack);

                }
                else
                {
                    lblnorecords.Visible = true;
                    divnorecords.Visible = true;
                    rgSearchResults.DataSource = null;
                    lblnorecords.Text = "No Records Found!";
                    ImgBack.Visible = false;
                    ImgNext.Visible = false;
                }
            }
            else
            {
                if (Session["PageIndex"] != null)
                {
                    int PageIndex = Convert.ToInt32(Session["PageIndex"].ToString());
                    rgSearchResults.CurrentPageIndex = PageIndex;
                }

                if (Session["facility"] != null)
                {
                    _facility = Session["facility"].ToString();
                }

                if (Session["speciality"] != null)
                {
                    _speciality = Session["speciality"].ToString();
                }

                if (Session["country"] != null)
                {
                    _country = Session["country"].ToString();
                }

                if (Session["state"] != null)
                {
                    _state = Session["state"].ToString();
                }


                if (Session["city"] != null)
                {
                    _city = Session["city"].ToString();
                }
               


                if (Session["keyword"] != null)
                {
                    _keyword = Session["keyword"].ToString();
                }

                if (Session["clientId"] != null)
                {
                    _clientid = Convert.ToInt32(Session["clientId"].ToString());
                }

                dsresults = objSearchResultsBAL.SearchResults(_clientid, _facility, _speciality, _country,_state,_city, _keyword);

                if (dsresults.Tables.Count > 0 && dsresults.Tables[0].Rows.Count > 0)
                {
                    dv = dsresults.Tables[0].DefaultView;


                    if (this.Session["SortExp"] != null)
                    {
                        dv.Sort = this.Session["SortExp"].ToString();
                    }

                    lblnorecords.Visible = false;
                    divnorecords.Visible = false;
                    rgSearchResults.DataSource = dv;
                    string dismsg = LabelDisplay();
                    lblDisplay.Text = strjobs + dismsg;
                    PageButtons(ImgNext, ImgBack);

                }
                else
                {
                    lblnorecords.Visible = true;
                    divnorecords.Visible = true;
                    rgSearchResults.DataSource = null;
                    lblnorecords.Text = "No Records Found";
                    ImgBack.Visible = false;
                    ImgNext.Visible = false;
                }
            }      
    }
    protected void ImgBack_Click(object sender, ImageClickEventArgs e)
    {
        if (Convert.ToInt32(rgSearchResults.CurrentPageIndex) >= 1)
        {
            if (rgSearchResults.CurrentPageIndex <= 1)
            {
                ImgBack.Visible = false;
                ImgNext.Visible = true;
            }

            Session["PageIndex"] = rgSearchResults.CurrentPageIndex - 1;
            rgSearchResults.CurrentPageIndex = rgSearchResults.CurrentPageIndex - 1;
            rgSearchResults.Rebind();

        }
    }
    protected void ImgNext_Click(object sender, ImageClickEventArgs e)
    {
        if ((rgSearchResults.CurrentPageIndex + 2) >= rgSearchResults.PageCount)
        {
            ImgNext.Visible = false;
        }
        Session["PageIndex"] = rgSearchResults.CurrentPageIndex + 1;
        rgSearchResults.CurrentPageIndex = rgSearchResults.CurrentPageIndex + 1;
        rgSearchResults.Rebind();
    }
}
