using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Finance : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();

    protected void Page_Load(object sender, EventArgs e)
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("select sum(Total) as tot from [Add_InPatient]", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string asd = ds.Tables[0].Rows[0]["tot"].ToString();
        txttotalincome.Text = asd;

        if (!string.IsNullOrEmpty(asd))
        {
           // hidRoomNo.Text = asd;
            SqlCommand command1 = new SqlCommand("select a.total+b.total as mytotal from [Docsalary] a join [Empsalary] b on a.month=b.month", Conn);
            SqlDataAdapter da1 = new SqlDataAdapter(command1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            txttotalexp.Text = ds1.Tables[0].Rows[0]["mytotal"].ToString();
        }
        else
        {
           // lblRoomNo.Text = "";
        }


        int inc = Convert.ToInt16(txttotalincome.Text);
        int ex = Convert.ToInt16(txttotalexp.Text);

        txtprofit.Text = Convert.ToString(inc-ex) ;

        if (!IsPostBack)
        {
            SearchMainTitle();
            SearchMainTitle2();
            SearchMainTitle3();
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
    public void SearchMainTitle2()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select Doc_id,month,salary,no_of_day,total from Docsalary", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

    }

    public void SearchMainTitle3()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select id,MedicalAmount,RoomAmoiunt,Total from Add_InPatient", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();

    }


    protected void GridView1_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;
    }
}