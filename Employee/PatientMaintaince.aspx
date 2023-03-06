<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Employee.master" AutoEventWireup="true" CodeFile="PatientMaintaince.aspx.cs" Inherits="Employee_PatientMaintaince" %>

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
                    <li class="active">Patient Maintenance</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  Patient Maintenance
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
                                    <h4 class="widget-title">Patient Details</h4>

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
                                                <td>Patient Name</td>
                                                <td>
                                                    <asp:DropDownList CssClass="form-control" ID="ddlPatientID" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Nature Of Problem</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNatureOfProblem" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Blood Test No</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtBloodTestNo" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Xray No</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtxrayno" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>CT Scan</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtCtScan" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Prescription</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtPrescription" />
                                                </td>
                                            </tr>


                                            <tr>
                                                <td>Comments</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtComments" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Visit Date</td>
                                                <td>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker" ID="txtVisitdate" data-date-format="dd/mm/yyyy" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
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
