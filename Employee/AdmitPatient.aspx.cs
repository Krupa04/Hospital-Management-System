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

public partial class Employee_AdmitPatient : System.Web.UI.Page
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
            loadddl();
            LoadData();
        }
    }

    void loadddl()
    {
        _nxthelper.DdlFill(ddlPatienrname, "select * from[dbo].[Add_InPatient]", "Name", "id", false, false);
        _nxthelper.DdlFill(ddlRoomNo, "select RoomType + CAST(RoomNo as varchar) as Name , id from [dbo].[RoomDetails] where Status=0", "Name", "id", false, false);

    }


    void LoadData()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("select * from RoomDetails order by id", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);

        string Tab1 = "<table class=\"table table-bordered text-centered\">";

        string MainTitle = "<tr><td style =\"text-align: center;\" colspan=\"6\">##Title##</td></tr>";
        string Main1 = "<tr><td style =\"text-align: left;\"><i class=\"fa fa-bed text-##Color1##\" style=\"font-size: 30px;\"></i></td><td style =\"text-align: center;\">##1##</td>";
        string Main2 = "<td style =\"text-align: left;\"><i class=\"fa fa-bed text-##Color2##\" style=\"font-size: 30px;\"></i></td><td style =\"text-align: center;\">##2##</td>";
        string Main3 = "<td style =\"text-align: left;\"><i class=\"fa fa-bed text-##Color3##\" style=\"font-size: 30px;\"></i></td><td style =\"text-align: center;\">##3##</td></ tr>";
        string end = "</ table>";
        sb.Append(Tab1);
        for (int colval = 0; colval <= ds.Tables[0].Rows.Count - 1; colval++)
        {
            //sb.Append(MainTitle);
            //sb.Replace("##Title##", ds.Tables[0].Rows[0]["RoomType"].ToString());
            sb.Append(Main1);
            if (ds.Tables[0].Rows[colval]["Status"].ToString() == "1")
            {
                sb.Replace("##Color1##", "success");
            }
            else
            {
                sb.Replace("##Color1##", "danger");
            }
            sb.Replace("##1##", ds.Tables[0].Rows[colval]["RoomType"].ToString() + ds.Tables[0].Rows[colval]["RoomNo"].ToString());
            colval++;
            sb.Append(Main2);
            if (ds.Tables[0].Rows[colval]["Status"].ToString() == "1")
            {
                sb.Replace("##Color2##", "success");
            }
            else
            {
                sb.Replace("##Color2##", "danger");
            }
            sb.Replace("##2##", ds.Tables[0].Rows[colval]["RoomType"].ToString() + ds.Tables[0].Rows[colval]["RoomNo"].ToString());
            colval++;
            sb.Append(Main3);
            if (ds.Tables[0].Rows[colval]["Status"].ToString() == "1")
            {
                sb.Replace("##Color3##", "success");
            }
            else
            {
                sb.Replace("##Color3##", "danger");
            }
            sb.Replace("##3##", ds.Tables[0].Rows[colval]["RoomType"].ToString() + ds.Tables[0].Rows[colval]["RoomNo"].ToString());


        }
        sb.Append(end);
        litRoomDetails.Text = sb.ToString();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);
            Conn.Open();
            string qry = "Update Add_InPatient set RoomNo=" + ddlRoomNo.SelectedValue + ",AdmitDate='" + DateTime.Now.ToShortDateString() + "',Description='" + txtDescription.Text + "' where id=" + ddlPatienrname.SelectedValue + "";
            cmd = new SqlCommand(qry, Conn);
            cmd.ExecuteNonQuery();

            string qry1 = "Update RoomDetails set Status=1 where id=" + ddlRoomNo.SelectedValue + "";
            cmd = new SqlCommand(qry1, Conn);
            cmd.ExecuteNonQuery();
            lblMessage.Text = "Details Update Successfully";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            _nxthelper.ResetFormControlValues(this);
            Conn.Close();
            loadddl();

        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.Replace("'", "");
            lblMessage.ForeColor = System.Drawing.Color.Red;

        }

        LoadData();
    }
}