using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharpThemes.Objects
{
    public class SplashGroup 
    {
        [JsonProperty(PropertyName = "count")]
        public uint SplashCount { get; set; }

        [JsonProperty(PropertyName = "themes")]
        public List<Splash> Splashes { get; set; }

        [JsonProperty(PropertyName = "userPrivelege")]
        public string UserPriveledge { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
