using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddSupplier : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();
    string Gender;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // _nxthelper.DdlFill(ddlBranch, "ddl_Search_Branch", "Name", "id", false);
            _nxthelper.DdlFill(ddlState, "Select_State_Master", "NAME", "ID", true, "101", "@Id");
            // _nxthelper.DdlFill(ddlCity, "Select_City_Master", "NAME", "ID", true, state, "@Id");
           // Random rand = new Random();
            //txtid.Text = rand.Next(199, 999).ToString();
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
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from Supplier where Name='" + txtUserName.Text + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMessage.Text = "Supplier Name already exist !!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dr.Close();
            }
            else
            {
                dr.Close();
                Conn.Close();
                Conn.Open();
                if (rdbGender.SelectedValue == "Male")
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                string qry = "insert into Supplier (Name,DOB,Gender,Email,MobileNo,Address,State,City) values('" + txtUserName.Text + "','" + txtDateOfBirth.Text + "','" + Gender + "','" + txtEmail.Text + "','" + txtMobile.Text + "','" + txtAddress.Text + "','" + ddlState.SelectedItem.ToString() + "','" + ddlCity.SelectedItem.ToString() + "')";
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



    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadCity(ddlState.SelectedItem.Value);
    }
}