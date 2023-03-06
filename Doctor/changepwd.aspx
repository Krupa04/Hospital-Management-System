<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Doctor.master" AutoEventWireup="true" CodeFile="changepwd.aspx.cs" Inherits="Doctor_changepwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">change  </a>
                    </li>
                    <li class="active">Password  </li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            change  &amp; Password
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
                                    <h4 class="widget-title">change Password</h4>

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
                                                <td>Current Password</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control"  ID="txtoldpwd" TextMode="Password" runat="server" required="true"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtoldpwd" ForeColor="Red" ErrorMessage="Minimum password length is 8" ValidationExpression=".{8}.*" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>New Password</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control"  ID="txtnewpwd" TextMode="Password" runat="server" required="true"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtnewpwd" ForeColor="Red" ErrorMessage="Minimum password length is 8" ValidationExpression=".{8}.*" />

                                                </td>
                                            </tr>


                                            <tr>
                                                <td>Confirm  password</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control"  ID="txtconpwd" TextMode="Password" runat="server" required="true"></asp:TextBox>
                                                    <asp:RegularExpressionValidator ID="valPassword" runat="server" ControlToValidate="txtconpwd" ForeColor="Red" ErrorMessage="Minimum password length is 8" ValidationExpression=".{8}.*" />
                                                    <asp:CompareValidator ID="CompareValidator1" runat="server"  ControlToCompare="txtnewpwd" ControlToValidate="txtconpwd"  ErrorMessage="Password Mismatch"></asp:CompareValidator>    

                                                </td>
                                            </tr>





                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Change Password" ID="Submit" CssClass="btn btn-success" OnClick="Submit_Click" runat="server" />
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

