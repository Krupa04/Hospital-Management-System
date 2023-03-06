using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_PatientMaintaince : System.Web.UI.Page
{

    NxtHelper _nxthelper = new NxtHelper();
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["type"].ToString() == "1")
            {
                _nxthelper.DdlFill(ddlPatientID, "select * from Add_InPatient", "Name", "id", true, false);
            }
            else if (Request.QueryString["type"].ToString() == "2")
            {
                _nxthelper.DdlFill(ddlPatientID, "select * from UserReg", "Name", "id", true, false);
            }
        }

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);

            Conn.Open();
            string qry = "insert into Patmaintains(PatientId,natureofproblem,bloodtestno,xrayno,ctscan,prescription,comments,date,Type) values('" + ddlPatientID.SelectedValue + "','" + txtNatureOfProblem.Text + "','" + txtBloodTestNo.Text + "','" + txtxrayno.Text + "','" + txtCtScan.Text + "','" + txtPrescription.Text + "','" + txtComments.Text + "','" + _nxthelper.getddmmyyyy(txtVisitdate.Text) + "','" + Request.QueryString["type"].ToString() + "')";
            SqlCommand cmd2 = new SqlCommand(qry, Conn);
            cmd2.ExecuteNonQuery();
            lblMessage.Text = "Details Added Successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
        finally { Conn.Close(); }
    }
}