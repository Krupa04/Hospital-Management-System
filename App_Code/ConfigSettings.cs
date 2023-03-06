using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for ConfigSettings
/// </summary>
public class ConfigSettings
{
    // public static string ConnString = WebConfigurationManager.ConnectionStrings["PuzzleSpace"].ConnectionString;

    public ConfigSettings()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string conns { get { return WebConfigurationManager.ConnectionStrings["Hospital"].ConnectionString.ToString(); } }

}

