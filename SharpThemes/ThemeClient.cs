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

        private static string GetBaseURL<T>() {
            if (typeof(T) == typeof(Theme)) {
                return m_themebaseurl;
            } else if (typeof(T) == typeof(Badge)) {
                return m_badgebaseurl;
            }
            return m_themebaseurl;
        }

        private async static Task<X> GenericSearch<T, X>(string text, SortBy sorting, string username) {
            var urlb = new StringBuilder();

            urlb.Append(GetBaseURL<T>());
            urlb.Append("?q=");

            if (text != string.Empty) {
                urlb.Append(text + " ");
            }

            urlb.Append((sorting == null ? SortBy.RecentlyUploaded : sorting).ToString() + " ");

            if (username != string.Empty) {
                urlb.Append("user:" + username);
            }

            var data = await Http.DoGet(urlb.ToString());
            return JsonConvert.DeserializeObject<X>(data);
        }

        private async static Task<X> GenericTopList<T, X>(TopList t) {
            var urlb = new StringBuilder();

            urlb.Append(GetBaseURL<T>());
            urlb.Append(t.ToString());

            var data = await Http.DoGet(urlb.ToString());
            return JsonConvert.DeserializeObject<X>(data);
        }

        public async static Task<ThemeGroup> SearchThemes(string text = "", SortBy sorting = default(SortBy), string username = "") {
            return await GenericSearch<Theme, ThemeGroup>(text, sorting, username);
        }

        public async static Task<BadgeGroup> SearchBadges(string text = "", SortBy sorting = default(SortBy), string username = "") {
            return await GenericSearch<Badge, BadgeGroup>(text, sorting, username);
        }

        public async static Task<ThemeGroup> GetMostRecentThemes() {
            return await GenericTopList<Theme, ThemeGroup>(TopList.MostRecent);
        }

        public async static Task<BadgeGroup> GetMostRecentBadges() {
            return await GenericTopList<Badge, BadgeGroup>(TopList.MostRecent);
        }

        public async static Task<ThemeGroup> GetMostPopularThemes() {
            return await GenericTopList<Theme, ThemeGroup>(TopList.MostPopular);
        }

        public async static Task<BadgeGroup> GetMostPopularBadges() {
            return await GenericTopList<Badge, BadgeGroup>(TopList.MostPopular);
        }
    }
}
