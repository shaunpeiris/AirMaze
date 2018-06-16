using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class RequestList : System.Web.UI.Page
{

    string location = "abc123";
    string searchLocation = "";
    string reqList = "";
    string requests = "";
    string user = "user123";
    string pName = "";
    double price = 100;
    string sqlCommand = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["searchTerms"]!=null)
        {
            sqlCommand = "SELECT * FROM [Request] INNER JOIN [ProductPhoto] on [Request].requestID = [ProductPhoto].requestID WHERE productName LIKE '%" + Session["searchTerms"].ToString() + "%'";
            lbl_Location.Text = Session["searchTerms"].ToString();
        } else
        {
            sqlCommand = "SELECT * FROM [Request] INNER JOIN [ProductPhoto] on [Request].requestID = [ProductPhoto].requestID";
            searchTerms_display.InnerHtml = "";
        }
        SqlDataSource1.SelectCommand = sqlCommand;
        Session.Clear();

    }

}