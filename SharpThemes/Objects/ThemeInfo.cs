using Newtonsoft.Json;

namespace SharpThemes.Objects 
{
    enum ThemeInfoType {
        NormalScrollingScreen = 0,
        NoScrollingScreen = 1,
        FlipBookScreen = 2
    }

    class ThemeInfo 
    {
        [JsonProperty(PropertyName = "top")]
        public int Top { get; }

        [JsonProperty(PropertyName = "topf", ItemConverterType = typeof(Utilities.ThemeInfoConverter))]
        public ThemeInfoType TopScreenType { get; }

        [JsonProperty(PropertyName = "bot")]
        public int Bot { get; }

        [JsonProperty(PropertyName = "botf", ItemConverterType = typeof(Utilities.ThemeInfoConverter))]
        public ThemeInfoType BottomScreenType { get; }

        [JsonProperty(PropertyName = "fol", ItemConverterType = typeof(Utilities.BoolConverter))]
        public int HasCustomFolders { get; }

        [JsonProperty(PropertyName = "bor", ItemConverterType = typeof(Utilities.BoolConverter))]
        public bool HasCustomBorders { get; }

        [JsonProperty(PropertyName = "sfx", ItemConverterType = typeof(Utilities.BoolConverter))]
        public bool HasSFX { get; }
    }
}
