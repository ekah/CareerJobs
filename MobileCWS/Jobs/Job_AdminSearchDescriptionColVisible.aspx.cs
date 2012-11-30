using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using Telerik.Web.UI;
using System.Text;

public partial class Jobs_Job_AdminSearchDescriptionColVisible : System.Web.UI.Page
{
    Job_SearchDescriptionColVisibleBAL objSearchDescriptionColVisibleBAL = new Job_SearchDescriptionColVisibleBAL();
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    int _SdId = 0;
    int _clientid = 0;
    bool _jobidbool = false;
    bool _jobtitlebool = false;
    bool _countrybool = false;
    bool _statebool = false;
    bool _citybool = false;
    bool _facilitybool = false;
    bool _specialitybool = false;
    bool _descriptionbool = false;
    bool _postdatebool = false;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("../Admin/AdminIndex.aspx");
        }
    }
    protected void rgSdjobs_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rgSdjobs.DataSource = GridDataSource();
    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet();       
        ds = objSearchDescriptionColVisibleBAL.SDColVisibleSelectByVisibleAll();        
        return ds;
    }
    protected void rgSdjobs_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridEditableItem edititem = e.Item as GridEditableItem;
        _SdId = Convert.ToInt32(edititem.OwnerTableView.DataKeyValues[edititem.ItemIndex]["SdId"].ToString());
        RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
        CheckBox chkVisibiltyJobId = (CheckBox)edititem.FindControl("chkVisibiltyJobId");
        CheckBox chkVisibiltyJobTitle = (CheckBox)edititem.FindControl("chkVisibiltyJobTitle");
        CheckBox chkVisibiltyCountry = (CheckBox)edititem.FindControl("chkVisibiltyCountry");
        CheckBox chkVisibiltyState = (CheckBox)edititem.FindControl("chkVisibiltyState");
        CheckBox chkVisibiltyCity = (CheckBox)edititem.FindControl("chkVisibiltyCity");
        CheckBox chkVisibiltyFacility = (CheckBox)edititem.FindControl("chkVisibiltyFacility");
        CheckBox chkVisibiltySpeciality = (CheckBox)edititem.FindControl("chkVisibiltySpeciality");
        CheckBox chkVisibiltyDescription = (CheckBox)edititem.FindControl("chkVisibiltyDescription");
        CheckBox chkVisibiltyPostDate = (CheckBox)edititem.FindControl("chkVisibiltyPostDate");
        if (rcbclient.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Client");
        }
        else
        {
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);
            _whocreated = string.Empty;          
            if (Session["SignInId"] != null)
            {
                _whoupdated = Session["SignInId"].ToString();
            }
            int _count = 0;
            if (chkVisibiltyJobId.Checked)
            {
                _count += 1;
                _jobidbool = true;
            }
            if (chkVisibiltyJobTitle.Checked)
            {
                _count += 1;
                _jobtitlebool = true;
            }
            if (chkVisibiltyCountry.Checked)
            {
                _count += 1;
                _countrybool = true;
            }
            if (chkVisibiltyState.Checked)
            {
                _count += 1;
                _statebool = true;
            }
            if (chkVisibiltyCity.Checked)
            {
                _count += 1;
                _citybool = true;
            }
            if (chkVisibiltyFacility.Checked)
            {
                _count += 1;
                _facilitybool = true;
            }
            if (chkVisibiltySpeciality.Checked)
            {
                _count += 1;
                _specialitybool = true;
            }
            if (chkVisibiltyDescription.Checked)
            {
                _count += 1;
                _descriptionbool = true;
            }
            if (chkVisibiltyPostDate.Checked)
            {
                _count += 1;
                _postdatebool = true;
            }
            if (_count < 1)
            {
                ShowPopUpMsg("Please select atleast one");
            }
            else
            {
                objSearchDescriptionColVisibleBAL.InsertUpdateSDColVisible(_SdId, _jobidbool, _jobtitlebool, _facilitybool, _specialitybool, _countrybool, _statebool, _citybool, _descriptionbool, _postdatebool, _clientid, _whocreated, _whoupdated);
            }
            
        }
    }
    protected void rgSdjobs_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;
        _SdId = 0;
        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
        CheckBox chkVisibiltyJobId = (CheckBox)item.FindControl("chkVisibiltyJobId");
        CheckBox chkVisibiltyJobTitle = (CheckBox)item.FindControl("chkVisibiltyJobTitle");
        CheckBox chkVisibiltyCountry = (CheckBox)item.FindControl("chkVisibiltyCountry");
        CheckBox chkVisibiltyState = (CheckBox)item.FindControl("chkVisibiltyState");
        CheckBox chkVisibiltyCity = (CheckBox)item.FindControl("chkVisibiltyCity");
        CheckBox chkVisibiltyFacility = (CheckBox)item.FindControl("chkVisibiltyFacility");
        CheckBox chkVisibiltySpeciality = (CheckBox)item.FindControl("chkVisibiltySpeciality");
        CheckBox chkVisibiltyDescription = (CheckBox)item.FindControl("chkVisibiltyDescription");
        CheckBox chkVisibiltyPostDate = (CheckBox)item.FindControl("chkVisibiltyPostDate");
        if (rcbclient.SelectedValue == "--Select--")
        {
            ShowPopUpMsg("Please Select Client");
        }
        else
        {
            _clientid = Convert.ToInt32(rcbclient.SelectedValue);          
            if (Session["SignInId"] != null)
            {
                _whocreated = Session["SignInId"].ToString();
            }
            _whoupdated = string.Empty;
            int _count = 0;
            if (chkVisibiltyJobId.Checked)
            {
                _count += 1;
                _jobidbool = true;
            }
            if (chkVisibiltyJobTitle.Checked)
            {
                _count += 1;
                _jobtitlebool = true;
            }
            if (chkVisibiltyCountry.Checked)
            {
                _count += 1;
                _countrybool = true;
            }
            if (chkVisibiltyState.Checked)
            {
                _count += 1;
                _statebool = true;
            }
            if (chkVisibiltyCity.Checked)
            {
                _count += 1;
                _citybool = true;
            }
            if (chkVisibiltyFacility.Checked)
            {
                _count += 1;
                _facilitybool = true;
            }
            if (chkVisibiltySpeciality.Checked)
            {
                _count += 1;
                _specialitybool = true;
            }
            if (chkVisibiltyDescription.Checked)
            {
                _count += 1;
                _descriptionbool = true;
            }
            if (chkVisibiltyPostDate.Checked)
            {
                _count += 1;
                _postdatebool = true;
            }

            if (_count < 1)
            {
                ShowPopUpMsg("Please select atleast one");
            }
            else
            {
                objSearchDescriptionColVisibleBAL.InsertUpdateSDColVisible(_SdId, _jobidbool, _jobtitlebool, _facilitybool, _specialitybool, _countrybool, _statebool, _citybool, _descriptionbool, _postdatebool, _clientid, _whocreated, _whoupdated);
            }
        }
    }
    private void ShowPopUpMsg(string msg)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("alert('");
        sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("'", "\\'"));
        sb.Append("');");
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
    }
    protected void rgSdjobs_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {

            GridDataItem dataitem = (GridDataItem)e.Item;

            Label lbJobId = (Label)dataitem.FindControl("lbJobId");
            Image imgVisibilityJobId = (Image)dataitem.FindControl("imgVisibilityJobId");

            if (lbJobId.Text == "True")
            {
                imgVisibilityJobId.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityJobId.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbJobTitle = (Label)dataitem.FindControl("lbJobTitle");
            Image imgVisibilityJobTitle = (Image)dataitem.FindControl("imgVisibilityJobTitle");

            if (lbJobTitle.Text == "True")
            {
                imgVisibilityJobTitle.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityJobTitle.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbCountry = (Label)dataitem.FindControl("lbCountry");
            Image imgVisibilityCountry = (Image)dataitem.FindControl("imgVisibilityCountry");

            if (lbCountry.Text == "True")
            {
                imgVisibilityCountry.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityCountry.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbState = (Label)dataitem.FindControl("lbState");
            Image imgVisibilityState = (Image)dataitem.FindControl("imgVisibilityState");

            if (lbState.Text == "True")
            {
                imgVisibilityState.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityState.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbCity = (Label)dataitem.FindControl("lbCity");
            Image imgVisibilityCity = (Image)dataitem.FindControl("imgVisibilityCity");


            if (lbCity.Text == "True")
            {
                imgVisibilityCity.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityCity.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbFacility = (Label)dataitem.FindControl("lbFacility");
            Image imgVisibilityFacility = (Image)dataitem.FindControl("imgVisibilityFacility");


            if (lbFacility.Text == "True")
            {
                imgVisibilityFacility.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityFacility.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbSpeciality = (Label)dataitem.FindControl("lbSpeciality");
            Image imgVisibilitySpeciality = (Image)dataitem.FindControl("imgVisibilitySpeciality");


            if (lbSpeciality.Text == "True")
            {
                imgVisibilitySpeciality.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilitySpeciality.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbDescription = (Label)dataitem.FindControl("lbDescription");
            Image imgVisibilityDescription = (Image)dataitem.FindControl("imgVisibilityDescription");


            if (lbDescription.Text == "True")
            {
                imgVisibilityDescription.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityDescription.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

            Label lbPostDate = (Label)dataitem.FindControl("lbPostDate");
            Image imgVisibilityPostDate = (Image)dataitem.FindControl("imgVisibilityPostDate");


            if (lbPostDate.Text == "True")
            {
                imgVisibilityPostDate.ImageUrl = "../ImagesNew/Jobs/green-tick-mark.gif";
            }
            else
            {
                imgVisibilityPostDate.ImageUrl = "../ImagesNew/Jobs/red_x_mark.png";
            }

        }


        if (e.Item is GridEditFormInsertItem)
        {
            GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;

            RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
            DataSet dsclient = objJobsBAL.SelectOrganizationBasedOnFacility();

            if (dsclient.Tables.Count > 0 && dsclient.Tables[0].Rows.Count > 0)
            {
                rcbclient.DataSource = dsclient;
                rcbclient.DataTextField = "Client";
                rcbclient.DataValueField = "OrganizationId";
                rcbclient.DataBind();
            }


            RadComboBoxItem asclientListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbclient.Items.Insert(0, asclientListItem);
        }

        if ((e.Item is GridEditableItem) && (e.Item.IsInEditMode) && (!e.Item.OwnerTableView.IsItemInserted))
        {
            GridEditableItem edititem = (GridEditableItem)e.Item;

            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");
            DataSet dsclient = objJobsBAL.SelectOrganizationBasedOnFacility();

            if (dsclient.Tables.Count > 0 && dsclient.Tables[0].Rows.Count > 0)
            {
                rcbclient.DataSource = dsclient;
                rcbclient.DataTextField = "Client";
                rcbclient.DataValueField = "OrganizationId";
                rcbclient.DataBind();
            }


            RadComboBoxItem asclientListItem = new RadComboBoxItem("--Select--", "--Select--");
            rcbclient.Items.Insert(0, asclientListItem);

            rcbclient.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[10].ToString();
            rcbclient.Enabled = false;
            CheckBox chkVisibiltyJobId = (CheckBox)edititem.FindControl("chkVisibiltyJobId");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[1].ToString() == "True")
            {
                chkVisibiltyJobId.Checked = true;
            }
            else
            {
                chkVisibiltyJobId.Checked = false;
            }

            CheckBox chkVisibiltyJobTitle = (CheckBox)edititem.FindControl("chkVisibiltyJobTitle");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[2].ToString() == "True")
            {
                chkVisibiltyJobTitle.Checked = true;
            }
            else
            {
                chkVisibiltyJobTitle.Checked = false;
            }


            CheckBox chkVisibiltyCountry = (CheckBox)edititem.FindControl("chkVisibiltyCountry");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[5].ToString() == "True")
            {
                chkVisibiltyCountry.Checked = true;
            }
            else
            {
                chkVisibiltyCountry.Checked = false;
            }

            CheckBox chkVisibiltyState = (CheckBox)edititem.FindControl("chkVisibiltyState");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[6].ToString() == "True")
            {
                chkVisibiltyState.Checked = true;
            }
            else
            {
                chkVisibiltyState.Checked = false;
            }


            CheckBox chkVisibiltyCity = (CheckBox)edititem.FindControl("chkVisibiltyCity");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[7].ToString() == "True")
            {
                chkVisibiltyCity.Checked = true;
            }
            else
            {
                chkVisibiltyCity.Checked = false;
            }


            CheckBox chkVisibiltyFacility = (CheckBox)edititem.FindControl("chkVisibiltyFacility");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[3].ToString() == "True")
            {
                chkVisibiltyFacility.Checked = true;
            }
            else
            {
                chkVisibiltyFacility.Checked = false;
            }

            CheckBox chkVisibiltySpeciality = (CheckBox)edititem.FindControl("chkVisibiltySpeciality");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[4].ToString() == "True")
            {
                chkVisibiltySpeciality.Checked = true;
            }
            else
            {
                chkVisibiltySpeciality.Checked = false;
            }

            CheckBox chkVisibiltyDescription = (CheckBox)edititem.FindControl("chkVisibiltyDescription");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[8].ToString() == "True")
            {
                chkVisibiltyDescription.Checked = true;
            }
            else
            {
                chkVisibiltyDescription.Checked = false;
            }

            CheckBox chkVisibiltyPostDate = (CheckBox)edititem.FindControl("chkVisibiltyPostDate");

            if (((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[9].ToString() == "True")
            {
                chkVisibiltyPostDate.Checked = true;
            }
            else
            {
                chkVisibiltyPostDate.Checked = false;
            }


        }
    }
    protected void lnkManageAdmin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Job_ManageAdmin.aspx");
    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Response.Redirect("../Admin/AdminIndex.aspx");
    }

    protected void rgSdjobs_OnItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        RadGrid item = (source as RadGrid);
        if (e.CommandName == RadGrid.InitInsertCommandName)
        {
            item.MasterTableView.ClearEditItems();
        }
        if (e.CommandName == RadGrid.EditCommandName)
        {
            e.Item.OwnerTableView.IsItemInserted = false;
        }
    }
}