using System;
using System.IO;
using System.Web;
using System.Configuration;
using MedAppointments.BusinessAccessLayer;
using System.Text;

// Create our own utility for exceptions
public sealed class ExceptionUtility
{
    // All methods are static, so this can be private
    private ExceptionUtility()
    { }

    // Log an Exception
    public static void LogException(Exception exc, string source)
    {
        if (exc.InnerException != null)
        if (exc.InnerException.GetType() != typeof(FileNotFoundException))
        {
            // Include enterprise logic for logging exceptions
            // Get the absolute path to the log file
            string logFile = "App_Data/ErrorLog.txt";
            logFile = HttpContext.Current.Server.MapPath(logFile);


            // Open the log file for append and write the log
            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine("****************************************************");
            sw.WriteLine("********** {0} **********", TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "India Standard Time"));
            sw.WriteLine("****************************************************");
            sw.WriteLine();
            sw.WriteLine("****************************************************");
            sw.WriteLine("****************** User Sessions *******************");
            sw.WriteLine("****************************************************");

            if (HttpContext.Current.Session["SignInId"] != null)
                 sw.WriteLine("SignIn ID : " + HttpContext.Current.Session["SignInId"].ToString());
            else
                 sw.WriteLine("SignIn ID : NULL");

            if (HttpContext.Current.Session["SignInLoginId"] != null)
                 sw.WriteLine("Login ID : " + HttpContext.Current.Session["SignInLoginId"].ToString());
            else
                 sw.WriteLine("Login ID : NULL");

            if (HttpContext.Current.Session["SignInAccountTypeId"] != null)
                 sw.WriteLine("Account Type ID : " + HttpContext.Current.Session["SignInAccountTypeId"].ToString());
            else
                 sw.WriteLine("Account Type ID : NULL");
            
            if (HttpContext.Current.Session["SignInOrganizationId"] != null)
                 sw.WriteLine("Organization ID : " + HttpContext.Current.Session["SignInOrganizationId"].ToString());
            else
                 sw.WriteLine("Organization ID : NULL");

            if (HttpContext.Current.Session["SignInAccountId"] != null)
                 sw.WriteLine("Account ID : " + HttpContext.Current.Session["SignInAccountId"].ToString());
            else
                 sw.WriteLine("Account ID : NULL");
            sw.WriteLine();
            sw.WriteLine("****************************************************");
            sw.WriteLine("********************* Error ************************");
            sw.WriteLine("****************************************************");
            if (exc.InnerException != null)
            {
                sw.Write("Inner Exception Type: ");
                sw.WriteLine(exc.InnerException.GetType().ToString());
                sw.Write("Inner Exception: ");
                sw.WriteLine(exc.InnerException.Message);
                sw.Write("Inner Source: ");
                sw.WriteLine(exc.InnerException.Source);
                if (exc.InnerException.StackTrace != null)
                {
                    sw.WriteLine("Inner Stack Trace: ");
                    sw.WriteLine(exc.InnerException.StackTrace);
                }
            }
            sw.Write("Exception Type: ");
            sw.WriteLine(exc.GetType().ToString());
            sw.WriteLine("Exception: " + exc.Message);
            sw.WriteLine("Source: " + source);
            sw.WriteLine("Stack Trace: ");
            if (exc.StackTrace != null)
            {
                sw.WriteLine(exc.StackTrace);
                sw.WriteLine();
            }
            sw.WriteLine();
            sw.Close();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************************************");
            sb.AppendLine("**********" + TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "India Standard Time").ToString() + "**********");
            sb.AppendLine("****************************************************");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("****************************************************");
            sb.AppendLine("****************** User Sessions *******************");
            sb.AppendLine("****************************************************");

            if (HttpContext.Current.Session["SignInId"] != null)
                sb.AppendLine("SignIn ID : " + HttpContext.Current.Session["SignInId"].ToString());
            else
                sb.AppendLine("SignIn ID : NULL");

            if (HttpContext.Current.Session["SignInLoginId"] != null)
                sb.AppendLine("Login ID : " + HttpContext.Current.Session["SignInLoginId"].ToString());
            else
                sb.AppendLine("Login ID : NULL");

            if (HttpContext.Current.Session["SignInAccountTypeId"] != null)
                sb.AppendLine("Account Type ID : " + HttpContext.Current.Session["SignInAccountTypeId"].ToString());
            else
                sb.AppendLine("Account Type ID : NULL");

            if (HttpContext.Current.Session["SignInOrganizationId"] != null)
                sb.AppendLine("Organization ID : " + HttpContext.Current.Session["SignInOrganizationId"].ToString());
            else
                sb.AppendLine("Organization ID : NULL");

            if (HttpContext.Current.Session["SignInAccountId"] != null)
                sb.AppendLine("Account ID : " + HttpContext.Current.Session["SignInAccountId"].ToString());
            else
                sb.AppendLine("Account ID : NULL");
            sb.AppendLine();
            sb.AppendLine("****************************************************");
            sb.AppendLine("********************* Error ************************");
            sb.AppendLine("****************************************************");

            if (exc.InnerException != null)
            {
                sb.Append("Inner Exception Type: ");
                sb.AppendLine(exc.InnerException.GetType().ToString());
                sb.Append("Inner Exception: ");
                sb.AppendLine(exc.InnerException.Message);
                sb.Append("Inner Source: ");
                sb.AppendLine(exc.InnerException.Source);
                if (exc.InnerException.StackTrace != null)
                {
                    sb.AppendLine("Inner Stack Trace: ");
                    sb.AppendLine(exc.InnerException.StackTrace);
                }
            }
            sb.Append("Exception Type: ");
            sb.AppendLine(exc.GetType().ToString());
            sb.AppendLine("Exception: " + exc.Message);
            sb.AppendLine("Source: Global.asax");
            sb.AppendLine("Stack Trace: ");
            if (exc.StackTrace != null)
            {
                sb.AppendLine(exc.StackTrace);
                sb.AppendLine();
            }
            sb.AppendLine();

            string to = ConfigurationManager.AppSettings["Developer"].ToString();
            string body = sb.ToString();

            CommunicationBAL.SendEmailWithoutCheckingNotification(to, "Error exception occurred", body, false);
        }
    }

    // Notify System Operators about an exception
    public static void NotifySystemOps(Exception exc)
    {
        // Include code for notifying IT system operators
    }
}