<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="AddAdmin.aspx.cs" Inherits="Admin_AddAdmin" %>

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

                                <div class="widget-body">
                                    <div class="widget-main">
                                        <table class="table  table-bordered table-hover">
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Label Text="" ID="lblMessage" runat="server" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>User Name</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toLowerCase();' ID="txtUserName"  title="Please enter Char only" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                            

                                            <tr>
                                                <td>Password</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toLowerCase();' ID="txtPassword" TextMode="Password" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Name</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toUpperCase();' ID="txtName" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Date Of Birth</td>
                                                <td>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker" ID="txtDateOfJoin" data-date-format="dd/mm/yyyy" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Mobile</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtMobile" pattern="\d{10}" title="Please enter exactly 10 digits" MaxLength="10" required="true" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Email</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" ID="txtEmail" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Address </td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="txtAddress" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>City</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtcity" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>State</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtState" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Date Of Join</td>
                                                <td>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker" ID="txtDOJ" data-date-format="dd/mm/yyyy" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Qualification</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtQualification" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Designation</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtDesignation" />
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
                                                    <asp:Button Text="Submit" ID="Submit" CssClass="btn btn-success" OnClick="Submit_Click" runat="server" />
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

