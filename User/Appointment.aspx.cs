using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class User_Appointment : System.Web.UI.Page
{
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlspecial_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("select * from [Adddoctor] where  specialization = '" + ddlspecial.SelectedItem.Text + "'");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = Conn;
        Conn.Open();
        ddlDoctorName.DataSource = cmd.ExecuteReader();
        ddlDoctorName.DataTextField = "docname";
        ddlDoctorName.DataValueField = "Doc_ID";
        ddlDoctorName.DataBind();
        Conn.Close();
    }
    protected void CmdSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            Conn.Open();
            string qry = "insert into Appointment values('" + Session["id"].ToString() + "','" + txtmobile.Text + "','" + txtage.Text + "','" + txtDateOfBirth.Text + "','" + ddlTime.Text + "','" + ddlDoctorName.Text + "','" + Session["Username"].ToString() + "')";
            cmd = new SqlCommand(qry, Conn);
            cmd.ExecuteNonQuery();
            lblMessage.Text = "Appointment Fixed Successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            Conn.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;

        }
    }
    protected void CmdReset_Click(object sender, EventArgs e)
    {

    }
} 