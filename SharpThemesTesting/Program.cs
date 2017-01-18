using SharpThemes;
using SharpThemes.Utilities;
using SharpThemes.Objects;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using System.Net;

namespace SharpThemesTesting 
{
    class Program
    {
        private static string m_baseurl = "https://3dsthem.es/getThemes.php?q=sort:dl";

        public static ThemeGroup Search() {
            var data = Task.Run(() => Http.DoGet(m_baseurl)).Result;
            Console.WriteLine(data);
            System.Diagnostics.Debug.WriteLine(data);
            var ret = JsonConvert.DeserializeObject<ThemeGroup>(data);
            Console.WriteLine(ret.ThemeCount);
            return ret;
        }

        static void Main(string[] args) {
            var test = Search();
            Console.WriteLine(WebUtility.HtmlDecode(test.Themes[0].InfoString));
            Console.Read();
        }
    }
}
