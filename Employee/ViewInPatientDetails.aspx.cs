using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_ViewInPatientDetails : System.Web.UI.Page
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
    }
    protected void grdMainTitle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;

    }
    public void SearchAppoinment()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("select A.id,A.name,A.dob,A.age,A.gender,A.mailid,A.mobileno,A.address,A.city,A.state,A.natproblem,A.ad_date,A.RoomNo,A.Description,A.AdmitDate,a.MedicalAmount,a.RoomAmoiunt,a.Total,a.DischargeDate,CAST(R.Roomno as varchar) + R.RoomType 'Room No'from Add_InPatient A left join RoomDetails R on A.RoomNo = R.id", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dynamictable.DataSource = ds.Tables[0];
        dynamictable.DataBind();
    }
}