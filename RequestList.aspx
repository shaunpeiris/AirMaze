<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="RequestList.aspx.cs" Inherits="RequestList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header>
        <script src="Scripts/jquery-3.3.1.js"></script>
        <script src="js/bootstrap.js"></script>
        <link href="css/bootstrap.css" rel="stylesheet" />
        <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" />
        <link href="css/StyleSheet.css" rel="stylesheet" />
    </header>

    <div id="searchResults" class="container-fluid" style="padding-top:20px">

        <div>
            <div style="background-color: white; padding: 15px;  border-radius:4px;">
                <h1>Requests based on &#34;<span style="font-style: italic"><asp:Label ID="lbl_Location" runat="server" Text="Location123"></asp:Label>&#34;</span>
                    </h1>
            </div>
        </div>
        
        <div class="row product-list">

            <div class="col-md-3 col-lg-3" style="padding:16.5px">
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
                        <p class="productWordFormat"><span style="font-weight:bold">Posted by: </span><br />
                            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                        </p>
                    </div>
                </section>
            </div>

            <div class="col-md-3 col-lg-3" style="padding:16.5px">
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
                        <p class="productWordFormat"><span style="font-weight:bold">Posted by: </span><br />
                            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
                        </p>
                    </div>
                </section>
            </div>

            <div class="col-md-3 col-lg-3" style="padding:16.5px">
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
                        <p class="productWordFormat"><span style="font-weight:bold">Posted by: </span><br />
                            <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
                        </p>
                    </div>
                </section>
            </div>

            <div class="col-md-3 col-lg-3" style="padding:16.5px">
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
                            <a href="#" class="pro-title">Leopard Shirt Dress</a>
                        </h4>
                        <p class="price">$300.00</p>
                        <p class="productWordFormat"><span style="font-weight:bold">Posted by: </span><br />
                            <asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
                        </p>
                    </div>
                </section>
            </div>
        </div>

    </div>

</asp:Content>

