using Newtonsoft.Json;
using SharpThemes.Objects;
using SharpThemes.Utilities;
using System.Threading.Tasks;

namespace SharpThemes
{
    public static class ThemeClient 
    {
        private static string m_baseurl = "https://3dsthem.es/getThemes.php";

        public async static Task<ThemeGroup> Search() {
            var data = await Http.DoGet(m_baseurl);
            return JsonConvert.DeserializeObject<ThemeGroup>(data);
        }
    }
}
