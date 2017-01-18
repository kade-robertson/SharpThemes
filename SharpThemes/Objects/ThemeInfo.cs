using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpThemes.Objects 
{
    public enum ScrollType {
        NormalScrolling = 0,
        NoScrolling = 1,
        Flipbook = 2,
        SlowScrolling = 3,
        FlipbookLoop = 4
    }

    public enum ScreenType {
        Default = 0,
        SolidColour = 1,
        Custom = 3
    }

    public class ThemeInfo 
    {
        [JsonProperty(PropertyName = "top")]
        //[JsonConverter(typeof(Utilities.ScreenTypeConverter))]
        public uint TopScreenType { get; }

        [JsonProperty(PropertyName = "topf")]
        //[JsonConverter(typeof(Utilities.ScrollTypeConverter))]
        public uint TopScreenScrollType { get; }

        [JsonProperty(PropertyName = "bot")]
        //[JsonConverter(typeof(Utilities.ScreenTypeConverter))]
        public uint BottomScreenType { get; }

        [JsonProperty(PropertyName = "botf")]
        //[JsonConverter(typeof(Utilities.ScrollTypeConverter))]
        public uint BottomScreenScrollType { get; }

        [JsonProperty(PropertyName = "fol")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasCustomFolders { get; }

        [JsonProperty(PropertyName = "bor")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasCustomBorders { get; }

        [JsonProperty(PropertyName = "sfx")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasSFX { get; }
    }
}
