<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="ViewAppointment.aspx.cs" Inherits="Admin_ViewAppointment" %>

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
                    <li class="active">Appointment</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            View  Appointment
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
                                    <h4 class="widget-title">Appointment Details</h4>

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
                                                <asp:GridView ID="dynamictable" runat="server" CssClass="table table-striped table-bordered table-hover dynamic-table" AutoGenerateColumns="false"
                                                    Width="100%"
                                                    OnRowDataBound="grdMainTitle_RowDataBound">
                                                    <Columns>
                                                        <asp:BoundField DataField="name" HeaderText="User_Id" />
                                                        <asp:BoundField DataField="mobile" HeaderText="Mobile No" />
                                                        <asp:BoundField DataField="age" HeaderText="Age" />
                                                        <asp:BoundField DataField="select_date" HeaderText="Date" />
                                                        <asp:BoundField DataField="select_time" HeaderText="Time" />
                                                       <%-- <asp:BoundField DataField="" HeaderText="" />--%>
                                                    </Columns>
                                                </asp:GridView>
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

