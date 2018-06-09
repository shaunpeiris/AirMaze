using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RequestList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        searchResults.InnerHtml = " <div> "+
            " < div style = \"background-color: white; padding: 15px;  border-radius:4px;\" > " +
 
                // "< h1 > Requests based on &#34;<span style=\"font-style: italic\"><asp:Label ID=\"lbl_Location\" runat=\"server\" Text=\"Location123\"></asp:Label>&#34;</span> " +
                //    " </ h1 > " +

                //"</ div >" +

            "</ div > ";
    }
}