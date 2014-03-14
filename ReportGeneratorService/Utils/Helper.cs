using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace IMSReportGenerator.Utils
{
    public static class Helper
    {
        public static string GetScriptTag(string relativePath)
        {
            return string.Format("<script type='text/javascript' src='{0}'></script>", relativePath);
        }

        public static string GetStyleTag(string relativePath)
        {
            return string.Format("<link href='{0}' rel='stylesheet'/>", relativePath);
        }
    }
}