using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demowebform
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.AutoGenerateColumns = false;
            // phaan bieetj laanf daauf truy caapj vaf laanf 2 or lan n truy cap no la sao
            if (!IsPostBack)
            {
                this.DropDownList1.DataSource = DataAccess.getAllDiaChi();
                this.DropDownList1.DataTextField = "Name";
                this.DropDownList1.DataValueField = "ID";
                this.DropDownList1.DataBind();
                List<Student> list = DataAccess.getAllStudent();
                this.GridView1.DataSource = list;
                Session["listStudent"] = list;
            }
            BoundField bc0 = new BoundField();
            bc0.HeaderText = "ID";
            bc0.DataField = "ID";
            this.GridView1.Columns.Add(bc0);
            BoundField bc1 = new BoundField();
            bc1.HeaderText = "Name";
            bc1.DataField = "Name";
            this.GridView1.Columns.Add(bc1);
            BoundField bc = new BoundField();
            bc.HeaderText = "DiaChi";
            bc.DataField = "Place";
            this.GridView1.Columns.Add(bc);



            HyperLinkField hl = new HyperLinkField();
            hl.HeaderText = "Delete";
            hl.DataTextFormatString = "Delete: {0}";
            hl.DataTextField = "ID";
            //hl.NavigateUrl = "abc.aspx";
            hl.DataNavigateUrlFormatString = "delete.aspx?id={0}";
            //string[] a = new string[1];
            //a[0] = "ID";
            hl.DataNavigateUrlFields = new string[] {"ID"};
            this.GridView1.Columns.Add(hl);
            this.GridView1.DataBind();
        }

        public void loadData()
        {
            int id = Convert.ToInt32( this.DropDownList1.SelectedValue);
            List<Student> list = (List<Student>)Session["listStudent"];
            this.GridView1.DataSource = DataAccess.getStudentbyID(id, list);
            this.GridView1.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}