using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpThemes.Objects
{
    public class ThemeGroup 
    {
        [JsonProperty(PropertyName = "count")]
        public uint ThemeCount { get; set; }

        [JsonProperty(PropertyName = "themes")]
        public List<Theme> Themes { get; set; }

        [JsonProperty(PropertyName = "userPrivelege")]
        public string UserPriveledge { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
