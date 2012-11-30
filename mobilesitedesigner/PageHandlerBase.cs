using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Data.Linq;
using System.Threading;
using System.Web;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace mobilesitedesigner
{
    public abstract class PageHandlerBase : System.Web.UI.Page
    {
        //private Data.edmx.Entities _GetDataContext5;

        //public Data.edmx.Entities GetDataContext5
        //{
        //    get
        //    {
        //        if (_GetDataContext5 == null) _GetDataContext5 = new Data.edmx.Entities();
        //        return _GetDataContext5;
        //    }
        //}
        Data.dbml.DataContext _GetDataContext2;
        public Data.dbml.DataContext GetDataContext2
        {
            get
            {
                if (_GetDataContext2 == null) _GetDataContext2 = new Data.dbml.DataContext(Common.DataConnectionString);
                return _GetDataContext2;
            }
        }

        Data.POCOS.DB _GetDataContext1;
        public Data.POCOS.DB GetDataContext1
        {
            get
            {
                if (_GetDataContext1 == null) _GetDataContext1 = new Data.POCOS.DB();
                return _GetDataContext1;
            }
        }
        //SubSonic.POCOS.DB.mobilesitedesignerDB _GetDataContext3;
        //public SubSonic.POCOS.DB.mobilesitedesignerDB GetDataContext3
        //{
        //    get
        //    {
        //        if (_GetDataContext3 == null) _GetDataContext3 = new SubSonic.POCOS.DB.mobilesitedesignerDB();
        //        return _GetDataContext3;
        //    }
        //}
        //SubSonic.POCOS1.DB.mobilesitedesignerDB _GetDataContext4;
        //public SubSonic.POCOS1.DB.mobilesitedesignerDB GetDataContext4
        //{
        //    get
        //    {
        //        if (_GetDataContext4 == null) _GetDataContext4 = new SubSonic.POCOS1.DB.mobilesitedesignerDB();
        //        return _GetDataContext4;
        //    }
        //}
        List<SqlConnection> _connections = new List<SqlConnection>();

        public SqlConnection SqlConnection
        {

            get
            {
                SqlConnection _SqlConnection = new SqlConnection(Common.DataConnectionString);
                _connections.Add(_SqlConnection);
                _SqlConnection.Open();
                return _SqlConnection;
            }
        }


     

        public SqlConnection JobsSqlConnection
        {

            get
            {
                SqlConnection _SqlConnection = new SqlConnection(Common.JobsDataConnectionString);
                _connections.Add(_SqlConnection);
                _SqlConnection.Open();
                return _SqlConnection;
            }
        }
      
        protected void Page_PreInit(object sender, EventArgs e)
        {           
        }

        protected override void OnUnload(EventArgs e)
        {

            if (_GetDataContext1 != null) _GetDataContext1.Dispose();
            if (_GetDataContext2 != null) _GetDataContext2.Dispose();
            _connections.ForEach(o => o.Close());

        }
    }
}


