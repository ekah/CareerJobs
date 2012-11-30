using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
namespace mobilesitedesigner.templates.t2
{
    public partial class Content : PageHandlerBase
    {
        public Data.dbml.Page _Page;
        public Data.dbml.Content _Content;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            _Content = GetDataContext2.Content.Single(o => o.ID == id);
            _Page = _Content.Page;
        }
    }
}