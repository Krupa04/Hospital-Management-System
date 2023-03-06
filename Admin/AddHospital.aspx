<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="AddHospital.aspx.cs" Inherits="Admin_AddHospital" %>

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
                    <li class="active">Hospital</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  &amp; Hospital
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
                                    <h4 class="widget-title">Hospital Details</h4>

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
                                                <td>ID</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" Enabled="false"  ID="txtid"  runat="server" required="true" ></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Name</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toUpperCase();' ID="txtName"  runat="server" required="true" pattern="[A-Za-z]{}" title="Please enter Char only"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Branch Name</td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlBranch" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Address</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" Rows="2" ID="txtAddress" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Email</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" ID="txtEmail" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Mobile </td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtMobileNo" pattern="\d{10}" title="Please enter exactly 10 digits" MaxLength="10" required="true" runat="server"></asp:TextBox>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Submit" ID="Submit" CssClass="btn btn-success" OnClick="Submit_Click" runat="server" />
                                                </td>
                                            </tr>

                                        </table>

                                        <%--  <div class="col-sm-6 col-md-3 col-xs-12  panels">Name <span style="color: red; text-indent: 15px;">*</span></div>
                                        <div class="col-sm-6 col-md-3 col-xs-12  panels">
                                            <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toUpperCase();' ID="txtName" runat="server" required="true"></asp:TextBox>
                                        </div>
                                        <div class="col-sm-6 col-md-3 col-xs-12  panels">Mobile No<span style="color: red; text-indent: 15px;">*</span></div>
                                        <div class="col-sm-6 col-md-3 col-xs-12  panels">
                                            <asp:TextBox CssClass="form-control" ID="txtMobileNo" pattern="\d{10}" title="Please enter exactly 10 digits" MaxLength="10" required="true" runat="server"></asp:TextBox>
                                        </div>--%>
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

