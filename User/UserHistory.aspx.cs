using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UserHistory : System.Web.UI.Page
{
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            SearchDoctor();

        }
    }

    public void SearchDoctor()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("select PatientId,natureofproblem,bloodtestno,xrayno,ctscan,prescription,comments,date from [dbo].[Patmaintains] where PatientId=" + Session["id"].ToString(), Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ViewDoctor.DataSource = ds.Tables[0];
        ViewDoctor.DataBind();
    }
}