using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web1;

public partial class _Default : System.Web.UI.Page
{
    web1.website2.sqlhp sl = new web1.website2.sqlhp();
    protected void Page_Load(object sender, EventArgs e)
    {
       if (!Page.IsPostBack)
        {
            var dt = sl.query("select top(6) firld as '',field as '' from table;");
            GridView1.DataSource = dt;
            GridView1.DataBind();
            var dt2 = sl.query2(@"select top(6) field as '',field as '' from table 
            where field = 'book' order by field desc");
            GridView2.DataSource = dt2;
            GridView2.DataBind();

        }
    }
}
