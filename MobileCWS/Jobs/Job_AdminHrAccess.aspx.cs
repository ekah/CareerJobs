using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Telerik.Web.UI;
using MedAppointments.BusinessAccessLayer;

public partial class Jobs_Job_AdminHrAccess : System.Web.UI.Page
{

    public const string _adminsession = "ADMIN";
    public const string _subadminsession = "SUBADMIN";
    public const string _hrsession = "HR";
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    Job_HrAccessBAL objHrAccessBAL = new Job_HrAccessBAL();
    int _hid = 0;
    string _username = string.Empty;
    string _password = string.Empty;
    int _clientid = 0;
    string _whocreated = string.Empty;
    string _whoupdated = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
    protected void rghr_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        rghr.DataSource = GridDataSource();
    }
    private DataSet GridDataSource()
    {
        DataSet ds = new DataSet();       
        ds = objHrAccessBAL.HrLoginSelectByClientIDByAll();        
        return ds;
    }
    protected void rghr_UpdateCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {
            GridEditableItem edititem = e.Item as GridEditableItem;
            RadComboBox rcbclient = (RadComboBox)edititem.FindControl("rcbclient");


            _username = (edititem["hrusername"].FindControl("rtbUserName") as RadTextBox).Text;
            _password = (edititem["hrpassword"].FindControl("rtbPassword") as RadTextBox).Text;

            if (rcbclient.SelectedValue == "--Select--")
            {
                ShowPopUpMsg("Please Select Client");
            }
            else if (_username == string.Empty)
            {
                ShowPopUpMsg("Please Enter User Name");
            }
            else if (_password == string.Empty)
            {
                ShowPopUpMsg("Please Enter Password");
            }
            else
            {
                _clientid = Convert.ToInt32(rcbclient.SelectedValue);
                _hid = Convert.ToInt32(edititem.GetDataKeyValue("Hid"));
                _whocreated = string.Empty;
                if (Session["SignInId"] != null)
                {
                    _whoupdated = Session["SignInId"].ToString();
                }

                 DataSet ds = objHrAccessBAL.HrLoginSelectByUserNameById(_hid,_username, _clientid);

                 if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                 {
                     ShowPopUpMsg("Username already exists");
                 }
                 else
                 {
                     objHrAccessBAL.InsertUpdateHrLogin(_hid, _username, _password, _clientid, _whocreated, _whoupdated);
                     rghr.Rebind();
                 }
            }
        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rghr_InsertCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        GridEditFormInsertItem item = (GridEditFormInsertItem)e.Item;

        RadComboBox rcbclient = (RadComboBox)item.FindControl("rcbclient");
        _username = (item["hrusername"].FindControl("rtbUserName") as RadTextBox).Text;
        _password = (item["hrpassword"].FindControl("rtbPassword") as RadTextBox).Text;  

         if (rcbclient.SelectedValue == "--Select--")
         {
             ShowPopUpMsg("Please Select Client");
         }
         else if (_username == string.Empty)
         {
             ShowPopUpMsg("Please Enter User Name");
         }
         else if (_password == string.Empty)
         {
             ShowPopUpMsg("Please Enter Password");
         }
         else
         {
             _clientid = Convert.ToInt32(rcbclient.SelectedValue);
             _hid = 0;

             if (Session["SignInId"] != null)
             {
                 _whocreated = Session["SignInId"].ToString();
             }
             _whoupdated = string.Empty;

             DataSet ds = objHrAccessBAL.HrLoginSelectByUserName(_username, _clientid);

             if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
             {
                 ShowPopUpMsg("Username already exists");
             }
             else
             {
                 objHrAccessBAL.InsertUpdateHrLogin(_hid, _username, _password, _clientid, _whocreated, _whoupdated);
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
    protected void rghr_DeleteCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
    {
        try
        {
            GridDataItem item = (GridDataItem)e.Item;
            _hid = Convert.ToInt32(item.GetDataKeyValue("Hid"));
            _clientid = Convert.ToInt32(item.GetDataKeyValue("ClientId"));
            objHrAccessBAL.DeleteHrLogin(_hid, _clientid);
            rghr.Rebind();
        }
        catch
        {
            e.Canceled = true;
        }
    }
    protected void rghr_ItemDataBound(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridDataItem)
        {
            GridDataItem item = (GridDataItem)e.Item;
            LinkButton lnkDelete = (LinkButton)item.FindControl("lnkDelete");
            Label lblUserName = (Label)item.FindControl("lblUserName");
            lnkDelete.OnClientClick = "javascript:return confirm('Are you sure, Do you want to delete " + lblUserName.Text + "?');";
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
            edititem["Client"].Enabled = false;
            rcbclient.SelectedValue = ((System.Data.DataRowView)(edititem.DataItem)).Row.ItemArray[3].ToString();
            
        }

    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Response.Redirect("~/Default.aspx");
    }
    protected void lnkManageAdmin_Click(object sender, EventArgs e)
    {      
      Response.Redirect("Job_ManageAdmin.aspx");              
    }

    protected void rghr_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
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