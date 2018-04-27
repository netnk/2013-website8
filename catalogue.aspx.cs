using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web1;

public partial class catalogue : System.Web.UI.Page
{
    web1.website2.sqlhp sl = new web1.website2.sqlhp();
    protected void Page_Load(object sender, EventArgs e)
    {
        var key = Request.QueryString["key"];
        if (key =="" || key == null)
        {
            Response.Redirect("./Default.aspx");
        }
        
        var dt = sl.query2(@"select DISTINCT  top(10) field as 'Title'
                from table 
                where field like '% " + key + @"%' 
                and field= 'boook' and cata35 = 'chi'");
        gridview1.DataSource = dt;
        gridview1.DataBind();
    }
}
