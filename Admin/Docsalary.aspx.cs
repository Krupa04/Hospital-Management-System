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
using System.Data;

public partial class Admin_Docsalary : System.Web.UI.Page
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

    protected void pro1()
    {

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("select * from Adddoctor");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = Conn;
        Conn.Open();
        ddlDoctorName.DataSource = cmd.ExecuteReader();
        ddlDoctorName.DataTextField = "docname";
        ddlDoctorName.DataValueField = "Doc_ID";
        ddlDoctorName.DataBind();
        Conn.Close();

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        txtTotal.Text = "";
        //txtSalary.Text = "";

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("Select PerDaysal from Adddoctor where Doc_ID=" + ddlDoctorName.SelectedValue, Conn);
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
            SqlDataAdapter adp = new SqlDataAdapter("select * from DocAtt where Attmonth = '" + ddlMonth.SelectedItem.Text + "' and year='" + ddlYear.SelectedItem.Text + "'  and Docid='" + ddlDoctorName.SelectedValue + "' ", Conn);
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


        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select * from Docsalary", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        grid_show.DataSource = ds.Tables[0];
        grid_show.DataBind();




    }

    public void SearchMainTitle()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select * from Docsalary", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        grid_show.DataSource = ds.Tables[0];
        grid_show.DataBind();

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            cmd = new SqlCommand("select * from Docsalary where  month='" + ddlMonth.SelectedItem.Text + "' and year='" + ddlYear.SelectedItem.Text + "' and Doc_id='" + ddlDoctorName.SelectedValue + "'", Conn);
            Conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMessage.Text = "Doctor Salary Already Credited !!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dr.Close();
            }
            else
            {
                dr.Close();
                Conn.Close();
                Conn.Open();
                string qry = "insert into Docsalary  (Doc_id,month,year,salary,no_of_day,total) values  ('" + ddlDoctorName.SelectedValue + "','" + ddlMonth.SelectedItem.Text + "','" + ddlYear.SelectedItem.Text + "','" + txtSalary.Text + "','" + lblNoOfDays.Text + "','" + txtTotal.Text + "')";
                SqlCommand cmd2 = new SqlCommand(qry, Conn);
                cmd2.ExecuteNonQuery();
                lblMessage.Text = " Doctor Salary Details Added Successfully";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                Conn.Close();

                txtTotal.Text = "";
                txtSalary.Text = "";
                bindYear();
                pro1();
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