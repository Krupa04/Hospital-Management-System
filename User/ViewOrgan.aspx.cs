using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ViewOrgan : System.Web.UI.Page
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
        SqlCommand command = new SqlCommand("select U.name,U.natproblem,U.dob,U.mailid,U.mobileno,O.Parts,o.BloodGroup from Organ o join UserReg u on o.Patientid=u.id", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ViewDoctor.DataSource = ds.Tables[0];
        ViewDoctor.DataBind();
    }

}