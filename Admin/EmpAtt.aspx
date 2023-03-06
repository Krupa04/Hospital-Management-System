<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="EmpAtt.aspx.cs" Inherits="Admin_EmpAtt" %>

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
                    <li class="active">Doctor</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  &amp; Doctor
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
                                    <h4 class="widget-title">employee Details</h4>

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
                                                <td colspan="2">
                                                    <asp:Label Text="" ID="lblMessage" runat="server" />
                                                </td>
                                            </tr>


                                             <tr>
                                                <td>Doctor Name
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlEmpName" runat="server" Width="194px">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>



                                              <tr>
                                                <td>Day
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlDay" runat="server" Width="194px">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>

                                              <tr>
                                                <td>Month
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlMonth" runat="server" Width="194px">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>

                                              <tr>
                                                <td>Year
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlYear" runat="server" Width="194px">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                           

                                      
                                         
                                         
                                       
                                           
                                            <%--    <tr>
                                                <td>Description</td>
                                                <td>
                                                    <asp:TextBox runat="server" TextMode="MultiLine" CssClass="form-control" ID="txtDescription" />
                                                </td>
                                            </tr>--%>
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Submit" ID="Submit" CssClass="btn btn-success"  OnClick="Submit_Click" runat="server" />
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

