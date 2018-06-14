<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeFile="RequestList.aspx.cs" Inherits="RequestList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header runat="server">
        <script src="Scripts/jquery-3.3.1.js"></script>
        <script src="js/bootstrap.js"></script>
        <link href="css/bootstrap.css" rel="stylesheet" />
        <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" />
        <link href="css/StyleSheet.css" rel="stylesheet"/>
    </header>

    <div id="searchResults" runat="server" class="container-fluid" style="padding-top:20px">

        <table align="center">
            <tr>
                <td>
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="6" CellPadding="10">
                        <ItemTemplate>
                            <table class="auto-style1" style ="background-color: #e8e8e8; border-radius: 5px; box-shadow: 3px 3px 10px grey;">
                                <tr>
                                    <td style="padding: 10px;">
                                        <asp:Image ID="lbl_ProductImage" runat="server" Height="220px" ImageAlign="Middle" Width="220px" ImageUrl='<%# "\\images\\" + Eval("URL") + ".jpg" %>'/>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbl_ProductName" runat="server" Text='<%# Eval("productName") %>' style="padding: 10px; font-weight:bold; font-size:20px;" class="productDetails"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbl_ProductDesc" runat="server" Text='<%# Eval("description") %>' style="padding: 10px; font-style: italic; font-size:15px;"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbl_ProductRemarks" runat="server" Text='<%# Eval("remarks") %>' style="padding: 10px; font-style: italic; font-size:15px;"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding: 10px; font-weight: bold; font-size:15px;">
                                        <asp:Label ID="lbl_pRStart" runat="server" Text='<%# "$" + Eval("priceRangeStart") %>'></asp:Label>
                                        &nbsp;-
                                        <asp:Label ID="lbl_pREnd" runat="server" Text='<%# "$" + Eval("priceRangeEnd") %>' ></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding: 10px; font-weight: bold; font-size:15px;">
                                        <asp:Button ID="btn_Buy" runat="server" class="btn-info" style="border-radius: 2px; background-color: #4CAF50; /* Green */border: none; color: white;padding: 10px 15px; text-align: center;  display: inline-block; font-size: 16px; cursor: pointer;" PostBackUrl='<%# "~/ProductPage.aspx?ProductID=" + Eval("requestID") %>' Text='Buy' />
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID='SqlDataSource1' runat='server' ConnectionString='<%$ ConnectionStrings:airmazin %>' SelectCommand='SELECT * FROM [Request] INNER JOIN [ProductPhoto] on [Request].requestID = [ProductPhoto].requestID'></asp:SqlDataSource>
                </td>
            </tr>
        </table>

        

    </div>

</asp:Content>


