using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FeedbackDapper.Utility
{
    public static class Helper
    {
        private static readonly string strFileName = "DBQueries";
        public static string GetQuery(string strQueryName, string strQueryId)
        {
            var path = HttpContext.Current.Server.MapPath("~/Config");
            try
            {
                if (!string.IsNullOrEmpty(path.ToString()) && Directory.Exists(path))
                {

                }
            }
            catch (Exception ex)
            {

            }
            return string.Empty;
        }
    }
}