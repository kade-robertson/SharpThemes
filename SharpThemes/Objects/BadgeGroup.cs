using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpThemes.Objects
{
    public class BadgeGroup 
    {
        [JsonProperty(PropertyName = "count")]
        public uint BadgeCount { get; set; }

        [JsonProperty(PropertyName = "themes")]
        public List<Badge> Badges { get; set; }

        [JsonProperty(PropertyName = "userPrivelege")]
        public string UserPriveledge { get; set; }

        public override string ToString() {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}