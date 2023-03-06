using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_AddFeedBack : System.Web.UI.Page
{
    NxtHelper _nxthelper = new NxtHelper();
    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        txtName.Text = Session["id"].ToString();
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            Conn = new SqlConnection(ConnString);

            Conn.Open();
            string qry = "insert into FeedBack values('" + txtName.Text + "','" + txtFeedback.Text + "')";
            SqlCommand cmd2 = new SqlCommand(qry, Conn);
            cmd2.ExecuteNonQuery();
            lblMessage.Text = "FeedBack Added Successfully";
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