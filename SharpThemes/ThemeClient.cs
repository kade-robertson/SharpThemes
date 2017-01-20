using Newtonsoft.Json;
using SharpThemes.Objects;
using SharpThemes.Utilities;
using System.Text;
using System.Threading.Tasks;

namespace SharpThemes
{
    public static class ThemeClient 
    {
        private static string m_themebaseurl = "https://3dsthem.es/getThemes.php";
        private static string m_badgebaseurl = "https://badges.3dsthem.es/getThemes.php";
        private static string m_splashbaseurl = "https://splash.3dsthem.es/getThemes.php";

        private async static Task<X> GenericSearch<T, X>(string text, SortBy sorting, string username) {
            var urlb = new StringBuilder();

            if (typeof(T) == typeof(Theme)) {
                urlb.Append(m_themebaseurl);
            } else if (typeof(T) == typeof(Badge)) {
                urlb.Append(m_badgebaseurl);
            }

            urlb.Append("?q=");

            if (text != string.Empty) {
                urlb.Append(text + " ");
            }

            urlb.Append((sorting == null ? SortBy.RecentlyUploaded : sorting).ToString() + " ");

            if (username != string.Empty) {
                urlb.Append("user:" + username);
            }

            try {
                var data = await Http.DoGet(urlb.ToString());
                return JsonConvert.DeserializeObject<X>(data);
            } catch {
                throw new System.Exception(urlb.ToString());
            }
        }

        public async static Task<ThemeGroup> SearchThemes(string text = "", SortBy sorting = default(SortBy), string username = "") {
            return await GenericSearch<Theme, ThemeGroup>(text, sorting, username);
        }

        public async static Task<ThemeGroup> GetMostRecentThemes() {
            var data = await Http.DoGet(string.Concat(m_themebaseurl, "?recent"));
            return JsonConvert.DeserializeObject<ThemeGroup>(data);
        }

        public async static Task<ThemeGroup> GetMostPopularThemes() {
            var data = await Http.DoGet(string.Concat(m_themebaseurl, "?popular"));
            return JsonConvert.DeserializeObject<ThemeGroup>(data);
        }
    }
}
