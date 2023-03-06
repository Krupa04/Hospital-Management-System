using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
    ConfigSettings _settings = new ConfigSettings();

    public Helper()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int allowInt(string val)
    {
        try
        {
            return string.IsNullOrEmpty(val) ? 0 : Convert.ToInt32(val);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public int? allowIntNull(string val)
    {
        try
        {
            return string.IsNullOrEmpty(val) ? 0 : Convert.ToInt32(val);
        }
        catch (Exception)
        {
            return null;
        }
    }


    public int? allowDdlIntNull(string val)
    {
        try
        {
            if (val == "0" || val == "")
            {
                return null;
            }
            else
            {
                return Convert.ToInt16(val);
            }
        }
        catch (Exception)
        {
            return null;
        }
    }


    public string allowDdlstringNull(string val)
    {
        try
        {
            return val;
        }
        catch (Exception)
        {
            return null;
        }
    }


    public decimal allowDecimal(string val)
    {
        try
        {
            return string.IsNullOrEmpty(val) ? 0 : Convert.ToDecimal(val);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public decimal? allowDecimalNull(string val)
    {
        try
        {
            return string.IsNullOrEmpty(val) ? 0 : Convert.ToDecimal(val);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public string getBool(string val)
    {
        if (val.ToLower() == "true")
        {
            return "1";
        }
        else
        {
            return "0";
        }
    }

    public Boolean setBool(string val)
    {

        bool value = true;
        if (val == "1")
        {
            value = true;
        }
        else if (val == "0")
        {
            value = false;
        }
        return value;

    }

    public string allowString(string val)
    {
        try
        {
            return string.IsNullOrEmpty(val) ? "" : Convert.ToString(val.Trim());
        }
        catch (Exception)
        {
            throw;
        }
    }
    public string allowStringNull(string val)
    {
        try
        {
            return string.IsNullOrEmpty(val) ? "" : Convert.ToString(val.Trim());
        }
        catch (Exception)
        {
            return null;
        }
    }

    public string allowStringNullonly(string val)
    {
        try
        {
            if (val == "")
            { return null; }
            else
            {
                return Convert.ToString(val.Trim());
            }

        }
        catch (Exception)
        {
            return null;
        }
    }

    public DateTime? allowDate(string val)
    {
        try
        {
            if (!string.IsNullOrEmpty(val))
            {
                return (Convert.ToDateTime(val));
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

    public string setDate(string val)
    {
        try
        {
            if (!string.IsNullOrEmpty(val))
            {
                DateTime dat = Convert.ToDateTime(val);
                return dat.ToString("MM/dd/yyyy HH:mm");
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

    public string setDateOnly(string val)
    {
        try
        {
            if (!string.IsNullOrEmpty(val))
            {
                DateTime dat = Convert.ToDateTime(val);
                return dat.ToString("dd/MMM/yyyy");
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
    public string getDateForAttendance(string val)
    {
        try
        {
            if (!string.IsNullOrEmpty(val))
            {
                string getData = Convert.ToString(val);
                string[] arg = new string[3];
                arg = getData.Split('/');


                int dd = Convert.ToInt16(arg[1]);
                int mm = Convert.ToInt16(arg[0]);
                int yy = Convert.ToInt16(arg[2]);
                return yy + "-" + mm + "-" + dd;
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
    public string setAmount(string val)
    {
        int price = Convert.ToInt32(val);
        return price.ToString("#,##0");
    }

    public string setTimeOnly(string val)
    {
        try
        {
            if (!string.IsNullOrEmpty(val))
            {
                DateTime dat = Convert.ToDateTime(val);
                return dat.ToString("HH:mm tt");
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

    public string setFirstChatUpper(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        char[] a = s.ToCharArray();
        a[0] = char.ToUpper(a[0]);
        return new string(a);
    }

    //static string HashPassword(string pasword)
    //{
    //    byte[] arrbyte = new byte[pasword.Length];
    //    SHA256 hash = new SHA256CryptoServiceProvider();
    //    arrbyte = hash.ComputeHash(Encoding.UTF8.GetBytes(pasword));

    //    return Convert.ToBase64String(arrbyte);
    //}

    //public string encript_URL(string UrlData)
    //{
    //    return HttpUtility.UrlEncode(Encrypt(UrlData));
    //}

    //public string decript_URL(string UrlData)
    //{
    //    return Decrypt(HttpUtility.UrlDecode(UrlData));
    //}



    //public string Encrypt(string clearText)
    //{
    //    string EncryptionKey = _settings.UrlEncriptCode;
    //    byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
    //    using (Aes encryptor = Aes.Create())
    //    {
    //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
    //        encryptor.Key = pdb.GetBytes(32);
    //        encryptor.IV = pdb.GetBytes(16);
    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
    //            {
    //                cs.Write(clearBytes, 0, clearBytes.Length);
    //                cs.Close();
    //            }
    //            clearText = Convert.ToBase64String(ms.ToArray());
    //        }
    //    }
    //    return clearText;
    //}


    //public string Decrypt(string cipherText)
    //{
    //    string EncryptionKey = _settings.UrlEncriptCode;
    //    cipherText = cipherText.Replace(" ", "+");
    //    byte[] cipherBytes = Convert.FromBase64String(cipherText);
    //    using (Aes encryptor = Aes.Create())
    //    {
    //        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
    //        encryptor.Key = pdb.GetBytes(32);
    //        encryptor.IV = pdb.GetBytes(16);
    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
    //            {
    //                cs.Write(cipherBytes, 0, cipherBytes.Length);
    //                cs.Close();
    //            }
    //            cipherText = Encoding.Unicode.GetString(ms.ToArray());
    //        }
    //    }
    //    return cipherText;
    //}

    public string TruncateLongString(string str, int maxLength)
    {
        if (!string.IsNullOrEmpty(str) && str.Length >= maxLength)
        {
            return (str.Substring(0, maxLength) + "...");
        }
        else
        {
            return str;
        }
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


}