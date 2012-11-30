using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Job_NewsLetterHome : System.Web.UI.UserControl
{
    string _name = string.Empty;
    string _email = string.Empty;
    int _clientid = 0;
    Job_NewsLetterHomeBAL objNewsLetterHomeBAL = new Job_NewsLetterHomeBAL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void ShowMessage(string Message)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<script type = 'text/javascript'>");
        sb.Append("alert('");
        //sb.Append(count.ToString());
        sb.Append(Message + "');");
        sb.Append("</script>");
        //ScriptManager.RegisterStartupScript(this.Page,this.GetType(), "script", sb.ToString(),true);
        ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{0}');", Message), true);
    }

    protected void btnSubscribe_Click(object sender, EventArgs e)
    {
        _name = txtname.Text.Trim();
        _email = txtEmail.Text.Trim();
        if (Session["SignInOrganizationId"] != null)
        {
            _clientid = Convert.ToInt32(Session["SignInOrganizationId"].ToString());
        }
        DataSet ds = objNewsLetterHomeBAL.GetNewsLetterByEmailClientId(_email, _clientid);

        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            ShowMessage("EmailID Already Exists.");
        }
        else
        {
            objNewsLetterHomeBAL.InsertNewsLetter(_name, _email, _clientid);
            ShowMessage("Thank you for subscribing.");
        }
    }
}