using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;

public partial class Doctor_changepwd : System.Web.UI.Page
{

    public string ConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
    public SqlCommand cmd = new SqlCommand();
    public SqlConnection Conn = new SqlConnection();
    public SqlDataReader dr;
    NxtHelper _nxthelper = new NxtHelper();
    int age1;
    string str = null;
    byte up;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConnString);
        con.Open();
        str = "select * from Adddoctor ";
        cmd = new SqlCommand(str, con);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (txtoldpwd.Text == reader["password"].ToString())
            {
                up = 1;
            }
        }
        reader.Close();
        con.Close();
        if (up == 1)
        {
            con.Open();
            str = "update Adddoctor set password=@Password where UserName='" + Session["UserName"].ToString() + "'";
            cmd = new SqlCommand(str, con);
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
            cmd.Parameters["@Password"].Value = txtnewpwd.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            lblMessage.Text = "Password changed Successfully";

        }
        else
        {
            lblMessage.Text = "Please enter correct Current password";
        }
    }
}