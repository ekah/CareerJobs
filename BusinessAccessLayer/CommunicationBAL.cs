using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using MedAppointments.DataAccessLayer;
using System.Web;
using System.IO;
using System.Net.Mime;

namespace MedAppointments.BusinessAccessLayer
{
    public static class CommunicationBAL
    {
        public static class Password
        {
            public static void ChangePassword(string mailTo, string subject, string body, string mobile, string msgBody)
            {
                try
                {
                    bool isEmailSend = SendEmailWithoutCheckingNotification(mailTo, subject, body, true);
                }
                catch
                {

                }
            }

            public static void ForgotPassword(string mailTo, string subject, string body)
            {
                try
                {
                    bool isEmailSend = SendEmailWithoutCheckingNotification(mailTo, subject, body, true);
                }
                catch
                {

                }
            }
        }

        public static bool SendEmailWithoutCheckingNotificationForJobs(string mailTo, string subject, string body, bool isHTML)
        {
            try
            {

                string mailFrom = ConfigurationManager.AppSettings["EmailFromJobs"].ToString();
                string mailBcc = ConfigurationManager.AppSettings["EmailBcc"].ToString();
                string mailUserName = ConfigurationManager.AppSettings["EmailUsername"].ToString();
                string mailPassword = ConfigurationManager.AppSettings["EmailPassword"].ToString();
                string mailVia = ConfigurationManager.AppSettings["EmailVia"].ToString();
                int mailPort = Convert.ToInt32(ConfigurationManager.AppSettings["EmailPort"]);
                string emailSwitchOn = ConfigurationManager.AppSettings["EmailSwitchOn"].ToString();

                if (emailSwitchOn.ToLower() == "on")
                {

                    MailMessage mailMsg = new MailMessage();

                    // To
                    mailMsg.To.Add(new MailAddress(mailTo));

                    // From
                    mailMsg.From = new MailAddress(mailFrom);

                    // Subject and multipart/alternative Body
                    mailMsg.Subject = subject;
                    mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html));

                    // Init SmtpClient and send
                    SmtpClient smtpClient = new SmtpClient(mailVia, mailPort);
                    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(mailUserName, mailPassword);
                    smtpClient.Credentials = credentials;

                    smtpClient.Send(mailMsg);

                    //MailMessage message = new MailMessage(mailFrom, mailTo, subject, body);
                    //message.BodyEncoding = Encoding.UTF8;
                    //message.IsBodyHtml = isHTML;
                    //message.Priority = MailPriority.Normal;
                    //message.Bcc.Add(mailBcc);

                    //SmtpClient client = new SmtpClient("localhost", 25);
                    //client.Credentials = CredentialCache.DefaultNetworkCredentials;
                    //client.Send(message);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool SendEmailWithoutCheckingNotification(string mailTo, string subject, string body, bool isHTML)
        {
            try
            {
                string mailFrom = ConfigurationManager.AppSettings["EmailFrom"].ToString();
                string mailBcc = ConfigurationManager.AppSettings["EmailBcc"].ToString();
                string mailUserName = ConfigurationManager.AppSettings["EmailUsername"].ToString();
                string mailPassword = ConfigurationManager.AppSettings["EmailPassword"].ToString();
                string mailVia = ConfigurationManager.AppSettings["EmailVia"].ToString();
                int mailPort = Convert.ToInt32(ConfigurationManager.AppSettings["EmailPort"]);
                string emailSwitchOn = ConfigurationManager.AppSettings["EmailSwitchOn"].ToString();

                if (emailSwitchOn.ToLower() == "on")
                {

                    MailMessage mailMsg = new MailMessage();

                    // To
                    mailMsg.To.Add(new MailAddress(mailTo));

                    // From
                    mailMsg.From = new MailAddress(mailFrom);

                    // Subject and multipart/alternative Body
                    mailMsg.Subject = subject;
                    mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html));

                    // Init SmtpClient and send
                    SmtpClient smtpClient = new SmtpClient(mailVia, mailPort);
                    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(mailUserName, mailPassword);
                    smtpClient.Credentials = credentials;

                    smtpClient.Send(mailMsg);

                    //MailMessage message = new MailMessage(mailFrom, mailTo, subject, body);
                    //message.BodyEncoding = Encoding.UTF8;
                    //message.IsBodyHtml = isHTML;
                    //message.Priority = MailPriority.Normal;
                    //message.Bcc.Add(mailBcc);

                    //SmtpClient client = new SmtpClient("localhost", 25);
                    //client.Credentials = CredentialCache.DefaultNetworkCredentials;
                    //client.Send(message);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool SendEmailWithCheckingNotification(string mailTo, string subject, string body, bool isHTML)
        {
            try
            {
                string mailFrom = ConfigurationManager.AppSettings["EmailFrom"].ToString();
                string mailBcc = ConfigurationManager.AppSettings["EmailBcc"].ToString();
                string mailUserName = ConfigurationManager.AppSettings["EmailUsername"].ToString();
                string mailPassword = ConfigurationManager.AppSettings["EmailPassword"].ToString();
                string mailVia = ConfigurationManager.AppSettings["EmailVia"].ToString();
                int mailPort = Convert.ToInt32(ConfigurationManager.AppSettings["EmailPort"]);
                string emailSwitchOn = ConfigurationManager.AppSettings["EmailSwitchOn"].ToString();

                if (emailSwitchOn.ToLower() == "on")
                {
                    bool isEmail = new CommonBAL().EmailSwitch(mailTo);

                    if (isEmail)
                    {
                        MailMessage mailMsg = new MailMessage();
                        mailMsg.To.Add(new MailAddress(mailTo));
                        mailMsg.From = new MailAddress(mailFrom);
                        mailMsg.Subject = subject;
                        mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html));
                        SmtpClient smtpClient = new SmtpClient(mailVia, mailPort);
                        System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(mailUserName, mailPassword);

                        smtpClient.Credentials = credentials;

                        smtpClient.Send(mailMsg);


                        //MailMessage message = new MailMessage(mailFrom, mailTo, subject, body);
                        //message.BodyEncoding = Encoding.UTF8;
                        //message.IsBodyHtml = isHTML;
                        //message.Priority = MailPriority.Normal;
                        //message.Bcc.Add(mailBcc);

                        //SmtpClient client = new SmtpClient("localhost", 25);
                        //client.Credentials = CredentialCache.DefaultNetworkCredentials;
                        //client.Send(message);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool SendSMSToIndiaWithoutCheckingNotification(string mobile, string body, int accountTypeId, string action, int organizationId)
        {
            try
            {
                string smsUsername = ConfigurationManager.AppSettings["IndiaSMSUsername"].ToString();
                string smsPassword = ConfigurationManager.AppSettings["IndiaSMSPassword"].ToString();
                string indiaSmsSwitch = ConfigurationManager.AppSettings["IndiaSMSSwitch"].ToString();

                if (indiaSmsSwitch.ToLower() == "on")
                {
                    StringBuilder sbUrl = new StringBuilder();
                    sbUrl.Append("http://enterprise.smsgupshup.com/GatewayAPI/rest");
                    sbUrl.Append("?method=sendMessage");
                    sbUrl.Append("&send_to=" + mobile);
                    sbUrl.Append("&msg=" + HttpUtility.UrlEncode(body));
                    sbUrl.Append("&userid=" + smsUsername);
                    sbUrl.Append("&password=" + smsPassword);
                    sbUrl.Append("&v=1.1");
                    sbUrl.Append("&msg_type=TEXT");
                    sbUrl.Append("&auth_scheme=PLAIN");
                    sbUrl.Append("&override_dnd=true");

                    //sbUrl.Append("http://75.125.154.74/messageapi.asp");
                    //sbUrl.Append("?username=" + smsUsername);
                    //sbUrl.Append("&password=" + smsPassword);
                    //sbUrl.Append("&sender=MedAppt");
                    //sbUrl.Append("&mobile=" + mobile);
                    //sbUrl.Append("&message=" + body);

                    System.Net.HttpWebRequest hwr = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(sbUrl.ToString());
                    hwr.AllowWriteStreamBuffering = true;
                    hwr.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                    hwr.Referer = "http://www.google.com/";
                    hwr.Timeout = 40000;
                    CookieContainer cc = new CookieContainer();
                    hwr.CookieContainer = cc;

                    System.Net.WebResponse wr = hwr.GetResponse();

                    string responseString = "";
                    using (Stream stream = wr.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                        responseString = reader.ReadToEnd();
                    }

                    string mobileid = "";
                    string externalid = "";
                    if (responseString != string.Empty)
                    {
                        string[] successMessages = responseString.Split('|');

                        mobileid = successMessages[1].Trim();
                        externalid = successMessages[2].Trim();
                    }
                    string oldSignInId = "";
                    if (HttpContext.Current.Session["SignInId"] == null)
                        oldSignInId = string.Empty;
                    else
                        oldSignInId = HttpContext.Current.Session["SignInId"].ToString();
                    new CommonDAL().SaveSMS(oldSignInId, mobile, accountTypeId, body, action, mobileid, externalid, 0, organizationId);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool SendSMSToNonIndiaWithoutCheckingNotification(string mobile, string body, int accountTypeId, string action, int organizationId)
        {
            try
            {
                string smsUsername = ConfigurationManager.AppSettings["InternationalSMSUsername"].ToString();
                string smsPassword = ConfigurationManager.AppSettings["InternationalSMSPassword"].ToString();
                string nonIndiaSmsSwitch = ConfigurationManager.AppSettings["InternationalSMSSwitch"].ToString();

                if (nonIndiaSmsSwitch.ToLower() == "on")
                {
                    StringBuilder sbUrl = new StringBuilder();
                    sbUrl.Append("http://www.onverify.com/sms.php");
                    sbUrl.Append("?userid=" + smsUsername);
                    sbUrl.Append("&apipass=" + smsPassword);
                    sbUrl.Append("&number=" + mobile);
                    sbUrl.Append("&from=MedAppt");
                    sbUrl.Append("&msg=" + HttpUtility.UrlEncode(body));

                    System.Net.HttpWebRequest hwr = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(sbUrl.ToString());
                    hwr.AllowWriteStreamBuffering = true;
                    hwr.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                    hwr.Referer = "http://www.google.com/";
                    hwr.Timeout = 40000;
                    CookieContainer cc = new CookieContainer();
                    hwr.CookieContainer = cc;

                    System.Net.WebResponse wr = hwr.GetResponse();

                    string oldSignInId = "";
                    if (HttpContext.Current.Session["SignInId"] == null)
                        oldSignInId = string.Empty;
                    else
                        oldSignInId = HttpContext.Current.Session["SignInId"].ToString();
                    new CommonDAL().SaveSMS(oldSignInId, mobile, accountTypeId, body, action, null, null, 0, organizationId);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool SendSMSToIndiaWithCheckingNotification(string mobile, string body, int accountTypeId, string action, int appointmentId, int organizationId)
        {
            try
            {
                string smsUsername = ConfigurationManager.AppSettings["IndiaSMSUsername"].ToString();
                string smsPassword = ConfigurationManager.AppSettings["IndiaSMSPassword"].ToString();
                string indiaSmsSwitch = ConfigurationManager.AppSettings["IndiaSMSSwitch"].ToString();

                if (indiaSmsSwitch.ToLower() == "on")
                {
                    bool isSMS = new CommonBAL().SMSSwitch(mobile);

                    if (isSMS)
                    {
                        StringBuilder sbUrl = new StringBuilder();
                        //sbUrl.Append("http://75.125.154.74/messageapi.asp");
                        //sbUrl.Append("?username=" + smsUsername);
                        //sbUrl.Append("&password=" + smsPassword);
                        //sbUrl.Append("&sender=MedAppt");
                        //sbUrl.Append("&mobile=" + mobile);
                        //sbUrl.Append("&message=" + body);

                        sbUrl.Append("http://enterprise.smsgupshup.com/GatewayAPI/rest");
                        sbUrl.Append("?method=sendMessage");
                        sbUrl.Append("&send_to=" + mobile);
                        sbUrl.Append("&msg=" + HttpUtility.UrlEncode(body));
                        sbUrl.Append("&userid=" + smsUsername);
                        sbUrl.Append("&password=" + smsPassword);
                        sbUrl.Append("&v=1.1");
                        sbUrl.Append("&msg_type=TEXT");
                        sbUrl.Append("&auth_scheme=PLAIN");
                        sbUrl.Append("&override_dnd=true");

                        System.Net.HttpWebRequest hwr = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(sbUrl.ToString());
                        hwr.AllowWriteStreamBuffering = true;
                        hwr.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                        hwr.Referer = "http://www.google.com/";
                        hwr.Timeout = 40000;
                        CookieContainer cc = new CookieContainer();
                        hwr.CookieContainer = cc;

                        System.Net.WebResponse wr = hwr.GetResponse();

                        string responseString = "";
                        using (Stream stream = wr.GetResponseStream())
                        {
                            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                            responseString = reader.ReadToEnd();
                        }

                        string mobileid = "";
                        string externalid = "";
                        if (responseString != string.Empty)
                        {
                            string[] successMessages = responseString.Split('|');

                            mobileid = successMessages[1].Trim();
                            externalid = successMessages[2].Trim();
                        }

                        string oldSignInId = "";
                        if (HttpContext.Current.Session["SignInId"] == null)
                            oldSignInId = string.Empty;
                        else
                            oldSignInId = HttpContext.Current.Session["SignInId"].ToString();
                        new CommonDAL().SaveSMS(oldSignInId, mobile, accountTypeId, body, action, mobileid, externalid, appointmentId, organizationId);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool SendSMSToNonIndiaWithCheckingNotification(string mobile, string body, int accountTypeId, string action, int appointmentId, int organizationId)
        {
            try
            {
                string smsUsername = ConfigurationManager.AppSettings["InternationalSMSUsername"].ToString();
                string smsPassword = ConfigurationManager.AppSettings["InternationalSMSPassword"].ToString();
                string nonIndiaSmsSwitch = ConfigurationManager.AppSettings["InternationalSMSSwitch"].ToString();

                if (nonIndiaSmsSwitch.ToLower() == "on")
                {
                    bool isSMS = new CommonBAL().SMSSwitch(mobile);

                    if (isSMS)
                    {
                        StringBuilder sbUrl = new StringBuilder();
                        sbUrl.Append("http://www.onverify.com/sms.php");
                        sbUrl.Append("?userid=" + smsUsername);
                        sbUrl.Append("&apipass=" + smsPassword);
                        sbUrl.Append("&number=" + mobile);
                        sbUrl.Append("&from=MedAppt");
                        sbUrl.Append("&msg=" + HttpUtility.UrlEncode(body));

                        System.Net.HttpWebRequest hwr = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(sbUrl.ToString());
                        hwr.AllowWriteStreamBuffering = true;
                        hwr.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";
                        hwr.Referer = "http://www.google.com/";
                        hwr.Timeout = 40000;
                        CookieContainer cc = new CookieContainer();
                        hwr.CookieContainer = cc;

                        System.Net.WebResponse wr = hwr.GetResponse();

                        string oldSignInId = "";
                        if (HttpContext.Current.Session["SignInId"] == null)
                            oldSignInId = string.Empty;
                        else
                            oldSignInId = HttpContext.Current.Session["SignInId"].ToString();
                        new CommonDAL().SaveSMS(oldSignInId, mobile, accountTypeId, body, action, null, null, appointmentId, organizationId);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
