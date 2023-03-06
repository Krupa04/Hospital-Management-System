using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();


    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        lblMessage.Visible = false;
        Random rand = new Random();
        Label1.Text = rand.Next(222, 99999).ToString();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (ddlLoginAs.SelectedValue == "1")
        {


            if (string.IsNullOrEmpty(TxtUN.Text) | string.IsNullOrEmpty(TxtPwd.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Enter Username and Passsword Properly to Proceed.');", true);
                return;
            }
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from [Addadmin] where UserName='" + TxtUN.Text + "' and password='" + TxtPwd.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Session["UserName"] = TxtUN.Text;
                Response.Redirect("~/Admin/Home.aspx");

            }
            else
            {
                Response.Write("Invalid User Name or Password");
            }



        }

        else if (ddlLoginAs.SelectedValue == "2")
        {

            if (string.IsNullOrEmpty(TxtUN.Text) | string.IsNullOrEmpty(TxtPwd.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Enter Username and Passsword Properly to Proceed.');", true);
                return;
            }
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from [Adddoctor] where UserName='" + TxtUN.Text + "' and password='" + TxtPwd.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Session["UserName"] = TxtUN.Text;
                Session["id"] = dr["Doc_ID"].ToString();
                Response.Redirect("~/Doctor/Home.aspx");

            }
            else
            {
                Response.Write("Invalid User Name or Password");
            }
        }
        else if (ddlLoginAs.SelectedValue == "3")
        {
            if (string.IsNullOrEmpty(TxtUN.Text) | string.IsNullOrEmpty(TxtPwd.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Enter Username and Passsword Properly to Proceed.');", true);
                return;
            }
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from AddEmployee where name='" + TxtUN.Text + "' and password='" + TxtPwd.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Session["UserID"] = TxtUN.Text;
                Response.Redirect("~/Employee/Home.aspx");

            }
            else
            {
                Response.Write("Invalid User Name or Password");
            }

            if (TxtUN.Text.ToLower() == "Emp" & TxtPwd.Text.ToLower() == "Emp")
            {
                Response.Redirect("#");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Invalid Authentication.');", true);
            }
        }

        else if (ddlLoginAs.SelectedValue == "4")
        {
            if (string.IsNullOrEmpty(TxtUN.Text) | string.IsNullOrEmpty(TxtPwd.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Enter Username and Passsword Properly to Proceed.');", true);
                return;
            }
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from UserReg where name='" + TxtUN.Text + "' and password='" + TxtPwd.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Session["id"] = dr["id"].ToString();
                Session["Username"] = TxtUN.Text;
                Response.Redirect("~/User/User_Home.aspx");

            }
            else
            {
                Response.Write("Invalid User Name or Password");
            }

        } //Response.Redirect("Admin/Home.aspx");
    }
    protected void btnforgot_Click(object sender, System.EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from UserReg where mailid='" + TextBox1.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Conn = new SqlConnection(ConnString);
                Conn.Open();
                string qry = "update UserReg set password ='" + Label1.Text + "' where mailid='" + TextBox1.Text + "'";
                cmd = new SqlCommand(qry, Conn);
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Your Password reset successfully";
                _nxthelper.sendMail(TextBox1.Text, "Your Password reset successfully...", "Your New Pssword :'" + Label1.Text + "'");
                lblMessage.ForeColor = System.Drawing.Color.Green;
                Conn.Close();

            }
            else
            {
                Response.Write("Invalid User Name or Mail Id");
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