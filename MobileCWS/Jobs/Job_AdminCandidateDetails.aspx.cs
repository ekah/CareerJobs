using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedAppointments.BusinessAccessLayer;
using System.Data;

public partial class Jobs_Job_AdminCandidateDetails : System.Web.UI.Page
{
    int _aid = 0;
    int _clientid = 0;
    Job_CandidateDetailsBAL objCandidateDetailsBAL = new Job_CandidateDetailsBAL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateCandidateDetails();
        }
    }

    public void PopulateCandidateDetails()
    {
        if (Request.QueryString["id"] != null)
        {
            if (Request.QueryString["id"].ToString() != string.Empty)
            {
                _aid = Convert.ToInt32(Request.QueryString["id"].ToString());
            }
        }
        if (Request.QueryString["ClientId"] != null)
        {
            if (Request.QueryString["ClientId"].ToString() != string.Empty)
            {
                _clientid = Convert.ToInt32(Request.QueryString["ClientId"].ToString());
            }
        }

        DataSet dscandidate = objCandidateDetailsBAL.SelectCandidateDetailsByAidClientId(_aid, _clientid);

        if (dscandidate.Tables.Count > 0 && dscandidate.Tables[0].Rows.Count > 0)
        {
            lbljobid.Text = dscandidate.Tables[0].Rows[0]["jobid"].ToString();
            lblCandidatenameval.Text = dscandidate.Tables[0].Rows[0]["candidatename"].ToString();
            lblageval.Text = dscandidate.Tables[0].Rows[0]["age"].ToString();
            lblsexval.Text = dscandidate.Tables[0].Rows[0]["sex"].ToString();
            lblpermanentaddressval.Text = dscandidate.Tables[0].Rows[0]["permanentaddress"].ToString();
            lblemailval.Text = dscandidate.Tables[0].Rows[0]["email"].ToString();
            lblcityval.Text = dscandidate.Tables[0].Rows[0]["city"].ToString();
            lbldistrictval.Text = dscandidate.Tables[0].Rows[0]["district"].ToString();
            lblstateval.Text = dscandidate.Tables[0].Rows[0]["state"].ToString();
            lblCountryval.Text = dscandidate.Tables[0].Rows[0]["country"].ToString();
            lblhowdidyouval.Text = dscandidate.Tables[0].Rows[0]["aboutus"].ToString();
            lblcontactphoneval.Text = dscandidate.Tables[0].Rows[0]["contactphone"].ToString();
            lblcontactmobileval.Text = dscandidate.Tables[0].Rows[0]["contactmobile"].ToString();
            lblbesttimeval.Text = dscandidate.Tables[0].Rows[0]["besttime"].ToString();
            lblspecializationval.Text = dscandidate.Tables[0].Rows[0]["specialization"].ToString();
            lblexpval.Text = dscandidate.Tables[0].Rows[0]["experience"].ToString();
            lblhighesqualtval.Text = dscandidate.Tables[0].Rows[0]["highestqualification"].ToString();
            lblhighesdegreeval.Text = dscandidate.Tables[0].Rows[0]["highestdegree"].ToString();
            lblCurrentEmployer.Text = dscandidate.Tables[0].Rows[0]["currentemployer"].ToString();
            lblExistingpay.Text = dscandidate.Tables[0].Rows[0]["existingpay"].ToString();
            lblDesiredpay.Text = dscandidate.Tables[0].Rows[0]["desiredpay"].ToString();
            lblwillingtorelocate.Text = dscandidate.Tables[0].Rows[0]["willing"].ToString();
        }

    }
}