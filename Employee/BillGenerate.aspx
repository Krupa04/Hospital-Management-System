<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Employee.master" AutoEventWireup="true" CodeFile="BillGenerate.aspx.cs" Inherits="Employee_BillGenerate" %>

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
                    <li class="active">Bill Details</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                           Bill Details
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
                                    <h4 class="widget-title">Bill Details</h4>

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
                                                <asp:Label Text="" ID="lblMessage" runat="server" />
                                            </tr>
                                           <%-- <tr>

                                                <td>Patient Name</td>
                                                <td>
                                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlPatienrname" OnSelectedIndexChanged="ddlPatienrname_SelectedIndexChanged" AutoPostBack="true">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                                        --%>                            

                                          <asp:GridView ID="dynamictable" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="false"                                                    Width="100%"
                                                    OnRowDataBound="grdMainTitle_RowDataBound">

                                                    <Columns>
                                                        <asp:BoundField DataField="id" HeaderText="Patient Id" />
                                                      
                                                        <asp:BoundField DataField="RoomNo" HeaderText="Room No" />
                                                          <asp:BoundField DataField="AdmitDate" HeaderText="Admit Date" />
                                                        <asp:BoundField DataField="DischargeDate" HeaderText="Discharge Date" />

                                                        <asp:BoundField DataField="MedicalAmount" HeaderText="Medical Charge" />
                                                        <asp:BoundField DataField="RoomAmoiunt" HeaderText="Room Charge" />
                                                        <asp:BoundField DataField="Total" HeaderText="Total" />
                                                    </Columns>

                                                </asp:GridView>

                                        </table>


                                    </div>


                                </div>
                            </div>
                        </div>
      
                    </div>


                    <!-- /.row -->

                    <!-- PAGE CONTENT ENDS -->
                </div>
            </div>
        </div>
    </div>
</asp:Content>

