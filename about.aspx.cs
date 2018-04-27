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
        var dt = sl.query("select * from about");
        repeater1.DataSource = dt;
        repeater1.DataBind();
    }
}
