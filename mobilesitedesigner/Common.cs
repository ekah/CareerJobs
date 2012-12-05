using System;
using System.Web;
using System.Linq;
using System.IO;
using System.Collections.Specialized;
using System.Text;
namespace mobilesitedesigner
{
    public static partial class Common
    {
       
        public static int GetClientID(string path)
        {
            HttpContext context = HttpContext.Current;
           
            var datacontext = new Data.dbml.DataContext(Common.DataConnectionString);
            var tbl = datacontext.TBL_Organization.FirstOrDefault(o => o.SubDomain == path);
            return tbl.OrganizationId;
        }
        public static string Reduce(this string s, int count, string endings)
        {
            if (count < endings.Length)
                throw new Exception("Failed to reduce to less then endings length.");
            int sLength = s.Length;
            int len = sLength;
            if (endings != null)
                len += endings.Length;
            if (count > sLength)
                return s; //it's too short to reduce
            s = s.Substring(0, sLength - len + count);
            if (endings != null)
                s += endings;
            return s;
        }
        public static string ToQS(this NameValueCollection s)
        {
            StringBuilder  qs=new StringBuilder("?");
            foreach (string o in s.AllKeys)
            {
                qs.AppendFormat("{0}={1}&",o,s[o]);
               
            }
            return qs.ToString().TrimEnd('&');
        }
        public static string StripHTML(this string inputString)
        {
            return System.Text.RegularExpressions.Regex.Replace
              (inputString, "<.*?>", string.Empty);
        }
        public static bool CopyDirectory(string SourcePath, string DestinationPath, bool overwriteexisting)
        {
            bool ret = false;
            try
            {
                SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
                DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                        Directory.CreateDirectory(DestinationPath);
                    foreach (string fls in Directory.GetFiles(SourcePath))
                    {
                        FileInfo flinfo = new FileInfo(fls);
                        flinfo.CopyTo(DestinationPath + flinfo.Name, overwriteexisting);
                    }
                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo drinfo = new DirectoryInfo(drs);
                        if (CopyDirectory(drs, DestinationPath + drinfo.Name, overwriteexisting) == false)
                            ret = false;
                    }
                }
                ret = true;
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }  
    }
}
