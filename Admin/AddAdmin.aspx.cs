using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddAdmin : System.Web.UI.Page
{
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Random ra = new Random(199,999);

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from Addadmin where UserName='" + txtUserName.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMessage.Text = "User Name already exist !!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dr.Close();
            }
            else
            {
                dr.Close();
                Conn.Close();
                Conn.Open();
                string qry = "insert into Addadmin(UserName,password,docname,dob,mobileno,email,Address,city,state,doj,qualification,designation) values('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + _nxthelper.getddmmyyyy(txtDateOfJoin.Text) + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtcity.Text + "','" + txtState.Text + "','" + _nxthelper.getddmmyyyy(txtDOJ.Text) + "','" + txtQualification.Text + "','" + txtDesignation.Text + "')";
                SqlCommand cmd2 = new SqlCommand(qry, Conn);
                cmd2.ExecuteNonQuery();
                lblMessage.Text = "Details Added Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                Conn.Close();
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;

        }
        finally { Conn.Close(); }
    }
}