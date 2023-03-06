<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="Finance.aspx.cs" Inherits="Admin_Finance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Add </a>
                    </li>
                    <li class="active">Admin</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  &amp; Admin
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
                                    <h4 class="widget-title">Admin Details</h4>

                                    <div class="widget-toolbar">
                                        <a href="#" data-action="collapse">
                                            <i class="ace-icon fa fa-chevron-up"></i>
                                        </a>

                                    </div>
                                </div>


                        <asp:GridView ID="grid_show" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Doc_id" HeaderText="Doc_Id" />
                            <asp:BoundField DataField="month" HeaderText="Month" />
                            <asp:BoundField DataField="year" HeaderText="Year" />
                            <asp:BoundField DataField="salary" HeaderText="Salary" />
                            <asp:BoundField DataField="no_of_day" HeaderText="No Of Days" />
                            <asp:BoundField DataField="total" HeaderText="Total" />
                           
                        </Columns>



                    </asp:GridView>


                                    <div class="widget-body">
                                    <div class="widget-main">
                                       
                                        <div class="row">
                                            <div class="col-xs-12">
                                                
                                                <div class="table-header">
                                                    
                                                </div>
                                             <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="true"
                                                    Width="100%"
                                                   OnRowDataBound="GridView1_RowDataBound" >
                                                </asp:GridView>

                                            </div>
                                        </div>

                                      
                                    </div>


                                </div>


                                <div class="widget-body">
                                    <div class="widget-main">
                                       
                                        <div class="row">
                                            <div class="col-xs-12">
                                                
                                                <div class="table-header">
                                                    
                                                </div>
                                             <asp:GridView ID="dynamictable" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="true"
                                                    Width="100%"
                                                    OnRowDataBound="grdMainTitle_RowDataBound">
                                                </asp:GridView>

                                            </div>
                                        </div>

                                      
                                    </div>


                                </div>

                                    <div class="widget-body">
                                    <div class="widget-main">
                                       
                                        <div class="row">
                                            <div class="col-xs-12">
                                                
                                                <div class="table-header">
                                                    
                                                </div>
                                             <asp:GridView ID="GridView2" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="true"
                                                    Width="100%"
                                                    OnRowDataBound="grdMainTitle_RowDataBound">
                                                </asp:GridView>

                                            </div>
                                        </div>

                                      
                                    </div>


                                </div>



                                <div class="widget-body">
                                    <div class="widget-main">
                                        <table class="table  table-bordered table-hover">
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Label Text="" ID="lblMessage" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Total Income</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" Enabled="false" ID="txttotalincome" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Total Expense</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" Enabled="false" ID="txttotalexp" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Total Profilt</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" Enabled="false" ID="txtprofit" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                        </table>
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

