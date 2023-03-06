<%@ Page Title="" Language="C#" MasterPageFile="~/Master/User.master" AutoEventWireup="true" CodeFile="AddOrgan.aspx.cs" Inherits="User_AddOrgan" %>

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
                    <li class="active">Organ</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add Organ
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
                                    <h4 class="widget-title">Organ Details</h4>

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
                                                <td>Name</td>
                                                <td>
                                                    <asp:Label Text="" ID="lblName" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Mobile</td>
                                                <td>
                                                    <asp:Label Text="" ID="lblMobile" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Organ Details</td>
                                                <td>
                                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlOrgan">
                                                        <asp:ListItem Text="Eye" />
                                                        <asp:ListItem Text="Heart" />
                                                        <asp:ListItem Text="Kidney" />
                                                        <asp:ListItem Text="Lungs" />
                                                        <asp:ListItem Text="Liver" />
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>

                                              <tr>
                                                <td>Blood Group</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtBlood" />
                                                </td>
                                            </tr>
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

