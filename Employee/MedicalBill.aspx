<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Employee.master" AutoEventWireup="true" CodeFile="MedicalBill.aspx.cs" Inherits="Employee_MedicalBill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">View </a>
                    </li>
                    <li class="active">Purchase Details</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                           Purchase Details
                        </small>
                    </h1>
                </div>
                <!-- /.page-header -->

                <div class="row">
                    <div class="col-xs-12">
                        <!-- PAGE CONTENT BEGINS -->
                        <div class="col-xs-12 col-sm-12">
                            <div class="widget-box">
                                <div class="widget-header">
                                    <h4 class="widget-title">Purchase Details</h4>

                                    <div class="widget-toolbar">
                                        <a href="#" data-action="collapse">
                                            <i class="ace-icon fa fa-chevron-up"></i>
                                        </a>

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
                                               <%-- <table class="table table-striped table-bordered table-hover dynamic-table">
                                                    <tr>
                                                        <td>Type 1</td>
                                                        <td>In Patient</td>
                                                        <td>Type 2</td>
                                                        <td>Out Patient</td>
                                                    </tr>
                                                </table>--%>
                                            </div>
                                        </div>


                                    </div>


                                </div>

                                                <div class="widget-body">
                                    <div class="widget-main">

                                        <table class="table  table-bordered table-hover">
                                            <tr>
                                               <%-- <td colspan="2">
                                                    <asp:Label ID="Label1" runat="server" Text="Appointment Fix"></asp:Label>
                                                </td>--%>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:Label Text="" ID="lblMessage" runat="server" />
                                                </td>
                                            </tr>
                                          
                                            <tr>
                                                <td>Supplier Name
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="ddlsupName" runat="server" Width="194px">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>

                                            <tr>

                                                <td align="center" colspan="2">

                                                   <asp:Button ID="CmdSubmit" CssClass="btn btn-success" runat="server" OnClick="CmdSubmit_Click" Text="Get Total qty and Price"  />
                                                   <%-- <asp:Button ID="CmdReset" CssClass="Button" runat="server" Text="Clear" OnClick="CmdReset_Click" />--%>

                                                </td>
                                            </tr>


                                    </div>


                                </div>

                                   <div class="widget-body">
                                    <div class="widget-main">

                                        <div class="row">
                                            <div class="col-xs-12">

                                                <div class="table-header">
                                                </div>
                                                <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="true"
                                                    Width="100%"
                                                    OnRowDataBound="grdMainTitle_RowDataBound">

                                                </asp:GridView>
                                               <%-- <table class="table table-striped table-bordered table-hover dynamic-table">
                                                    <tr>
                                                        <td>Type 1</td>
                                                        <td>In Patient</td>
                                                        <td>Type 2</td>
                                                        <td>Out Patient</td>
                                                    </tr>
                                                </table>--%>
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

