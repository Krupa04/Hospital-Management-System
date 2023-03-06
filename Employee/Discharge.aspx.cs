using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Employee_Discharge : System.Web.UI.Page
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
            _nxthelper.DdlFill(ddlPatienrname, "select * from[dbo].[Add_InPatient]", "Name", "id", false, false);
        }
    }
    protected void txtRoomCharges_TextChanged(object sender, EventArgs e)
    {
        txtTotal.Text = (Convert.ToDecimal(txtMedicalCharges.Text) + Convert.ToDecimal(txtRoomCharges.Text)).ToString();
    }
    protected void ddlPatienrname_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select * from Add_InPatient where id=" + ddlPatienrname.SelectedValue, Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        string asd = ds.Tables[0].Rows[0]["RoomNo"].ToString();

        if (!string.IsNullOrEmpty(asd))
        {
            hidRoomNo.Text = asd;
            SqlCommand command1 = new SqlCommand("Select * from RoomDetails where id=" + asd, Conn);
            SqlDataAdapter da1 = new SqlDataAdapter(command1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            lblRoomNo.Text = ds1.Tables[0].Rows[0]["RoomType"].ToString() + ds1.Tables[0].Rows[0]["RoomNo"].ToString();
        }
        else
        {
            lblRoomNo.Text = "";
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            Conn.Open();
            string qry = "Update Add_InPatient set MedicalAmount='" + txtMedicalCharges.Text + "',RoomAmoiunt='" + txtRoomCharges.Text + "',Total='" + txtTotal.Text + "',DischargeDate='" + DateTime.Now.ToShortDateString() + "' where id=" + ddlPatienrname.SelectedValue + "";
            cmd = new SqlCommand(qry, Conn);
            cmd.ExecuteNonQuery();
            if (!string.IsNullOrEmpty(hidRoomNo.Text))
            {
                string qry1 = "Update RoomDetails set Status=0 where id=" + hidRoomNo.Text + "";
                cmd = new SqlCommand(qry1, Conn);
                cmd.ExecuteNonQuery();
            }
            lblMessage.Text = "Details Update Successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            _nxthelper.ResetFormControlValues(this);
            Conn.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;

        }

    }
}