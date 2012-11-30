<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        RegisterRoutes(System.Web.Routing.RouteTable.Routes);
    }

    public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
    {
        routes.Add("doctorpage", new System.Web.Routing.Route
        (
           "doctor/{fdoctorname}",
           new HospitalRouteHandler("~/Hospital.aspx")
        ));

        routes.Add("hospitalpage", new System.Web.Routing.Route
        (
           "hospital",
           new HospitalRouteHandler("~/Hospital.aspx")
        ));
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    {
        // Code that runs when an unhandled error occurs
        Exception exc = Server.GetLastError();

        // Handle HTTP errors
        if (exc.GetType() == typeof(HttpException))
        {
            // The Complete Error Handling Example generates
            // some errors using URLs with "NoCatch" in them;
            // ignore these here to simulate what would happen
            // if a global.asax handler were not implemented.
            if (exc.Message.Contains("NoCatch") || exc.Message.Contains("maxUrlLength") || exc.Message.Contains("File does not exist."))
            {
                Server.ClearError();
                return;
            }

            //Redirect HTTP errors to HttpError page
            //Server.Transfer("HttpErrorPage.aspx");
        }

        // For other kinds of errors give the user some information
        // but stay on the default page
        //Response.Write("<h2>Global Page Error</h2>\n");
        //Response.Write(
        //    "<p>" + exc.Message + "</p>\n");
        //Response.Write("Return to the <a href='Default.aspx'>" +
        //    "Default Page</a>\n");

        // Log the exception and notify system operators
        ExceptionUtility.LogException(exc, "DefaultPage");
        //ExceptionUtility.NotifySystemOps(exc);

        // Clear the error from the server
        Server.ClearError();

        HttpContext.Current.Response.Redirect("~/error.aspx");
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
