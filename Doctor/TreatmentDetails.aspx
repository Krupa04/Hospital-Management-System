<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Doctor.master" AutoEventWireup="true" CodeFile="TreatmentDetails.aspx.cs" Inherits="Doctor_TreatmentDetails" %>

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
                    <li class="active">Treatment</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  &amp; Treatment
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
                                    <h4 class="widget-title">Treatment Details</h4>

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
                                                <td>Patient Id</td>
                                                <td>
                                                    <asp:DropDownList CssClass="form-control" ID="ddlPatientID" AutoPostBack="true" runat="server">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>


                                            <tr>
                                                <td>Disease</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtDisease" runat="server" TextMode="MultiLine" required="true"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Treatement</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtTreatement" required="true" TextMode="MultiLine" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Doctor Note</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="txtDoctorNote" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Date Of Visit</td>
                                                <td>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker" ID="txtDOJ" data-date-format="dd/mm/yyyy" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
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

