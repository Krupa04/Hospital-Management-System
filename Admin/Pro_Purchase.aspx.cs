using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pro_Purchase : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();
    string Gender;
    StringBuilder sb = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pro1();
            pro12();
        }
    }

    protected void pro1()
    {

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("select * from Product");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = Conn;
        Conn.Open();
        ddlProduct.DataSource = cmd.ExecuteReader();
        ddlProduct.DataTextField = "Name";
        ddlProduct.DataValueField = "id";
        ddlProduct.DataBind();
        Conn.Close();

    }

    protected void pro12()
    {

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("select * from Supplier");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = Conn;
        Conn.Open();
        ddlSupplier.DataSource = cmd.ExecuteReader();
        ddlSupplier.DataTextField = "Name";
        ddlSupplier.DataValueField = "id";
        ddlSupplier.DataBind();
        Conn.Close();

    }


    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            Conn.Open();
            string qry = "insert into Purchase(Productid,supId,Qty,Price) values('" + ddlProduct.SelectedValue.ToString() + "','" + ddlSupplier.SelectedValue.ToString() + "','" + txtQty.Text + "','" + txtPrice.Text + "')";
            SqlCommand cmd2 = new SqlCommand(qry, Conn);
            cmd2.ExecuteNonQuery();
            lblMessage.Text = "Details Added Successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            Conn.Close();

        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;

        }
        finally { Conn.Close(); }
    }
}