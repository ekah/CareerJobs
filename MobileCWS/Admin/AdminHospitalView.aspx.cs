using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;
using System.Data;
using System.IO;

public partial class Admin_AdminHospitalView : System.Web.UI.Page
{
    protected string _HospitalAdminName = "---";
    protected string _HospitalAdminEmail = "---";
    protected string _HospitalAdminMobile = "---";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminLogin"] == null)
            Response.Redirect("AdminIndex.aspx");

        if (!IsPostBack)
        {
            DefaultSettings();
        }
    }

    private void DefaultSettings()
    {
        trHospitalAdminDetail.Visible = false;
        trHospitalAdminView.Visible = false;
        BindHospital();
    }

    private void BindHospital()
    {
        DataTable dtHospital = new AdministrationBAL().GetHospitalList();

        foreach (DataRow dr in dtHospital.Rows)
        {
            dr["OrganizationName"] += " (";
            dr["OrganizationName"] += dr["CountryName"].ToString();
            dr["OrganizationName"] += (!string.IsNullOrEmpty(dr["StateName"].ToString())) ? ", " + dr["StateName"].ToString() : string.Empty;
            dr["OrganizationName"] += (!string.IsNullOrEmpty(dr["CityName"].ToString())) ? ", " + dr["CityName"].ToString() : string.Empty;
            dr["OrganizationName"] += ")";
        }
        dtHospital.AcceptChanges();

        ddlHospitalView.DataSource = dtHospital;
        ddlHospitalView.DataTextField = "OrganizationName";
        ddlHospitalView.DataValueField = "OrganizationId";
        ddlHospitalView.DataBind();

        //ddlHospitalView.Items.Insert(0, new ListItem("-------------------------------------Select   Hospital-----------------------------------------------", "0"));
        //ddlHospitalView.SelectedIndex = 0;
    }

    private void BindAdminDetail()
    {
        try
        {
            DataTable dtAdminHospitalDetail = new AdministrationBAL().GetOrganizationByOrganizationId(Convert.ToInt32(ddlHospitalView.SelectedValue));
            if (dtAdminHospitalDetail.Rows.Count > 0)
            {
                _HospitalAdminName = dtAdminHospitalDetail.Rows[0]["AdminName"].ToString();
                _HospitalAdminEmail = dtAdminHospitalDetail.Rows[0]["EmailId"].ToString();
                _HospitalAdminMobile = dtAdminHospitalDetail.Rows[0]["MobileId"].ToString();
            }
        }
        catch
        {
        }
    }

    protected string GetUrl()
    {
        return SiteBAL.GetURL();
    }

    private void BindDoctorService(bool isBind)
    {
        try
        {
            rgAdminHospitalView.DataSource = new AdministrationBAL().GetDoctorServiceByOrganizationId(Convert.ToInt32(ddlHospitalView.SelectedValue));

            if (!isBind)
                rgAdminHospitalView.DataBind();
        }
        catch
        {
        }
    }


    protected void rgAdminHospitalView_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
    {
        BindDoctorService(true);
    }

    protected void rgAdminHospitalView_ActivateCommand(object source, GridCommandEventArgs e)
    {
    }

    protected void rgAdminHospitalView_ItemDataBound(object sender, GridItemEventArgs e)
     {
        BindAdminDetail();

        if (e.Item.ItemType == GridItemType.Item || e.Item.ItemType == GridItemType.AlternatingItem)
        {
            GridDataItem dataItem = e.Item as GridDataItem;
            Session["SignInId"] = null;

            string strImageName = (dataItem["Thumbnail"].FindControl("lblImageName") as Label).Text;
            Image imgThumbnail = dataItem["Thumbnail"].FindControl("imgThumbnail") as Image;

            if (!String.IsNullOrEmpty(strImageName) && strImageName.ToString() != "NoPhoto.gif")
            {
                imgThumbnail.ImageUrl = "~/Photo/" + strImageName;
            }
            else
            {
                imgThumbnail.ImageUrl = @"~/Photo/NoPhoto.gif";
            }
        }

        if (e.Item is GridPagerItem)
        {
            RadComboBox PageSizeCombo = (RadComboBox)e.Item.FindControl("PageSizeComboBox");

            PageSizeCombo.Items.Clear();
            PageSizeCombo.Items.Add(new RadComboBoxItem("50"));
            PageSizeCombo.FindItemByText("50").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("100"));
            PageSizeCombo.FindItemByText("100").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("200"));
            PageSizeCombo.FindItemByText("200").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("300"));
            PageSizeCombo.FindItemByText("300").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("400"));
            PageSizeCombo.FindItemByText("400").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("500"));
            PageSizeCombo.FindItemByText("500").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("750"));
            PageSizeCombo.FindItemByText("750").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);

            PageSizeCombo.Items.Add(new RadComboBoxItem("1000"));
            PageSizeCombo.FindItemByText("1000").Attributes.Add("ownerTableViewId", rgAdminHospitalView.MasterTableView.ClientID);
            PageSizeCombo.FindItemByText(e.Item.OwnerTableView.PageSize.ToString()).Selected = true;
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        trHospitalAdminDetail.Visible = true;
        trHospitalAdminView.Visible = true;
        BindDoctorService(false);
        BindAdminDetail();

        if (ddlHospitalView.SelectedItem != null)
            btnAdminAccess.NavigateUrl = GetUrl() + "Default.aspx?user=" + _HospitalAdminEmail + "&type=5&orgid=0&accountid=" + ddlHospitalView.SelectedItem.Value;
        else
            btnAdminAccess.NavigateUrl = "#";
    }
}