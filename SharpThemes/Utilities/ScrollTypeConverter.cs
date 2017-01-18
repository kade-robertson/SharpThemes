using System;
using SharpThemes.Objects;
using Newtonsoft.Json;

namespace SharpThemes.Utilities 
{
    public class ScrollTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue((int)value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            switch (int.Parse(reader.Value.ToString())) {
                case 0: return ScrollType.NormalScrolling;
                case 2: return ScrollType.Flipbook;
                case 3: return ScrollType.SlowScrolling;
                case 4: return ScrollType.FlipbookLoop;
            }
            return ScrollType.NoScrolling;
        }

        public override bool CanConvert(Type objectType) {
            return true;
        }
    }
}
