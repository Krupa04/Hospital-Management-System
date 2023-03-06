<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta charset="utf-8" />
    <title>Login Page</title>

    <meta name="description" content="User login page" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />

    <!-- bootstrap & fontawesome -->
    <link rel="stylesheet" href="/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/font-awesome/4.5.0/css/font-awesome.min.css" />

    <!-- text fonts -->
    <link rel="stylesheet" href="/css/fonts.googleapis.com.css" />




    <!-- ace styles -->
    <link rel="stylesheet" href="/css/ace.min.css" />

    <!--[if lte IE 9]>
			<link rel="stylesheet" href="/css/ace-part2.min.css" />
		<![endif]-->
    <link rel="stylesheet" href="/css/ace-rtl.min.css" />

    
    <meta name="description" content="overview &amp; stats" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />

    <!-- bootstrap & fontawesome -->
    <link rel="stylesheet" href="/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/font-awesome/4.5.0/css/font-awesome.min.css" />


    <link rel="stylesheet" href="/css/jquery-ui.custom.min.css" />
    <link rel="stylesheet" href="/css/chosen.min.css" />
    <link rel="stylesheet" href="/css/bootstrap-datepicker3.min.css" />
    <link rel="stylesheet" href="/css/bootstrap-timepicker.min.css" />
    <link rel="stylesheet" href="/css/daterangepicker.min.css" />
    <link rel="stylesheet" href="/css/bootstrap-datetimepicker.min.css" />
    <link rel="stylesheet" href="/css/bootstrap-colorpicker.min.css" />
    <!-- text fonts -->
    <link rel="stylesheet" href="/css/fonts.googleapis.com.css" />

    <!-- ace styles -->
    <link rel="stylesheet" href="..//css/ace.min.css" class="ace-main-stylesheet" />

    <!--[if lte IE 9]>
			<link rel="stylesheet" href="..//css/ace-part2.min.css" class="ace-main-stylesheet" />
		<![endif]-->
    <link rel="stylesheet" href="/css/ace-skins.min.css" />
    <link rel="stylesheet" href="/css/ace-rtl.min.css" />

    <!--[if lte IE 9]>
		  <link rel="stylesheet" href="..//css/ace-ie.min.css" />
		<![endif]-->

    <!-- inline styles related to this page -->

    <!-- ace settings handler -->
    <script src="/js/ace-extra.min.js"></script>

   <script language="Javascript" type="text/javascript">

       function onlyAlphabets(e, t) {
           try {
               if (window.event) {
                   var charCode = window.event.keyCode;
               }
               else if (e) {
                   var charCode = e.which;
               }
               else { return true; }
               if ((charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 123))
                   return true;
               else
                   return false;
           }
           catch (err) {
               alert(err.Description);
           }
       }

    </script>

