using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductPage : System.Web.UI.Page
{
    private int productID = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            int index = url.IndexOf("=");
            productID = int.Parse(url.Substring(50));
        } catch (Exception )
        {

        }
        
        if (productID != -1)
        {
            Request tbd = RequestDA.getRequestByProductID(productID);

            pp_productName.InnerHtml = tbd.productName;
            pp_Date.InnerHtml = tbd.datePosted.ToString().Substring(0,9);
            pp_Location.InnerHtml = tbd.postalCode + ", " + RequestDA.getLocation(int.Parse(tbd.locationID.ToString()));
            pp_productDesc.InnerHtml = tbd.description;
            pp_Author.InnerHtml = RequestDA.getRequestAuthorName(int.Parse(tbd.authorID.ToString()));
            pp_productDesc.InnerHtml = tbd.description;
            pp_Remarks.InnerHtml = tbd.remarks;
            pp_priceRange.InnerHtml = "$" + tbd.priceRangeStart + " - $" + tbd.priceRangeEnd;
        }
        
    }

    protected void image_navPrev_Click(object sender, EventArgs e)
    {

    }
}