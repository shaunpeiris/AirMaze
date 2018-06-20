<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="ProductPage.aspx.cs" Inherits="ProductPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="container" style="padding: 50px; font-family: Roboto;">
            <div id="testing" runat="server"></div>
                <div class="background-color: white; container-fluid">
                    <div class="wrapper">
                        <div class="preview col-md-6">
                            
                           <%-- <div class="preview-pic tab-content">
                                <div class="tab-pane" id="pic-1">
                                    <img src="http://placekitten.com/400/252" /></div>
                                <div class="tab-pane active" id="pic-2">
                                    <img src="images/cat2.jpg" /></div>
                                <div class="tab-pane" id="pic-3">
                                    <img src="http://placekitten.com/400/252" /></div>
                                <div class="tab-pane" id="pic-4">
                                    <img src="http://placekitten.com/400/252" /></div>
                                <div class="tab-pane" id="pic-5">
                                    <img src="http://placekitten.com/400/252" /></div>
                            </div>

                            <ul class="preview-thumbnail nav nav-tabs">
                                <li class="active"><a data-target="#pic-1" data-toggle="tab">
                                    <img src="http://placekitten.com/200/126" /></a></li>
                                <li><a data-target="#pic-2" data-toggle="tab">
                                    <img src="images/cat2.jpg" /></a></li>
                                <li><a data-target="#pic-3" data-toggle="tab">
                                    <img src="http://placekitten.com/200/126" /></a></li>
                                <li><a data-target="#pic-4" data-toggle="tab">
                                    <img src="http://placekitten.com/200/126" /></a></li>
                                <li><a data-target="#pic-5" data-toggle="tab">
                                    <img src="http://placekitten.com/200/126" /></a></li>
                            </ul>--%>

                            <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                                <div class="carousel-inner" id="rp_productImage" runat="server">
                                   
                                </div>

                                <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="sr-only">Previous</span>
                                </a>
                                <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="sr-only">Next</span>
                                </a>
                            </div>


                        </div>
                        <div class="details col-md-6">
                            <h3 class="product-title" id="rp_productName" runat="server">men's shoes fashion</h3>
                            <div>
                                <p style="font-size:14px;"><i class="fas fa-clock"></i><b>&nbsp;Posted on &nbsp;</b><span id="rp_Date" runat="server"></span><b> by </b><span id="rp_Author" style="color:blue;" runat="server"></span><br/>
                                <i class="fas fa-map-marker-alt"></i><b> &nbsp;Located in &nbsp;</b><span id="rp_Location" runat="server"></span></p>
                            </div>
                            <p class="product-description"><b>Description: </b><span id="rp_productDesc" runat="server">Suspendisse quos? Tempus cras iure temporibus? Eu laudantium cubilia sem sem! Repudiandae et! Massa senectus enim minim sociosqu delectus posuere.</span></p>
                            <p class="product-description"><b>Requestor's remarks: </b><span id="rp_Remarks" style="font-style: italic" runat="server"></span></p>
                            <h4 class="price">price range: <span id="rp_priceRange" runat="server">$180</span></h4>

                            <div class="action">
                                <button class="add-to-cart btn btn-default" type="button">make an offer</button>
                                <button class="like btn btn-default" type="button"><span class="fa fa-heart"></span></button>
                            </div>
                        </div>
                    </div>
                </div>

        </div>

</asp:Content>

