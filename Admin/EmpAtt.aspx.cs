using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Globalization;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Globalization;

public partial class Admin_EmpAtt : System.Web.UI.Page
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
            pro1();
            bindYear();

        }
    }
    private void bindYear()
    {
        ddlYear.Items.Clear();
        ddlYear.Items.Add(string.Empty);
        for (int Year = 2014; Year <= 2045; Year++)
        {
            ddlYear.Items.Add(Year.ToString());
        }
        ddlYear.Text = DateTime.Now.Year.ToString();
        ddlYear.Items.Remove(ddlYear.Items.FindByText(""));

        DateTimeFormatInfo info = DateTimeFormatInfo.GetInstance(null);


        for (int i = 1; i < 13; i++)
        {
            ddlMonth.Items.Add(new ListItem(info.GetMonthName(i), i.ToString()));
        }

        for (int i = 1; i < 31; i++)
        {
            ddlDay.Items.Add(i.ToString());
        }


    }

    protected void pro1()
    {

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("select * from AddEmployee");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = Conn;
        Conn.Open();
        ddlEmpName.DataSource = cmd.ExecuteReader();
        ddlEmpName.DataTextField = "name";
        ddlEmpName.DataValueField = "Emp_Id";
        ddlEmpName.DataBind();
        Conn.Close();

    }


    protected void Submit_Click(object sender, System.EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from EmpAtt where Attdate='" + ddlDay.SelectedItem.Text + "' and Attmonth='" + ddlMonth.SelectedItem.Text + "' and year='" + ddlYear.SelectedItem.Text + "' and Empid='" + ddlEmpName.SelectedValue + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMessage.Text = "Attendance Already Taken !!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dr.Close();
            }
            else
            {
                dr.Close();
                Conn.Close();
                Conn.Open();
                string qry = "insert into EmpAtt  (Empid,Attdate,Attmonth,year) values  ('" + ddlEmpName.SelectedValue + "','" + ddlDay.SelectedItem.Text + "','" + ddlMonth.SelectedItem.Text + "','" + ddlYear.SelectedItem.Text + "')";
                SqlCommand cmd2 = new SqlCommand(qry, Conn);
                cmd2.ExecuteNonQuery();
                lblMessage.Text = " Attendance Details Added Successfully";
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