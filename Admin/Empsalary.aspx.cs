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

public partial class Admin_Empsalary : System.Web.UI.Page
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
            SearchMainTitle();

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



    }

    protected void grdMainTitle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;
    }

    public void SearchMainTitle()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select Emp_id,month,salary,no_of_day,total from Empsalary", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dynamictable.DataSource = ds.Tables[0];
        dynamictable.DataBind();

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
        txtTotal.Text = "";
        //txtSalary.Text = "";

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("Select PerDaysal from AddEmployee where Emp_Id=" + ddlEmpName.SelectedValue, Conn);
        Conn.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            txtSalary.Text = dr["PerDaysal"].ToString();

        }

        Conn.Close();


        if (!string.IsNullOrEmpty(txtSalary.Text))
        {
            Conn = new SqlConnection(ConnString);
            Conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from EmpAtt where Attmonth = '" + ddlMonth.SelectedItem.Text + "' and year='" + ddlYear.SelectedItem.Text + "'  and Empid='" + ddlEmpName.SelectedValue + "' ", Conn);
            DataSet st = new DataSet();
            adp.Fill(st);
            lblNoOfDays.Text = st.Tables[0].Rows.Count.ToString();

            lblMessage.Text = "";
            txtTotal.Text = (st.Tables[0].Rows.Count * Convert.ToInt16(txtSalary.Text)).ToString();
        }
        else
        {

            //lblmessage.Text = "Enter Value for Salar";
            //lblmessage.ForeColor = System.Drawing.Color.Red;

        }
    }
    protected void btnSave_Click(object sender, System.EventArgs e)
    {
         try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from Empsalary where  month='" + ddlMonth.SelectedItem.Text + "' and year='" + ddlYear.SelectedItem.Text + "' and Emp_id='" + ddlEmpName.SelectedValue + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMessage.Text = "Employee Salary Already Credited !!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dr.Close();
            }
            else
            {
                dr.Close();
                Conn.Close();
                Conn.Open();
                string qry = "insert into Empsalary  (Emp_id,month,year,salary,no_of_day,total) values  ('" + ddlEmpName.SelectedValue + "','" + ddlMonth.SelectedItem.Text + "','" + ddlYear.SelectedItem.Text + "','" + txtSalary.Text + "','" + lblNoOfDays.Text + "','" + txtTotal.Text + "')";
                SqlCommand cmd2 = new SqlCommand(qry, Conn);
                cmd2.ExecuteNonQuery();
                lblMessage.Text = " Employee Salary Details Added Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                Conn.Close();

                txtTotal.Text = "";
                txtSalary.Text = "";
                bindYear();
                pro1();
                SearchMainTitle();
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