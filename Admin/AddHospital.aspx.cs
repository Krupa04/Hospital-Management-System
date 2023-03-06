using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddHospital : System.Web.UI.Page
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
            _nxthelper.DdlFill(ddlBranch, "ddl_Search_Branch", "Name", "id", false);
           

            Random rand = new Random();
            txtid.Text = rand.Next(199, 999).ToString();
        }

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        //try
        //{
        //    Conn = new SqlConnection(ConnString);

        //    Conn.Open();
        //    string qry = "insert into AddHospital(Name,Branchid,Address,Mailid,MobileNo) values('" + txtName.Text + "','" + ddlBranch.SelectedItem.Value+ "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtMobileNo.Text + "')";
        //    SqlCommand cmd2 = new SqlCommand(qry, Conn);
        //    cmd2.ExecuteNonQuery();
        //    lblMessage.Text = "Details Added Successfully";
        //    lblMessage.ForeColor = System.Drawing.Color.Green;
        //    Conn.Close();
        //}
        //catch (Exception ex)
        //{
        //    lblMessage.Text = ex.Message.Replace("'", "");
        //    lblMessage.ForeColor = System.Drawing.Color.Red;

        //}
        //finally { Conn.Close(); }



        try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from AddHospital where Name='" + txtName.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMessage.Text = "Name already exist !!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dr.Close();
            }
            else
            {
                dr.Close();
                Conn.Close();
                Conn.Open();
                string qry = "insert into AddHospital(id,Name,Branchid,Address,Mailid,MobileNo) values('" + txtid.Text + "','" + txtName.Text + "','" + ddlBranch.SelectedItem.Value + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtMobileNo.Text + "')";
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