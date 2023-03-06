using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// Summary description for NxtHelper
/// </summary>
public class NxtHelper
{
    ConfigSettings _config = new ConfigSettings();
    Helper _helper = new Helper();
    string conStr;
    SqlConnection Conn;
    ConfigSettings _settings = new ConfigSettings();


    public NxtHelper()
    {
        conStr = _config.conns.ToString();
        Conn = new SqlConnection(conStr);
    }

    public void ResetFormControlValues(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            if (c.Controls.Count > 0)
            {
                ResetFormControlValues(c);
            }
            else
            {
                switch (c.GetType().ToString())
                {
                    case "System.Web.UI.WebControls.TextBox":
                        ((TextBox)c).Text = "";
                        break;
                    case "System.Web.UI.WebControls.CheckBoxList":
                        ((CheckBox)c).Checked = false;
                        break;
                    case "System.Web.UI.WebControls.RadioButton":
                        ((RadioButton)c).Checked = false;
                        break;
                    case "System.Web.UI.WebControls.DropDownList":

                        break;
                    case "System.Web.UI.WebControls.RadioButtonList":
                        ((RadioButtonList)c).ClearSelection();
                        break;
                }
            }
        }
    }
    public void selectcount()
    {

        ////Conn = new SqlConnection(ConnString);
        //Conn.Open();
        //SqlCommand com = new SqlCommand("select count(*) from Student_Details", Conn);
        //int count = Convert.ToInt16(com.ExecuteScalar()) + 1;
        ////txtATMId.Text = ("21" + count);
        //return count;
        //Conn.Close();
    }
    public string ErrorLister(string pageName, string methodName, string userId, Exception ex)
    {
        return Environment.NewLine + "URL :" + pageName + Environment.NewLine + "Method :" + methodName + Environment.NewLine + "User Id :" + userId + Environment.NewLine + ex;
    }

    public string ErrorLister(string pageName, string methodName, string userId, string ex)
    {
        return Environment.NewLine + "URL :" + pageName + Environment.NewLine + "Method :" + methodName + Environment.NewLine + "User Id :" + userId + Environment.NewLine + ex;
    }

    public string ExecuryQuery(string Query)
    {
        try
        {
            SqlCommand cmd = new SqlCommand(Query, Conn);

            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
            return "Message - Details Updated Successfully";
        }
        catch (Exception ex)
        {
            return ex.Message.Replace("'", "\'");
        }
    }

    public string ToPascalCase(string the_string)
    {
        // If there are 0 or 1 characters, just return the string.
        if (the_string == null) return the_string;
        if (the_string.Length < 2) return the_string.ToUpper();

        // Split the string into words.
        string[] words = the_string.Split(
            new char[] { },
            StringSplitOptions.RemoveEmptyEntries);

        // Combine the words.
        string result = "";
        foreach (string word in words)
        {
            result +=
                word.Substring(0, 1).ToUpper() +
                word.Substring(1);
        }

        return result;
    }

    public DataSet SelectHoliday()
    {
        SqlCommand command = new SqlCommand("Select_Holiday_Dashboard", Conn);
        command.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter da = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public string sendMail(string ToAddress, string Subject, string Body)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("keerthismtp@gmail.com");
            mail.To.Add(ToAddress);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("keerthismtp@gmail.com", "keerthi123");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return "Mail Send";
        }

        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    //public string sendSMS(string MobileNo, string smsText)
    //{
    //    string SmsStatusMsg = string.Empty;
    //    try
    //    {
    //        WebClient client = new WebClient();
    //        StringBuilder sb = new StringBuilder();

    //        sb.Append(_settings.SmsBegin);

    //        sb.Append(_settings.SmsUserName);
    //        sb.Append(_settings.SmsSecond);
    //        sb.Append(_settings.SmsPassword);
    //        sb.Append(_settings.SmsThird);
    //        sb.Append(_settings.SmsSenderIDPromotional);
    //        sb.Append(_settings.SmsFouth);
    //        sb.Append(_settings.SmsRoutePro);
    //        sb.Append(_settings.SmsFifth);
    //        sb.Append(MobileNo);

    //        sb.Append(_settings.SmsLast);
    //        sb.Append(smsText);

    //        string URL = sb.ToString();
    //        SmsStatusMsg = new TimedWebClient { Timeout = 600000 }.DownloadString(URL);

    //        string datetime = DateTime.Now.ToString("yyyyMMdd");

    //        DataTable dt = new DataTable();
    //        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("sms_Broadcast_id"), new DataColumn("sms_Status"), new DataColumn("sms_mobileNo"), new DataColumn("sms_text"), new DataColumn("sms_dateFormat") });
    //        string sentsmsList = MobileNo;
    //        string[] words = sentsmsList.Split(',');
    //        foreach (string MObileNo in words)
    //        {
    //            dt.Rows.Add("sss", null, MObileNo, smsText, datetime);
    //        }
    //        SaveSms(dt);
    //        return "Message Sent Successful.";
    //    }
    //    catch (WebException e1)
    //    {
    //        return e1.Message + " " + "WebException" + " " + e1.InnerException;

    //    }
    //    catch (Exception e2)
    //    {
    //        return e2.Message + " " + "WebException" + " " + e2.InnerException;

    //    }
    //}
    //public string sendSMSTran(string MobileNo, string smsText)
    //{
    //    string SmsStatusMsg = string.Empty;
    //    try
    //    {
    //        WebClient client = new WebClient();
    //        StringBuilder sb = new StringBuilder();

    //        sb.Append(_settings.SmsBegin);

    //        sb.Append(_settings.SmsUserName);
    //        sb.Append(_settings.SmsSecond);
    //        sb.Append(_settings.SmsPassword);
    //        sb.Append(_settings.SmsThird);
    //        sb.Append(_settings.SmsSenderID);
    //        sb.Append(_settings.SmsFouth);
    //        sb.Append(_settings.SmsRouteTran);
    //        sb.Append(_settings.SmsFifth);
    //        sb.Append(MobileNo);

    //        sb.Append(_settings.SmsLast);
    //        sb.Append(smsText);

    //        string URL = sb.ToString();
    //        SmsStatusMsg = new TimedWebClient { Timeout = 600000 }.DownloadString(URL);

    //        string datetime = DateTime.Now.ToString("yyyyMMdd");

    //        DataTable dt = new DataTable();
    //        dt.Columns.AddRange(new DataColumn[5] { new DataColumn("sms_Broadcast_id"), new DataColumn("sms_Status"), new DataColumn("sms_mobileNo"), new DataColumn("sms_text"), new DataColumn("sms_dateFormat") });
    //        string sentsmsList = MobileNo;
    //        string[] words = sentsmsList.Split(',');
    //        foreach (string MObileNo in words)
    //        {
    //            dt.Rows.Add("sss", null, MObileNo, smsText, datetime);
    //        }
    //        SaveSms(dt);
    //        return "Message Sent Successful.";
    //    }
    //    catch (WebException e1)
    //    {
    //        return e1.Message + " " + "WebException" + " " + e1.InnerException;

    //    }
    //    catch (Exception e2)
    //    {
    //        return e2.Message + " " + "WebException" + " " + e2.InnerException;

    //    }
    //}

    public void SaveSms(DataTable dt)
    {
        if (dt.Rows.Count > 0)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                {
                    //Set the database table name
                    sqlBulkCopy.DestinationTableName = "dbo.SMS_Bulk";

                    //[OPTIONAL]: Map the DataTable columns with that of the database table
                    sqlBulkCopy.ColumnMappings.Add("sms_Broadcast_id", "sms_Broadcast_id");
                    sqlBulkCopy.ColumnMappings.Add("sms_Status", "sms_Status");
                    sqlBulkCopy.ColumnMappings.Add("sms_mobileNo", "sms_mobileNo");
                    sqlBulkCopy.ColumnMappings.Add("sms_text", "sms_text");
                    sqlBulkCopy.ColumnMappings.Add("sms_dateFormat", "sms_dateFormat");
                    con.Open();
                    sqlBulkCopy.WriteToServer(dt);
                    con.Close();
                }
            }
        }
    }

    #region ddl
    public void DdlFill(DropDownList DrpId, string query, string txtfld, string valfld, bool ShowSelect, bool sp)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            DrpId.DataValueField = valfld;
            DrpId.DataBind();
        }
        if (ShowSelect == true)
        {
            DrpId.Items.Insert(0, new ListItem("- Select -", ""));
            DrpId.SelectedIndex = 0;
        }

    }
    public void DdlFill(DropDownList DrpId, string query, string txtfld, string valfld, bool ShowSelect)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            DrpId.DataValueField = valfld;
            DrpId.DataBind();
        }
        if (ShowSelect == true)
        {
            DrpId.Items.Insert(0, new ListItem("- Select -", ""));
            DrpId.SelectedIndex = 0;
        }

    }
    public void DdlFill(DropDownList DrpId, string query, string txtfld, string valfld, bool ShowSelect, string AdditionalInput, string AdditionalParamater)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue(AdditionalParamater, AdditionalInput);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            DrpId.DataValueField = valfld;
            DrpId.DataBind();
        }

        if (ShowSelect == true)
        {
            DrpId.Items.Insert(0, new ListItem("- Select -", ""));
            DrpId.SelectedIndex = 0;
        }

    }
    public void DdlFill(DropDownList DrpId, string query, string txtfld, string valfld, bool ShowSelect, string AdditionalInput, string AdditionalParamater, string AdditionalInput1, string AdditionalParamater1)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue(AdditionalParamater, AdditionalInput);
        cmd.Parameters.AddWithValue(AdditionalParamater1, AdditionalInput1);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            DrpId.DataValueField = valfld;
            DrpId.DataBind();
        }

        if (ShowSelect == true)
        {
            DrpId.Items.Insert(0, new ListItem("- Select -", ""));
            DrpId.SelectedIndex = 0;
        }

    }


    public void DdlFill(DropDownList DrpId, string query, string txtfld, string ShowSelecttext)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            if (ShowSelecttext == "Select Date")
            {
                DrpId.DataTextFormatString = "{0:d}";
            }
            DrpId.DataBind();
        }
        DrpId.Items.Insert(0, new ListItem(ShowSelecttext, "0"));
        DrpId.SelectedIndex = 0;

    }
    public void DdlFill(DropDownList DrpId, string query, string txtfld, string valfld, string ShowSelecttext)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            DrpId.DataValueField = valfld;
            DrpId.DataBind();
        }

        DrpId.Items.Insert(0, new ListItem(ShowSelecttext, "0"));
        DrpId.SelectedIndex = 0;


    }
    public void DdlFill(DropDownList DrpId, string query, string txtfld, string valfld, string ShowSelecttext, bool show)
    {

        SqlCommand cmd = new SqlCommand(query, Conn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds != null)
        {
            DrpId.DataSource = ds;
            DrpId.DataTextField = txtfld;
            DrpId.DataValueField = valfld;
            DrpId.DataBind();
        }
        if (show == true)
        {
            DrpId.Items.Insert(0, new ListItem(ShowSelecttext, "0"));
            DrpId.SelectedIndex = 0;
        }

    }

    #endregion

    public string getddmmyyyy(string val)
    {
        try
        {
            if (!string.IsNullOrEmpty(val))
            {
                string getData = Convert.ToString(val);
                string[] arg = new string[3];
                arg = getData.Split('/');


                int dd = Convert.ToInt16(arg[0]);
                int mm = Convert.ToInt16(arg[1]);
                int yy = Convert.ToInt16(arg[2]);
                return mm + "/" + dd + "/" + yy;
            }
            else
            {
                return null;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }



}

