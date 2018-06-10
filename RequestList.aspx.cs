using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RequestList : System.Web.UI.Page
{

    string location = "abc123";
    string searchLocation = "";
    string reqList = "";
    string requests = "";
    string user = "username";
    double price = 100;

    protected void Page_Load(object sender, EventArgs e)
    {
        searchLocation = "<div><div style=\"background-color: white; padding: 15px;  border-radius:4px;\"><h1> requests based on &#34;<span style=\"font-style: italic\">" + location + "&#34;</span></h1></div></div>";

        for (int i = 0; i < 3; i++)
        {
            requests += "<div class=\"col-md-3 col-lg-3\" style=\"padding: 16.5px\"><section class=\"panel\"><div class=\"pro-img-box\"><img src = \"/images/prod.jpg\" alt=\"\" />" +
                        "<a href = \"#\" class=\"adtocart\"><i class=\"fa fa-shopping-cart cartlogo\"></i></a></div>" + "<div class=\"panel-body text-center productDesc\">" +
                        "<h4><a href = \"#\" class=\"pro-title\">leopard shirt dress</a></h4>" +
                        "<p class=\"price\">$" + price + "</p><p class=\"productWordFormat\"><span style = \"font-weight:bold\" > posted by: </span><br/>" + user + "</p>" +
                    "</div></section></div>";
        }

        reqList = "<div class=\"row product-list\">" + requests + "</div>";

        searchResults.InnerHtml = searchLocation + reqList;

    }
}