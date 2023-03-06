<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="Docsalary.aspx.cs" Inherits="Admin_Docsalary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Doctor </a>
                    </li>
                    <li class="active">salary</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Doctor  &amp; salary
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
                                    <h4 class="widget-title">Doctor salary</h4>

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
                                                    <asp:DropDownList ID="ddlDoctorName" runat="server" Width="194px">
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


                                            <tr>
                                                <td>Salary in Rs(PER Day)
                                                </td>
                                                <td>
                                                    <asp:TextBox runat="server" ID="txtSalary" Enabled="false" CssClass="form-control" />
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
                                                    <asp:Button Text="Calculate" ID="Submit" CssClass="btn btn-success" OnClick="Submit_Click" runat="server" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Days
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="lblNoOfDays" CssClass="form-control" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>Total
                                                </td>
                                                <td>
                                                    <asp:TextBox runat="server" ID="txtTotal" CssClass="form-control" />
                                                </td>
                                            </tr>

                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Save" ID="btnSave" CssClass="btn btn-success" OnClick="btnSave_Click" runat="server" />
                                                </td>
                                            </tr>

                                        </table>


                                    </div>


                                </div>
                            </div>
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


                    <div class="hr hr32 hr-dotted"></div>


                    <div class="hr hr32 hr-dotted"></div>


                    <!-- /.row -->

                    <!-- PAGE CONTENT ENDS -->
                </div>
            </div>
        </div>
    </div>
</asp:Content>

