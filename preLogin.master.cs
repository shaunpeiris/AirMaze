﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lk_SignUp_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");
    }

    protected void lk_HIW_Click(object sender, EventArgs e)
    {
        Response.Redirect("HowItWorks.aspx");
    }

    protected void lk_Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void lk_Login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void lk_AboutUs_Click(object sender, EventArgs e)
    {

    }
}
