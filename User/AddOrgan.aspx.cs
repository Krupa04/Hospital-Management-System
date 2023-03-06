using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_AddOrgan : System.Web.UI.Page
{

    NxtHelper _nxthelper = new NxtHelper();
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;

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
        SqlCommand command = new SqlCommand("Select * from UserReg where id=" + Session["id"].ToString(), Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        lblName.Text = ds.Tables[0].Rows[0]["id"].ToString();
        lblMobile.Text = ds.Tables[0].Rows[0]["mobileno"].ToString();
    }

    protected void Submit_Click(object sender, EventArgs e)
    {

        try
        {
            Conn = new SqlConnection(ConnString);

            Conn.Open();
            string qry = "insert into Organ(Patientid,Parts,BloodGroup) values('" + Session["Username"].ToString() + "','" + ddlOrgan.SelectedItem.Text + "','" + txtBlood.Text + "')";
            SqlCommand cmd2 = new SqlCommand(qry, Conn);
            cmd2.ExecuteNonQuery();
            lblMessage.Text = "FeedBack Added Successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            Conn.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;

        }
        finally { Conn.Close(); }
    }
}