</head>
<body class="login-layout">
    <div class="main-container">
        <div class="main-content">
            <div class="row">
                <div class="col-sm-10 col-sm-offset-1">
                    <div class="login-container">
                        <div class="center">
                            <h1>
                                <i class="ace-icon fa fa-leaf green"></i>
                                <span class="red"> BCA </span>
                                <span class="white" id="id-text2">Medical Center</span>
                            </h1>
                            <h4 class="blue" id="id-company-text">&copy; BCA Medical Center</h4>
                        </div>

                        <div class="space-6"></div>

                        <div class="position-relative">
                            <div id="login-box" class="login-box visible widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header blue lighter bigger">
                                            <i class="ace-icon fa fa-coffee green"></i>
                                            Please Enter Your Information
                                        </h4>

                                        <div class="space-6"></div>

                                         <form id="Form1" runat="server">
                                            

                                             <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                       <%-- <input type="text" />--%>
                                                       
                                                        <asp:Label Text="" runat="server" ID="lblMessage" />
                                                    </span>
                                                </label>

                                              

                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                       <%-- <input type="text" />--%>
                                                        <asp:TextBox runat="server" class="form-control" ID="txtname" onkeypress="return onlyAlphabets(event,this);" pattern="[A-Za-z]{0}{15}" title="Please enter Char only"  placeholder="User" required="true"  />
                                                        <i class="ace-icon fa fa-user"></i>
                                                    </span>
                                                </label>

                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                       <%-- <input type="password"  />--%>
                                                        <asp:TextBox runat="server" class="form-control" ID="txtpassword" required="" TextMode="Password" placeholder="Password" />
                                                        <i class="ace-icon fa fa-lock"></i>
                                                    </span>
                                                </label>


                                               <%--  <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <input type="password" class="form-control" placeholder="Repeat password" />

                                                        <i class="ace-icon fa fa-retweet"></i>
                                                    </span>
                                                </label>--%>




                                                 <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                      <%--  <input type="text"  />--%>
                                                        <asp:TextBox runat="server" class="form-control" ID="txtnatproblem" required="" placeholder="Nature of Problem" />
                                                        <i class="ace-icon fa fa-user"></i>
                                                    </span>
                                                </label>

                                               
                                                 <label class="block clearfix">
                                                  
                                                      <%--  <input type="text" class="form-control"  />--%>
                                                         <div class="input-group">
                                                        <asp:TextBox runat="server" CssClass="form-control date-picker"  placeholder="Date Of Birth"   ID="txtDateOfbirth" data-date-format="dd/mm/yyyy" required="" />
                                                        <span class="input-group-addon">
                                                            <i class="fa fa-calendar bigger-110"></i>
                                                        </span>
                                                    </div>
                                                        <%--<i class="ace-icon fa fa-envelope"></i>--%>
                                                    
                                                </label>
                                             <%-- <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <%--<input type="text" />
                                                        <asp:TextBox runat="server" class="form-control" ID="txtAge" pattern="\d{10}" title="Please enter exactly 3 digits"  MaxLength="2"  placeholder="Age" required="" />
                                                        <i class="ace-icon fa  fa-circle-o"></i>
                                                    </span>
                                                </label>--%>


                                                  <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <%--<input type="email" class="form-control" placeholder="Email" />--%>
                                                        <asp:TextBox runat="server" class="form-control" ID="txtEmail" placeholder="Email" TextMode="Email" required=""/>
                                                        <i class="ace-icon fa fa-envelope"></i>
                                                    </span>
                                                </label>


                                                 <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <%--<input type="text" class="form-control" placeholder="Mobile No" />--%>
                                                        <asp:TextBox runat="server" class="form-control" ID="txtMobile"  placeholder="Mobile No" pattern="\d{10}" title="Please enter exactly 10 digits"  MaxLength="10" required=""/>
                                                        <i class="ace-icon fa 	fa-certificate"></i>
                                                    </span>
                                                </label>

                                                  


                                               <%-- <label class="block">
                                                    <input type="checkbox" class="ace" />
                                                    <span class="lbl">I accept the
															<a href="#">User Agreement</a>
                                                    </span>
                                                </label>--%>

                                                <div class="space-24"> </div>

                                                <div class="clearfix">
                                                   

                                              <asp:Button ID="btnLogin" Text="Login" class="width-30 pull-left btn btn-sm" OnClick="btnLogin_Click" runat="server" />


                                                   
                                                         <asp:Button ID="BtnRegister" Text="Register" class="width-65 pull-right btn btn-sm btn-success" OnClick="BtnRegister_Click" runat="server" />


                                                       

                                                      
                                                    <%--</button>--%>
                                                </div>
                                           
                                        </form>

                                        <%--<form id="Form1" runat="server">
                                            <fieldset>

                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlLoginAs">
                                                            <asp:ListItem Text="Admin" Value="1" />
                                                            <asp:ListItem Text="Doctor" Value="2" />
                                                            <asp:ListItem Text="Employee" Value="3" />
                                                            <asp:ListItem Text="Patient" Value="4" />
                                                        </asp:DropDownList>
                                                    </span>
                                                </label>

                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <asp:TextBox runat="server" ID="TxtUN" CssClass="form-control" placeholder="Username" />
                                                        <i class="ace-icon fa fa-user"></i>
                                                    </span>
                                                </label>

                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <asp:TextBox runat="server" ID="TxtPwd" TextMode="Password" CssClass="form-control" placeholder="Password" />
                                                        <i class="ace-icon fa fa-lock"></i>
                                                    </span>
                                                </label>

                                                <div class="space"></div>

                                                <div class="clearfix">
                                                    <label class="inline">
                                                    </label>

                                                    <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click" CssClass="width-35 pull-right btn btn-sm btn-primary" />
                                                </div>

                                                <div class="space-4"></div>
                                            </fieldset>
                                        </form>--%>


                                    </div>
                                    <!-- /.widget-main -->

                                   <%-- <div class="toolbar clearfix">
                                        <div>
                                            <%-- <a href="#" data-target="#forgot-box" class="forgot-password-link">
                                                <i class="ace-icon fa fa-arrow-left"></i>
                                                I forgot my password
                                            </a>
                                        </div>

                                        <div>
                                            <a href="" data-target="#signup-box" class="user-signup-link">I want to register
													<i class="ace-icon fa fa-arrow-right"></i>
                                            </a>

                                        </div>

                                    </div>--%>
                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.login-box -->

                          <%--  <div id="forgot-box" class="forgot-box widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header red lighter bigger">
                                            <i class="ace-icon fa fa-key"></i>
                                            Retrieve Password
                                        </h4>

                                        <div class="space-6"></div>
                                        <p>
                                            Enter your email and to receive instructions
                                        </p>

                                        <form>
                                            <fieldset>
                                                <label class="block clearfix">
                                                    <span class="block input-icon input-icon-right">
                                                        <input type="email" class="form-control" placeholder="Email" />
                                                        <i class="ace-icon fa fa-envelope"></i>
                                                    </span>
                                                </label>

                                                <div class="clearfix">
                                                    <button type="button" class="width-35 pull-right btn btn-sm btn-danger">
                                                        <i class="ace-icon fa fa-lightbulb-o"></i>
                                                        <span class="bigger-110">Send Me!</span>
                                                    </button>
                                                </div>
                                            </fieldset>
                                        </form>
                                    </div>
                                    <!-- /.widget-main -->

                                    <div class="toolbar center">
                                        <a href="#" data-target="#login-box" class="back-to-login-link">Back to login
												<i class="ace-icon fa fa-arrow-right"></i>
                                        </a>
                                    </div>
                                </div>
                                <!-- /.widget-body -->
                            </div>--%>
                            <!-- /.forgot-box -->

                            <div  class="signup-box widget-box no-border">
                                <div class="widget-body">
                                    <div class="widget-main">
                                        <h4 class="header green lighter bigger">
                                            <i class="ace-icon fa fa-users blue"></i>
                                            New User Registration
                                        </h4>

                                        <div class="space-6"></div>
                                        <p>Enter your details to begin: </p>

                                       
                                    </div>

                                    <div class="toolbar center">
                                        <a href="#" data-target="#login-box" class="back-to-login-link">
                                            <i class="ace-icon fa fa-arrow-left"></i>
                                            Back to login
                                        </a>
                                    </div>
                                </div>
                                <!-- /.widget-body -->
                            </div>
                            <!-- /.signup-box -->
                        </div>
                        <!-- /.position-relative -->

                        <div class="navbar-fixed-top align-right">
                            <br />
                            &nbsp;
								<a id="btn-login-dark" href="#">Dark</a>
                            &nbsp;
								<span class="blue">/</span>
                            &nbsp;
								<a id="btn-login-blur" href="#">Blur</a>
                            &nbsp;
								<span class="blue">/</span>
                            &nbsp;
								<a id="btn-login-light" href="#">Light</a>
                            &nbsp; &nbsp; &nbsp;
                        </div>
                    </div>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.main-content -->
    </div>
    <!-- /.main-container -->

    <!-- basic scripts -->

    <!--[if !IE]> -->
    <script src="/js/jquery-2.1.4.min.js"></script>

    <!-- <![endif]-->

    <!--[if IE]>
