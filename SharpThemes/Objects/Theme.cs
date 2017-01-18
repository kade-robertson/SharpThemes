using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SharpThemes.Objects
{
    public class Theme 
    {
        [JsonProperty(PropertyName = "id")]
        public uint ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "desc")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "by")]
        public string CreatedBy { get; set; }

        [JsonProperty(PropertyName = "dl")]
        public uint Downloads { get; set; }

        [JsonProperty(PropertyName = "nsfw")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsNSFW { get; set; }

        [JsonProperty(PropertyName = "approved")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsApproved { get; set; }

        [JsonProperty(PropertyName = "bgm")]
        public string BackgroundMusic { get; set; }

        [JsonProperty(PropertyName = "hasbgm")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasBackgroundMusic { get; set; }

        [JsonProperty(PropertyName = "type")]
        public uint Type { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonIgnore]
        public List<string> TagList {
            get {
                return Tags.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            }
        }

        [JsonProperty(PropertyName = "info")]
        public string InfoString;

        [JsonIgnore]
        public ThemeInfo Info { get { return JsonConvert.DeserializeObject<ThemeInfo>(InfoString); } }

        [JsonProperty(PropertyName = "filesupdated")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool FilesUpdated { get; set; }

        [JsonProperty(PropertyName = "archived")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsArchived { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
