using System;
using SharpThemes.Objects;
using Newtonsoft.Json;
using System.Diagnostics;

namespace SharpThemes.Utilities
{
    public class ScreenTypeConverter : JsonConverter 
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue((ScreenType)value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            switch (int.Parse(reader.Value.ToString())) {
                case 3: return ScreenType.Custom;
                case 1: return ScreenType.SolidColour;
            }
            return ScreenType.Default;
        }

        public override bool CanConvert(Type objectType) {
            return true;
        }
    }
}
