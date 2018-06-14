using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string url = HttpContext.Current.Request.Url.AbsoluteUri;
        int index = url.IndexOf("=");
        int productID = int.Parse(url.Substring(50));
    }
}