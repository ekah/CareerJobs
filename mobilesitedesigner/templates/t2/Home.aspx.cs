using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
namespace mobilesitedesigner
{
    public partial class Home : PageHandlerBase
    {
       
        public mobilesitedesigner.Data.dbml.Page _Page;
        public List<mobilesitedesigner.Data.dbml.Content> _Content;
        protected void Page_Load(object sender, EventArgs e)
        {
            int pageid = int.Parse(Request.QueryString["pageid"]);
           
            _Page = GetDataContext2.Page.Single(o => o.ID == pageid);
            _Content=_Page.Content.ToList();
        }
    }
}