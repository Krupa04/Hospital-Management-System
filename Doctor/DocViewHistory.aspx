<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Doctor.master" AutoEventWireup="true" CodeFile="DocViewHistory.aspx.cs" Inherits="Doctor_DocViewHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">View </a>
                    </li>
                    <li class="active">Patient</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            View Patient
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
                                    <h4 class="widget-title">In Patient Details</h4>

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
                                                    <asp:Label Text="" ID="Label1" runat="server" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Patient Id </td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtInPatientId" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                          
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Search" ID="Button1" formnovalidate CssClass="btn btn-success" OnClick="Submit_Click" runat="server" />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>

                            
                            </div>
                        </div>

                        <div class="col-xs-6 col-sm-6">
                            <div class="widget-box">
                                <div class="widget-header">
                                    <h4 class="widget-title">Out Patient Details</h4>

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
                                                    <asp:Label Text="" ID="Label1ss" runat="server" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Patient Id </td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtOutPatientId" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                          
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Search" ID="btnOutPatient" formnovalidate OnClick="btnOutPatient_Click" CssClass="btn btn-success"  runat="server" />
                                                </td>
                                            </tr>

                                        </table>
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