<script src="/js/jquery-1.11.3.min.js"></script>
<![endif]-->
    <script type="text/javascript">
        if ('ontouchstart' in document.documentElement) document.write("<script src='/js/jquery.mobile.custom.min.js'>" + "<" + "/script>");
    </script>

    <!-- inline scripts related to this page -->
    <script type="text/javascript">
        jQuery(function ($) {
            $(document).on('click', '.toolbar a[data-target]', function (e) {
                e.preventDefault();
                var target = $(this).data('target');
                $('.widget-box.visible').removeClass('visible');//hide others
                $(target).addClass('visible');//show target
            });
        });



        //you don't need this, just used for changing background
        jQuery(function ($) {
            $('#btn-login-dark').on('click', function (e) {
                $('body').attr('class', 'login-layout');
                $('#id-text2').attr('class', 'white');
                $('#id-company-text').attr('class', 'blue');

                e.preventDefault();
            });
            $('#btn-login-light').on('click', function (e) {
                $('body').attr('class', 'login-layout light-login');
                $('#id-text2').attr('class', 'grey');
                $('#id-company-text').attr('class', 'blue');

                e.preventDefault();
            });
            $('#btn-login-blur').on('click', function (e) {
                $('body').attr('class', 'login-layout blur-login');
                $('#id-text2').attr('class', 'white');
                $('#id-company-text').attr('class', 'light-blue');

                e.preventDefault();
            });

        });
    </script>
     <script src="..//js/jquery-2.1.4.min.js"></script>

        <!-- <![endif]-->

        <!--[if IE]>
