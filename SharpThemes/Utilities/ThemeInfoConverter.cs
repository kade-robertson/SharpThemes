using System;
using SharpThemes.Objects;
using Newtonsoft.Json;

namespace SharpThemes.Utilities 
{
    class ThemeInfoConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue((int)value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            switch (int.Parse(reader.Value.ToString())) {
                case 0: return ThemeInfoType.NormalScrollingScreen;
                case 2: return ThemeInfoType.FlipBookScreen;
            }
            return ThemeInfoType.NoScrollingScreen;
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(ThemeInfoType);
        }
    }
}
