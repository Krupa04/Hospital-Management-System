<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Admin.master" AutoEventWireup="true" CodeFile="AddSupplier.aspx.cs" Inherits="Admin_AddSupplier" %>

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
                    <li class="active">Supplier</li>
                </ul>

            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Dashboard
				        <small>
                            <i class="ace-icon fa fa-angle-double-right"></i>
                            Add  Supplier
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
                                    <h4 class="widget-title">Supplier Details</h4>

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
                                          <%--  <tr>
                                                <td>Supplierid</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toLowerCase();' ID="txtSupplierid"  runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>--%>

                                            <tr>
                                                <td>Name</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" onKeyUp='this.value = this.value.toLowerCase();' ID="txtUserName" runat="server" required="true"></asp:TextBox>
                                                </td>
                                            </tr>

                                                   <tr>
                                                <td>Date Of Birth</td>
                                                <td>
                                                    <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker" ID="txtDateOfBirth" data-date-format="dd/mm/yyyy" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Gender</td>
                                                <td>
                                                    <div class="radio">
													<label>
													

                                                        <asp:RadioButtonList runat="server"  ID="rdbGender" required="true">
                                                        <asp:ListItem Text="Male" />
                                                        <asp:ListItem Text="Female" />
                                                    </asp:RadioButtonList>

													</label>
												</div>

											
                                                </td>
                                            </tr>

                                     
                                       
                                            <tr>
                                                <td>Email</td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" ID="txtEmail" />
                                                </td>
                                            </tr>
                                                 <tr>
                                                <td>Mobile</td>
                                                <td>
                                                    <asp:TextBox CssClass="form-control" ID="txtMobile" pattern="\d{10}" title="Please enter exactly 10 digits" MaxLength="10" required="true" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Address </td>
                                                <td>
                                                    <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" ID="txtAddress" />
                                                </td>
                                            </tr>
                                          <tr>
                                                <td>State</td>
                                                <td>
                                                   <%-- <asp:TextBox runat="server" CssClass="form-control" ID="txtState" />--%>
                                                     <asp:DropDownList runat="server" ID="ddlState" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>City</td>
                                                <td>
                                                  <%--  <asp:TextBox runat="server" CssClass="form-control" ID="txtcity" />--%>
                                                    <asp:DropDownList runat="server" ID="ddlCity" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                    
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button Text="Submit" ID="Submit" CssClass="btn btn-success" Onclick="Submit_Click" runat="server" />
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

