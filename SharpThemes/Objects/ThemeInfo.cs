using Newtonsoft.Json;

namespace SharpThemes.Objects 
{
    class ThemeInfo 
    {
        [JsonProperty(PropertyName = "top")]
        public int Top { get; }

        [JsonProperty(PropertyName = "topf")]
        public int TopF { get; }

        [JsonProperty(PropertyName = "bot")]
        public int Bot { get; }

        [JsonProperty(PropertyName = "botf")]
        public int BotF { get; }

        [JsonProperty(PropertyName = "fol")]
        public int Fol { get; }

        [JsonProperty(PropertyName = "bor")]
        public int Bor { get; }

        [JsonProperty(PropertyName = "sfx")]
        public int SFX { get; }
    }
}
