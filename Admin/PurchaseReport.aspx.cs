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

public partial class Admin_PurchaseReport : System.Web.UI.Page
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
            //pro1();
            pro12();
            //LoadData1();
        }
    }

    //protected void pro1()
    //{

    //    Conn = new SqlConnection(ConnString);
    //    cmd = new SqlCommand("select * from Product");
    //    cmd.CommandType = CommandType.Text;
    //    cmd.Connection = Conn;
    //    Conn.Open();
    //    ddlProduct.DataSource = cmd.ExecuteReader();
    //    ddlProduct.DataTextField = "Name";
    //    ddlProduct.DataValueField = "id";
    //    ddlProduct.DataBind();
    //    Conn.Close();

    //}

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

    protected void btnGet_Click(object sender, EventArgs e)
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("select sum(Price) as 'Total Price',sum(Qty) as'total Quantity' from Purchase where  supId="+ddlSupplier.SelectedValue.ToString(), Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dynamictable.DataSource = ds.Tables[0];
        dynamictable.DataBind();
    }
    protected void dynamictable_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
    {

    }
    protected void dynamictable_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}