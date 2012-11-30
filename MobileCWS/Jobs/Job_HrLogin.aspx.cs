using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Jobs_Job_HrLogin : System.Web.UI.Page
{   
    int _clientid = 0;
    string _hrusername = string.Empty;
    string _hrpassword = string.Empty;
    string _subadminusername = string.Empty;
    string _subadminpassword = string.Empty;
    Job_HrLoginBAL objLoginBAL = new Job_HrLoginBAL();

    protected void Page_Load(object sender, EventArgs e)
    {

        GetHrPassword();     

    }

    public void GetHrPassword()
    {
        _hrusername = txtUsername.Text.Trim();

        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());

                DataSet dshr = objLoginBAL.HrLoginSelectByUserName(_hrusername, _clientid);
                if (dshr.Tables.Count > 0 && dshr.Tables[0].Rows.Count > 0)
                {
                    _hrpassword = dshr.Tables[0].Rows[0]["Password"].ToString();
                }
            }
        }
     
    }

    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        if (Request.QueryString["cid"] != null)
        {
            if (Request.QueryString["cid"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
            }
        }
        Response.Redirect("~/Jobs/Job_HrLogin.aspx");
    }
    protected void imgLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (txtUsername.Text.ToUpper() == _hrusername.ToUpper() && txtPassword.Text.ToUpper() == _hrpassword.ToUpper())
        {
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                    Session["Login"] = "HR";
                    Session["User"] = _hrusername;
                    Session["SignInId"] = _hrusername;
                    Response.Redirect("~/Jobs/Job_HrManageAdmin.aspx?cid=" + _clientid);
                }
            }
        }
        else
        {
            lblErrorMessage.Text = "Sorry.. Your Username and Password is Wrong.Please Try Again.";
            lblErrorMessage.ForeColor = System.Drawing.Color.Red;
        }
    }
}