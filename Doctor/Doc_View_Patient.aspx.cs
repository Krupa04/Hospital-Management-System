using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doc_View_Patient : System.Web.UI.Page
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
            
            SearchInpatient();
            SearchOutpatient();
        }
    }

    public void SearchInpatient()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select * from Add_InPatient", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Inpatient.DataSource = ds.Tables[0];
        Inpatient.DataBind();
    }

    public void SearchOutpatient()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select * from UserReg", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        OutPatient.DataSource = ds.Tables[0];
        OutPatient.DataBind();

    }

    protected void OutPatient_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;
    }
    protected void Inpatient_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;
    }
}