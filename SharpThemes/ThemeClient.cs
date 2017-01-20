using Newtonsoft.Json;
using SharpThemes.Objects;
using SharpThemes.Utilities;
using System.Threading.Tasks;

namespace SharpThemes
{
    public static class ThemeClient 
    {
        private static string m_themebaseurl = "https://3dsthem.es/getThemes.php";
        private static string m_badgebaseurl = "https://badges.3dsthem.es/getThemes.php";
        private static string m_splashbaseurl = "https://splash.3dsthem.es/getThemes.php";

        public async static Task<ThemeGroup> SearchThemes(string text = "", SortBy sorting = default(SortBy), string username = "") {
            if (username != string.Empty) {
                username = "user:" + username;
            }

            var data = await Http.DoGet(string.Concat(m_themebaseurl, $"?q={text} {sorting} {username}"));
            return JsonConvert.DeserializeObject<ThemeGroup>(data);
        }

        public async static Task<ThemeGroup> GetMostRecent() {
            var data = await Http.DoGet(string.Concat(m_themebaseurl, "?recent"));
            return JsonConvert.DeserializeObject<ThemeGroup>(data);
        }

        public async static Task<ThemeGroup> GetMostPopular() {
            var data = await Http.DoGet(string.Concat(m_themebaseurl, "?popular"));
            return JsonConvert.DeserializeObject<ThemeGroup>(data);
        }
    }
}
