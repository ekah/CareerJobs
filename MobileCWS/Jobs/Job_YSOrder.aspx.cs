using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MedAppointments.BusinessAccessLayer;
using System.Web.UI.HtmlControls;

public partial class Jobs_Job_YSOrder : System.Web.UI.Page
{
    Job_JobsBAL objJobsBAL = new Job_JobsBAL();
    protected void Page_Load(object sender, EventArgs e)
    {

        BindSpecialityByChar("Y");
    }

    public void BindSpecialityByChar(string chr)
    {
        DataSet ds = objJobsBAL.SelectBySpecialityByChar(chr);

        rpJobList.DataSource = ds;
        rpJobList.DataBind();

    }

    protected void rpJobList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item is RepeaterItem)
        {
            RepeaterItem dataitem = (RepeaterItem)e.Item;
            Label lblstatus = (Label)dataitem.FindControl("lblstatus");
            HyperLink Hystatus = (HyperLink)dataitem.FindControl("Hystatus");

            HtmlControl licolor = (HtmlControl)dataitem.FindControl("licolor");

            if (lblstatus.Text.ToUpper() == "YES")
            {
                Hystatus.CssClass = "txt_black";
                Hystatus.Enabled = true;
                licolor.Attributes.Add("class", "txt_black");
            }
            else
            {
                Hystatus.CssClass = "txt_gray";
                Hystatus.ToolTip = "No Jobs";
                Hystatus.Enabled = false;
                licolor.Attributes.Add("class", "txt_gray");
            }
        }
    }
}