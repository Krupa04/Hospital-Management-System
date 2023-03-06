<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="PurchaseReport.aspx.cs" Inherits="Admin_PurchaseReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Add </a>
                    </li>
                    <li class="active">Product</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  &amp; Product
                        </small>
                    </h1>
                </div>
                <!-- /.page-header -->

                <div class="row">
                    <div class="col-xs-12">
                        <!-- PAGE CONTENT BEGINS -->
                        <div class="col-xs-6 col-sm-6">
                            <div class="widget-box">
                                <div class="widget-header">
                                    <h4 class="widget-title">Product Details</h4>

                                    <div class="widget-toolbar">
                                        <a href="#" data-action="collapse">
                                            <i class="ace-icon fa fa-chevron-up"></i>
                                        </a>

                                    </div>
                                </div>

                             
                                   <div class="widget-body">
                                    <div class="widget-main">

                                        <table class="table  table-bordered table-hover">
                                            <tr>
                                                <td>Supplier total amount and quantity </td>
                                                  <td>
                                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlSupplier">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                               
                                                <td colspan="2">
                                                    <asp:Button Text="Get" runat="server" ID="btnGet" OnClick="btnGet_Click" />
                                                </td>
                                            </tr>
                                          
                                        </table>
                                       
                                        <div class="row">
                                            <div class="col-xs-12">
                                                
                                                <div class="table-header">
                                                    
                                                </div>
                                                <asp:GridView ID="dynamictable" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="true"
                                                    Width="100%"
                                                    OnRowDataBound="dynamictable_RowDataBound">
                                                </asp:GridView>
                                            </div>
                                        </div>

                                      
                                    </div>


                                </div>

                            </div>
                        </div>
                    </div>


                    <div class="hr hr32 hr-dotted"></div>


                    <div class="hr hr32 hr-dotted"></div>


                    <!-- /.row -->

                    <!-- PAGE CONTENT ENDS -->
                </div>
            </div>
        </div>
    </div>
</asp:Content>