<script src="..//js/jquery-1.11.3.min.js"></script>
<![endif]-->
        <script type="text/javascript">
            if ('ontouchstart' in document.documentElement) document.write("<script src='..//js/jquery.mobile.custom.min.js'>" + "<" + "/script>");
        </script>
        <script src="..//js/bootstrap.min.js"></script>

        <!-- page specific plugin scripts -->

        <!--[if lte IE 8]>
		  <script src="..//js/excanvas.min.js"></script>
		<![endif]-->

        <script src="/js/jquery-ui.custom.min.js"></script>
        <script src="/js/jquery.ui.touch-punch.min.js"></script>
        <script src="/js/chosen.jquery.min.js"></script>
        <script src="/js/spinbox.min.js"></script>
        <script src="/js/bootstrap-datepicker.min.js"></script>
        <script src="/js/bootstrap-timepicker.min.js"></script>
        <script src="/js/moment.min.js"></script>
        <script src="/js/daterangepicker.min.js"></script>
        <script src="/js/bootstrap-datetimepicker.min.js"></script>
        <script src="/js/bootstrap-colorpicker.min.js"></script>
        <script src="/js/jquery.knob.min.js"></script>
        <script src="/js/autosize.min.js"></script>
        <script src="/js/jquery.inputlimiter.min.js"></script>
        <script src="/js/jquery.maskedinput.min.js"></script>
        <script src="/js/bootstrap-tag.min.js"></script>
        <script src="/js/jquery.dataTables.min.js"></script>
        <script src="/js/jquery.dataTables.bootstrap.min.js"></script>
        <script src="/js/dataTables.select.min.js"></script>

        <!-- ace scripts -->
        <script src="/js/ace-elements.min.js"></script>
        <script src="/js/ace.min.js"></script>

        <!-- inline scripts related to this page -->
        <script type="text/javascript">
            jQuery(function ($) {


                $('.easy-pie-chart.percentage').each(function () {
                    var $box = $(this).closest('.infobox');
                    var barColor = $(this).data('color') || (!$box.hasClass('infobox-dark') ? $box.css('color') : 'rgba(255,255,255,0.95)');
                    var trackColor = barColor == 'rgba(255,255,255,0.95)' ? 'rgba(255,255,255,0.25)' : '#E2E2E2';
                    var size = parseInt($(this).data('size')) || 50;
                    $(this).easyPieChart({
                        barColor: barColor,
                        trackColor: trackColor,
                        scaleColor: false,
                        lineCap: 'butt',
                        lineWidth: parseInt(size / 10),
                        animate: ace.vars['old_ie'] ? false : 1000,
                        size: size
                    });
                })

                $('.sparkline').each(function () {
                    var $box = $(this).closest('.infobox');
                    var barColor = !$box.hasClass('infobox-dark') ? $box.css('color') : '#FFF';
                    $(this).sparkline('html',
                                     {
                                         tagValuesAttribute: 'data-values',
                                         type: 'bar',
                                         barColor: barColor,
                                         chartRangeMin: $(this).data('min') || 0
                                     });
                });


                //flot chart resize plugin, somehow manipulates default browser resize event to optimize it!
                //but sometimes it brings up errors with normal resize event handlers
                //$.resize.throttleWindow = false;



                $('.date-picker').datepicker({
                    autoclose: true,
                    todayHighlight: true
                })
				//show datepicker when clicking on the icon
				.next().on(ace.click_event, function () {
				    $(this).prev().focus();
				});

                //or change it into a date range picker
                $('.input-daterange').datepicker({ autoclose: true });


                //to translate the daterange picker, please copy the "examples/daterange-fr.js" contents here before initialization
                $('input[name=date-range-picker]').daterangepicker({
                    'applyClass': 'btn-sm btn-success',
                    'cancelClass': 'btn-sm btn-default',
                    locale: {
                        applyLabel: 'Apply',
                        cancelLabel: 'Cancel',
                    }
                })
				.prev().on(ace.click_event, function () {
				    $(this).next().focus();
				});


            })

            jQuery(function ($) {
                //initiate dataTables plugin
                var myTable =
                $('#dynamic-table')
                //.wrap("<div class='dataTables_borderWrap' />")   //if you are applying horizontal scrolling (sScrollX)
                .DataTable({
                    bAutoWidth: false,
                    "aoColumns": [
                      { "bSortable": false },
                      null, null, null, null, null,
                      { "bSortable": false }
                    ],
                    "aaSorting": [],

                    select: {
                        style: 'multi'
                    }
                });



                //$.fn.dataTable.Buttons.defaults.dom.container.className = 'dt-buttons btn-overlap btn-group btn-overlap';

                //new $.fn.dataTable.Buttons(myTable, {
                //    buttons: [
                //      {
                //          "extend": "colvis",
                //          "text": "<i class='fa fa-search bigger-110 blue'></i> <span class='hidden'>Show/hide columns</span>",
                //          "className": "btn btn-white btn-primary btn-bold",
                //          columns: ':not(:first):not(:last)'
                //      },
                //      {
                //          "extend": "copy",
                //          "text": "<i class='fa fa-copy bigger-110 pink'></i> <span class='hidden'>Copy to clipboard</span>",
                //          "className": "btn btn-white btn-primary btn-bold"
                //      },
                //      {
                //          "extend": "csv",
                //          "text": "<i class='fa fa-database bigger-110 orange'></i> <span class='hidden'>Export to CSV</span>",
                //          "className": "btn btn-white btn-primary btn-bold"
                //      },
                //      {
                //          "extend": "excel",
                //          "text": "<i class='fa fa-file-excel-o bigger-110 green'></i> <span class='hidden'>Export to Excel</span>",
                //          "className": "btn btn-white btn-primary btn-bold"
                //      },
                //      {
                //          "extend": "pdf",
                //          "text": "<i class='fa fa-file-pdf-o bigger-110 red'></i> <span class='hidden'>Export to PDF</span>",
                //          "className": "btn btn-white btn-primary btn-bold"
                //      },
                //      {
                //          "extend": "print",
                //          "text": "<i class='fa fa-print bigger-110 grey'></i> <span class='hidden'>Print</span>",
                //          "className": "btn btn-white btn-primary btn-bold",
                //          autoPrint: false,
                //          message: 'This print was produced using the Print button for DataTables'
                //      }
                //    ]
                //});
                //myTable.buttons().container().appendTo($('.tableTools-container'));

                //style the message box
                //var defaultCopyAction = myTable.button(1).action();
                //myTable.button(1).action(function (e, dt, button, config) {
                //    defaultCopyAction(e, dt, button, config);
                //    $('.dt-button-info').addClass('gritter-item-wrapper gritter-info gritter-center white');
                //});


                //var defaultColvisAction = myTable.button(0).action();
                //myTable.button(0).action(function (e, dt, button, config) {

                //    defaultColvisAction(e, dt, button, config);


                //    if ($('.dt-button-collection > .dropdown-menu').length == 0) {
                //        $('.dt-button-collection')
                //        .wrapInner('<ul class="dropdown-menu dropdown-light dropdown-caret dropdown-caret" />')
                //        .find('a').attr('href', '#').wrap("<li />")
                //    }
                //    $('.dt-button-collection').appendTo('.tableTools-container .dt-buttons')
                //});

                ////

                setTimeout(function () {
                    $($('.tableTools-container')).find('a.dt-button').each(function () {
                        var div = $(this).find(' > div').first();
                        if (div.length == 1) div.tooltip({ container: 'body', title: div.parent().text() });
                        else $(this).tooltip({ container: 'body', title: $(this).text() });
                    });
                }, 500);





                myTable.on('select', function (e, dt, type, index) {
                    if (type === 'row') {
                        $(myTable.row(index).node()).find('input:checkbox').prop('checked', true);
                    }
                });
                myTable.on('deselect', function (e, dt, type, index) {
                    if (type === 'row') {
                        $(myTable.row(index).node()).find('input:checkbox').prop('checked', false);
                    }
                });




                /////////////////////////////////
                //table checkboxes
                $('th input[type=checkbox], td input[type=checkbox]').prop('checked', false);

                //select/deselect all rows according to table header checkbox
                $('#dynamic-table > thead > tr > th input[type=checkbox], #dynamic-table_wrapper input[type=checkbox]').eq(0).on('click', function () {
                    var th_checked = this.checked;//checkbox inside "TH" table header

                    $('#dynamic-table').find('tbody > tr').each(function () {
                        var row = this;
                        if (th_checked) myTable.row(row).select();
                        else myTable.row(row).deselect();
                    });
                });

                //select/deselect a row when the checkbox is checked/unchecked
                $('#dynamic-table').on('click', 'td input[type=checkbox]', function () {
                    var row = $(this).closest('tr').get(0);
                    if (this.checked) myTable.row(row).deselect();
                    else myTable.row(row).select();
                });



                $(document).on('click', '#dynamic-table .dropdown-toggle', function (e) {
                    e.stopImmediatePropagation();
                    e.stopPropagation();
                    e.preventDefault();
                });



                //And for the first simple table, which doesn't have TableTools or dataTables
                //select/deselect all rows according to table header checkbox
                var active_class = 'active';
                $('#simple-table > thead > tr > th input[type=checkbox]').eq(0).on('click', function () {
                    var th_checked = this.checked;//checkbox inside "TH" table header

                    $(this).closest('table').find('tbody > tr').each(function () {
                        var row = this;
                        if (th_checked) $(row).addClass(active_class).find('input[type=checkbox]').eq(0).prop('checked', true);
                        else $(row).removeClass(active_class).find('input[type=checkbox]').eq(0).prop('checked', false);
                    });
                });

                //select/deselect a row when the checkbox is checked/unchecked
                $('#simple-table').on('click', 'td input[type=checkbox]', function () {
                    var $row = $(this).closest('tr');
                    if ($row.is('.detail-row ')) return;
                    if (this.checked) $row.addClass(active_class);
                    else $row.removeClass(active_class);
                });



                /********************************/
                //add tooltip for small view action buttons in dropdown menu
                $('[data-rel="tooltip"]').tooltip({ placement: tooltip_placement });

                //tooltip placement on right or left
                function tooltip_placement(context, source) {
                    var $source = $(source);
                    var $parent = $source.closest('table')
                    var off1 = $parent.offset();
                    var w1 = $parent.width();

                    var off2 = $source.offset();
                    //var w2 = $source.width();

                    if (parseInt(off2.left) < parseInt(off1.left) + parseInt(w1 / 2)) return 'right';
                    return 'left';
                }




                /***************/
                $('.show-details-btn').on('click', function (e) {
                    e.preventDefault();
                    $(this).closest('tr').next().toggleClass('open');
                    $(this).find(ace.vars['.icon']).toggleClass('fa-angle-double-down').toggleClass('fa-angle-double-up');
                });
                /***************/





                /**
                //add horizontal scrollbars to a simple table
                $('#simple-table').css({'width':'2000px', 'max-width': 'none'}).wrap('<div style="width: 1000px;" />').parent().ace_scroll(
                  {
                    horizontal: true,
                    styleClass: 'scroll-top scroll-dark scroll-visible',//show the scrollbars on top(default is bottom)
                    size: 2000,
                    mouseWheelLock: true
                  }
                ).css('padding-top', '12px');
                */


            })
        </script>
</body>
</html>
