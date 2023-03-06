using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();
    int age1;
    string userid;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        string age2 = _nxthelper.getddmmyyyy(txtDateOfbirth.Text);
        DateTime age3 = Convert.ToDateTime(age2);
        int age1 = CalculateAge(age3);

        try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from UserReg where name='" + txtname.Text + "'", Conn);
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
                Random rand = new Random();
                userid = rand.Next(199, 999).ToString();

                string qry = "insert into UserReg values('"+ userid +"','" + txtname.Text + "','" + txtpassword.Text + "','" + txtnatproblem.Text + "','" + _nxthelper.getddmmyyyy(txtDateOfbirth.Text) + "','" + txtEmail.Text + "','" + txtMobile.Text + "','" + age1 + "')";
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
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    private static int CalculateAge(DateTime dateOfBirth)
    {
        int age = 0;
        age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            age = age - 1;

        return age;
    }

   
}