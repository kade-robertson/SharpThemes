using Newtonsoft.Json;

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
        [JsonProperty(PropertyName = "top", ItemConverterType = typeof(Utilities.ScreenTypeConverter))]
        public ScreenType TopScreenType { get; }

        [JsonProperty(PropertyName = "topf", ItemConverterType = typeof(Utilities.ScrollTypeConverter))]
        public ScrollType TopScreenScrollType { get; }

        [JsonProperty(PropertyName = "bot", ItemConverterType = typeof(Utilities.ScreenTypeConverter))]
        public ScreenType BottomScreenType { get; }

        [JsonProperty(PropertyName = "botf", ItemConverterType = typeof(Utilities.ScrollTypeConverter))]
        public ScrollType BottomScreenScrollType { get; }

        [JsonProperty(PropertyName = "fol", ItemConverterType = typeof(Utilities.BoolConverter))]
        public int HasCustomFolders { get; }

        [JsonProperty(PropertyName = "bor", ItemConverterType = typeof(Utilities.BoolConverter))]
        public bool HasCustomBorders { get; }

        [JsonProperty(PropertyName = "sfx", ItemConverterType = typeof(Utilities.BoolConverter))]
        public bool HasSFX { get; }
    }
}
