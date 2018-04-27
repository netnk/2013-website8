using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web1;

public partial class MasterPage : System.Web.UI.MasterPage
{
    web1.website2.sqlhp sl = new web1.website2.sqlhp();
    protected void Page_Load(object sender, EventArgs e)
    {
        var dt = sl.query("select * from table");

        total.Text = dt.Rows[0]["field"].ToString();
        todaycount.Text = dt.Rows[0]["field"].ToString();
        ystdaycount.Text = dt.Rows[0]["field"].ToString();

        
    }
    protected void button1_Click(object sender, EventArgs e)
    {
        var key = textbox1.Text;
        Response.Redirect("./page.aspx?key=" + key);
    }
}
