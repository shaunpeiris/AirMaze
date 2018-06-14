<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RequestCard.aspx.cs" Inherits="RequestCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div class="col-md-3 col-lg-3" style="padding: 16.5px">
            <section class="panel">
                <%-- orange circle--%>
                <div class="pro-img-box">
                    <img src="/images/prod.jpg" alt="" />
                    <a href="#" class="adtocart">
                        <i class="fa fa-shopping-cart cartLogo"></i>
                    </a>
                </div>
                <div class="panel-body text-center productDesc">
                    <h4>
                        <a href="#" class="pro-title">Leopard Shirt Dress
                        </a>
                    </h4>
                    <p class="price">$300.00</p>
                    <p class="productWordFormat">
                        <span style="font-weight: bold">Posted by: </span>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    </p>
                </div>
            </section>
        </div>
    
    </form>
</body>
</html>
