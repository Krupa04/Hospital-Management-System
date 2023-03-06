<%@ Page Title="" Language="C#" MasterPageFile="~/Master/User.master" AutoEventWireup="true" CodeFile="Appointment.aspx.cs" Inherits="User_Appointment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Home</a>
                    </li>
                    <li class="active">Appointment</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Fix Appointment
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
                                    <h4 class="widget-title">Fix Appointment</h4>

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
                                                <td>Name
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtname" runat="server" Width="194px" required=""></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Mobile
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtmobile" runat="server" MaxLength="10" Width="194px" required=""></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Age
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="txtage" runat="server" MaxLength="3" Width="194px" required=""></asp:TextBox>
                                                </td>
                                            </tr>

                                             <tr>
                                                <td>Date Of Birth</td>
                                                <td>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker" Width="194px" ID="txtDateOfBirth" data-date-format="dd/mm/yyyy" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
                                                </td>
                                            </tr>

                                          
                                            <tr>
                                                <td>Select Time</td>
                                                <td>

                                                    <asp:DropDownList ID="ddlTime" runat="server" Width="194px">
                                                        <asp:ListItem Text="10:30 PM" />
                                                        <asp:ListItem Text="12:15 PM" />
                                                        <asp:ListItem Text="01:00 PM" />
                                                        <asp:ListItem Text="01:45 PM" />
                                                        <asp:ListItem Text="02:30 PM" />
                                                        <asp:ListItem Text="03:15 PM" />
                                                        <asp:ListItem Text="04:00 PM" />
                                                        <asp:ListItem Text="04:45 PM" />
                                                        <asp:ListItem Text="05:30 PM" />
                                                        <asp:ListItem Text="06:15 PM" />
                                                        <asp:ListItem Text="07:00 PM" />
                                                        <asp:ListItem Text="07:45 PM" />

                                                    </asp:DropDownList>
                                                </td>
                                            </tr>

                                            <tr>
                                                <td>specialist</td>
                                                <td>
                                                    <asp:DropDownList runat="server" ID="ddlspecial" OnSelectedIndexChanged="ddlspecial_SelectedIndexChanged"  AutoPostBack="true" Width="194px">
                                                        <asp:ListItem Text="General" />
                                                        <asp:ListItem Text="Eye" />
                                                        <asp:ListItem Text="ENT" />
                                                        <asp:ListItem Text="Cardiology" />
                                                        <asp:ListItem Text="Neurology" />
                                                        <asp:ListItem Text="Oncology" />
                                                    </asp:DropDownList>
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

                                                <td align="center" colspan="2">

                                                   <asp:Button ID="CmdSubmit" CssClass="btn btn-success" runat="server" Text="Submit" OnClick="CmdSubmit_Click" />
                                                   <%-- <asp:Button ID="CmdReset" CssClass="Button" runat="server" Text="Clear" OnClick="CmdReset_Click" />--%>

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

