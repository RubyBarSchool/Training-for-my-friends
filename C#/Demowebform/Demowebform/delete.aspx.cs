using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demowebform
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.outPut.Text =  Request.QueryString["id"];
            this.outPut.Text = Request.Params["id"];
            /////logic xoas vaof dday
        }
    }
}