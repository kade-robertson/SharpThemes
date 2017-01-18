using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace SharpThemes.Objects
{
    public class Theme 
    {
        [JsonProperty(PropertyName = "id")]
        public uint ID { get; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; }

        [JsonProperty(PropertyName = "desc")]
        public string Description { get; }

        [JsonProperty(PropertyName = "by")]
        public string CreatedBy { get; }

        [JsonProperty(PropertyName = "dl")]
        public uint Downloads { get; }

        [JsonProperty(PropertyName = "nsfw")]
        public bool IsNSFW { get; }

        [JsonProperty(PropertyName = "approved")]
        public bool IsApproved { get; }

        [JsonProperty(PropertyName = "bgm")]
        public string BackgroundMusic { get; }

        [JsonProperty(PropertyName = "hasbgm")]
        public bool HasBackgroundMusic { get; }

        [JsonProperty(PropertyName = "type")]
        public uint Type { get; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; }

        public List<string> TagList {
            get {
                return Tags.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            }
        }

        [JsonProperty(PropertyName = "info")]
        public ThemeInfo Info { get; }

        [JsonProperty(PropertyName = "filesupdated")]
        public bool FilesUpdated { get; }

        [JsonProperty(PropertyName = "archived")]
        public bool IsArchived { get; }

        [JsonProperty(PropertyName = "notif")]
        public string Notif { get; }
    }
}
