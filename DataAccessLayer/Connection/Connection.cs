using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MedAppointments.DataAccessLayer
{
    public class Connection
    {
        private string _connectionstring;

        public Connection()
        {
            _connectionstring = ConfigurationManager.ConnectionStrings["DataConnectionString"].ToString();
        }

        public Connection(bool isMap)
        {
            _connectionstring = (isMap) ? ConfigurationManager.ConnectionStrings["DataConnectionString"].ToString() : ConfigurationManager.ConnectionStrings["DataConnectionString"].ToString();
        }


        public string ConnectionString
        {
            get { return _connectionstring; }
        }
    }
}
