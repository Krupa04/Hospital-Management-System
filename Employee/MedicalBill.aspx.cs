using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Employee_MedicalBill : System.Web.UI.Page
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
            SearchAppoinment();
        }

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("select * from Supplier");
        cmd.CommandType = CommandType.Text;
        cmd.Connection = Conn;
        Conn.Open();
        ddlsupName.DataSource = cmd.ExecuteReader();
        ddlsupName.DataTextField = "Name";
        ddlsupName.DataValueField = "id";
        ddlsupName.DataBind();
        Conn.Close();

    }

    protected void grdMainTitle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;


    }

    public void SearchAppoinment()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("select Productid,supId,Qty,Price from [dbo].[Purchase]", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dynamictable.DataSource = ds.Tables[0];
        dynamictable.DataBind();
    }

    protected void CmdSubmit_Click(object sender, EventArgs e)
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select sum(Qty) as qty, sum(Price) as Price from Purchase where supId = '" + ddlsupName.SelectedValue + "'", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}