using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Drawing;
using System.IO;

public partial class Admin_View_Employee : System.Web.UI.Page
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
            SearchMainTitle();
            this.BindGrid();
         }

    }



   

    public void SearchMainTitle()
    {
        Conn = new SqlConnection(ConnString);
        SqlCommand command = new SqlCommand("Select * from AddEmployee", Conn);
        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dynamictable.DataSource = ds.Tables[0]; 
        dynamictable.DataBind();
    }



    private void BindGrid()
    {
        string strConnString = WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM AddEmployee"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dynamictable.DataSource = dt;
                        dynamictable.DataBind();
                    }
                }
            }
        }
    }



    protected void btnexcel_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            //To Export all pages
            dynamictable.AllowPaging = false;
            this.BindGrid();

            dynamictable.HeaderRow.BackColor = Color.White;
            foreach (TableCell cell in dynamictable.HeaderRow.Cells)
            {
                cell.BackColor = dynamictable.HeaderStyle.BackColor;
            }
            foreach (GridViewRow row in dynamictable.Rows)
            {
                row.BackColor = Color.White;
                foreach (TableCell cell in row.Cells)
                {
                    if (row.RowIndex % 2 == 0)
                    {
                        cell.BackColor = dynamictable.AlternatingRowStyle.BackColor;
                    }
                    else
                    {
                        cell.BackColor = dynamictable.RowStyle.BackColor;
                    }
                    cell.CssClass = "textmode";
                }
            }

            dynamictable.RenderControl(hw);

            //style to format numbers to string
            string style = @"<style> .textmode { } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }



    protected void dynamictable_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {

    }


    protected void dynamictable_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
    {
        dynamictable.PageIndex = e.NewPageIndex;
        this.BindGrid();
    }


    public override void VerifyRenderingInServerForm(Control control)   
    {
        /* Verifies that the control is rendered */
    }


}