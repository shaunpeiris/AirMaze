using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductPage : System.Web.UI.Page
{
    private int reqID = -1;
    private int photoIndex = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            int index = url.IndexOf("=");
            reqID = int.Parse(url.Substring(50));
        } catch (Exception) {

        }
        
        if (reqID != -1)
        {
            Request tbd = RequestDA.getRequestByID(reqID);

            rp_productName.InnerHtml = tbd.productName;
            rp_Date.InnerHtml = tbd.datePosted.ToString().Substring(0,9);
            rp_Location.InnerHtml = tbd.postalCode + ", " + RequestDA.getLocation(int.Parse(tbd.locationID.ToString()));
            rp_productDesc.InnerHtml = tbd.description;
            rp_Author.InnerHtml = RequestDA.getRequestAuthorName(int.Parse(tbd.authorID.ToString()));
            rp_productDesc.InnerHtml = tbd.description;
            rp_Remarks.InnerHtml = tbd.remarks;
            rp_priceRange.InnerHtml = "$" + tbd.priceRangeStart + " - $" + tbd.priceRangeEnd;

            List<string> imgUrls = RequestDA.getRequestPhotosURL(reqID);
            String newhtml = "";
            for (int i = 0; i < imgUrls.Count; i++)
            {
                if (i == 0)
                {
                    newhtml += "<div class=\"carousel-item active\"><img class=\"d-block w-100\" src=\"images/" + imgUrls[i] + ".jpg\" alt=\"" + imgUrls[i] + "\"></div>";
                } else
                {
                    newhtml += "<div class=\"carousel-item\"><img class=\"d-block w-100\" src=\"images/" + imgUrls[i] + ".jpg\" alt=\"" + imgUrls[i] + "\"></div>";
                }
                
            }

            rp_productImage.InnerHtml = newhtml;
            
        }
        
    }

}