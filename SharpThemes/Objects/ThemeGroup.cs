using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpThemes.Objects
{
    public class ThemeGroup 
    {
        [JsonProperty(PropertyName = "count")]
        public int ThemeCount { get; }

        [JsonProperty(PropertyName = "themes")]
        public List<Theme> Themes { get; }

        [JsonProperty(PropertyName = "userPrivelege")]
        public string UserPriveledge { get; }
    }
}
