using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
using System.Data;
using MedAppointments.BusinessAccessLayer;

public partial class Job_Job_SendToFriend : System.Web.UI.Page
{
    string strYourName = string.Empty;
    string strYourEmail = string.Empty;
    string strFriendsName = string.Empty;
    string strFriendEmail = string.Empty;
    string strComments = string.Empty;
    string concatenate = string.Empty;
    string links = string.Empty;
    char dblquote;
    string StrUrl = string.Empty;

    string _jobid = string.Empty;
    string _jobtitle = string.Empty;
    string _jobDesc = string.Empty;
    string _jobQual = string.Empty;
    int _clientid = 0;

    Job_SearchDescriptionBAL objSearchDescriptionBAL = new Job_SearchDescriptionBAL();

    protected void Page_Load(object sender, EventArgs e)
    {
        lblMsg.Visible = false;
        lnkBack.Visible = false;


        string strMessage = GetJobDetail();
        txtComments.Content = strMessage;

    }

    #region Get Current URL
    public string GetURLs()
    {
        HttpContext httpc = HttpContext.Current;
        string AppPath, StrUrl;
        AppPath = httpc.Request.ApplicationPath.ToString() + "/";
        if (AppPath == "//")
        {
            AppPath = "/";
        }
        string strUriWithouthttp = httpc.Request.Url.AbsoluteUri.Replace("http://", "");
        int indexOfSlash = strUriWithouthttp.IndexOf('/');
        indexOfSlash = (indexOfSlash == -1 ? strUriWithouthttp.Length : indexOfSlash);
        string sitePath = "http://" + strUriWithouthttp.Substring(0, indexOfSlash) + AppPath;

        StrUrl = sitePath;
        return StrUrl;
    }
    #endregion

    public string GetJobDetail()
    {
        string msgBody = string.Empty;
        dblquote = '"';

        if (Request.QueryString["jobid"] != null)
        {

            _jobid = Request.QueryString["jobid"].ToString();
            if (Request.QueryString["cid"] != null)
            {
                if (Request.QueryString["cid"].ToString() != string.Empty)
                {
                    _clientid = Convert.ToInt32(Request.QueryString["cid"].ToString());
                }
            }
            DataSet ds = objSearchDescriptionBAL.SelectJobByJobIdVisible(_jobid, _clientid);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                _jobtitle = ds.Tables[0].Rows[0]["jobtitle"].ToString();
                StrUrl = GetURLs();


                msgBody = msgBody + "Hi, <br/><br/> \n\n I think you may be interested in this job in this Hospital: \n\n<br/><br/> <a href=\"" + StrUrl + "Jobs/Job_SearchDescription.aspx?jobId=" + _jobid + "&cid=" + _clientid.ToString() + "\"> " + _jobtitle + " </a> <br> \n\n<br/><br/> Click on the link above, or go to \n<a href=" + dblquote + GetURLs() + dblquote + " title= " + GetURLs() + " > " + GetURLs() + "</a> \n\n to learn more about the great opportunities in this Hospital. ";

                char[] japanese = { '\u3078', '\u3087', '\u3045', '\u3053', '\u305D', '\u0021' };

            }


        }

        return msgBody;
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {

        strYourName = txtYourName.Text;
        strYourEmail = txtYourEmail.Text;
        strFriendsName = txtFriendsName.Text;
        strFriendEmail = txtFriendEmail.Text;
        strComments = txtComments.Content;

        string strMessage = GetJobDetail();
        string Body;
        Body = strMessage.Replace("Hi", "");
        CommunicationBAL.SendEmailWithoutCheckingNotificationForJobs(strFriendEmail.Trim(), "Career Opportunity", "Hi " + strFriendsName + Body + "<br/><br/>Thanks,<br/>" + strYourName, true);

        //MailMessage mailobj = new MailMessage();

        //mailobj.From = strYourEmail.Trim();
        //mailobj.To = strFriendEmail.Trim();
        //mailobj.BodyFormat = MailFormat.Html;
        //mailobj.Subject = "Career Opportunity";
        
        
        //mailobj.Body = "Hi " + strFriendsName + Body + "<br/><br/>Thanks,<br/>" + strYourName;

        //SmtpMail.SmtpServer = "localhost";
        //SmtpMail.Send(mailobj);

        txtYourName.Text = string.Empty;
        txtYourEmail.Text = string.Empty;
        txtFriendsName.Text = string.Empty;
        txtFriendEmail.Text = string.Empty;
        txtComments.Content = string.Empty;

        lblMsg.Text = "Mail has been Sent Successfully.";
        lblMsg.Visible = true;
        divMain.Visible = false;
        lnkBack.Visible = true;

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Hospital.aspx");
    }

    protected void lnkBack_Click(object sender, EventArgs e)
    {
        divMain.Visible = true;
        lblMsg.Visible = false;
        lnkBack.Visible = false;
    }
}