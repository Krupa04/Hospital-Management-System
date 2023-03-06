using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_AddInPatient : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();
    string Gender;

    int age1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // _nxthelper.DdlFill(ddlBranch, "ddl_Search_Branch", "Name", "id", false);
            _nxthelper.DdlFill(ddlState, "Select_State_Master", "NAME", "ID", true, "101", "@Id");
            // _nxthelper.DdlFill(ddlCity, "Select_City_Master", "NAME", "ID", true, state, "@Id");
            Random rand = new Random();
            txtid.Text = rand.Next(199, 999).ToString();
        }
    }

    private void loadCity(string state)
    {
        _nxthelper.DdlFill(ddlCity, "Select_City_Master", "NAME", "ID", true, state, "@Id");
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {

            string age2 = _nxthelper.getddmmyyyy(txtDateOfBirth.Text);
            DateTime age3 = Convert.ToDateTime(age2);
            int age1 = CalculateAge(age3);


            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from Add_InPatient where name='" + txtUserName.Text + "'", Conn);
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
                if(rdbGender.SelectedValue=="Male")
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                string qry = "insert into Add_InPatient (id,name,dob,age,gender,mailid,mobileno,address,state,city,natproblem,ad_date) values('" + txtid.Text + "','" + txtUserName.Text + "','" + txtDateOfBirth.Text + "','" + age1 + "','" + Gender + "','" + txtEmail.Text + "','" + txtMobile.Text + "','" + txtAddress.Text + "','" + ddlState.SelectedItem.ToString() + "','" + ddlState.SelectedItem.ToString() + "','" + txtnatproblem.Text + "','" + txtAdmissiondate.Text + "')";
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

    private static int CalculateAge(DateTime dateOfBirth)
    {
        int age = 0;
        age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            age = age - 1;

        return age;
    }

    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadCity(ddlState.SelectedItem.Value);
    }
}