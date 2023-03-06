using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Employee_BillGenerate : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();
    string date1;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // _nxthelper.DdlFill(ddlPatienrname, "select * from[dbo].[Add_InPatient]", "Name", "id", false, false);
        }

        Conn = new SqlConnection(ConnString);
        cmd = new SqlCommand("Select DischargeDate from Add_InPatient", Conn);
        Conn.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            date1 = dr["DischargeDate"].ToString();

        }

        Conn.Close();

        if (!string.IsNullOrEmpty(date1))
        {

            Conn = new SqlConnection(ConnString);
            SqlCommand command = new SqlCommand("select * from Add_InPatient", Conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dynamictable.DataSource = ds.Tables[0];
            dynamictable.DataBind();


            
        }
        else
        {

           
        }

    }

    protected void grdMainTitle_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.TableSection = TableRowSection.TableHeader;
    }


  //  protected void ddlPatienrname_SelectedIndexChanged(object sender, EventArgs e)
   //// {
        //Conn = new SqlConnection(ConnString);
        //cmd = new SqlCommand("Select DischargeDate from Add_InPatient" Conn);
        //Conn.Open();
        //dr = cmd.ExecuteReader();
        //if (dr.Read())
        //{
        //    date1 = dr["DischargeDate"].ToString();

        //}

        //Conn.Close();

        //if (!string.IsNullOrEmpty(date1))
        //{

        //    Conn = new SqlConnection(ConnString);
        //    SqlCommand command = new SqlCommand("select * from Add_InPatient", Conn);
        //    SqlDataAdapter da = new SqlDataAdapter(command);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    dynamictable.DataSource = ds.Tables[0];
        //    dynamictable.DataBind();


            
        //}
        //else
        //{

           
        //}
    //}
}