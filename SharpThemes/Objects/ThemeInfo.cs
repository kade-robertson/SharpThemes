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
        private uint m_TopScreenType;
        public ScreenType TopScreenType { get { return (ScreenType)m_TopScreenType; } set { m_TopScreenType = (uint)value; } }

        [JsonProperty(PropertyName = "topf")]
        private uint m_TopScreenScrollType;
        public ScrollType TopScreenScrollType { get { return (ScrollType)m_TopScreenScrollType; } set { m_TopScreenScrollType = (uint)value; } }

        [JsonProperty(PropertyName = "bot")]
        private uint m_BottomScreenType;
        public ScreenType BottomScreenType { get { return (ScreenType)m_BottomScreenType; } set { m_BottomScreenType = (uint)value; } }

        [JsonProperty(PropertyName = "botf")]
        private uint m_BottomScreenScrollType;
        public ScrollType BottomScreenScrollType { get { return (ScrollType)m_BottomScreenScrollType; } set { m_BottomScreenScrollType = (uint)value; } }

        [JsonProperty(PropertyName = "fol")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasCustomFolders { get; set; }

        [JsonProperty(PropertyName = "bor")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasCustomBorders { get; set; }

        [JsonProperty(PropertyName = "sfx")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasSFX { get; set; }
    }
}
