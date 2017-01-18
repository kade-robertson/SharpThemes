using System;
using SharpThemes.Objects;
using Newtonsoft.Json;

namespace SharpThemes.Utilities
{
    public class ScreenTypeConverter : JsonConverter 
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue((int)value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            switch (int.Parse(reader.Value.ToString())) {
                case 0: return ScreenType.Default;
                case 1: return ScreenType.SolidColour;
            }
            return ScreenType.Custom;
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(ScrollType);
        }
    }
}
