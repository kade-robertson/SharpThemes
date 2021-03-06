﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SharpThemes.Objects
{
    public class Splash {
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

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonIgnore]
        public List<string> TagList {
            get {
                return Tags.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            }
        }

        [JsonProperty(PropertyName = "info")]
        private string InfoString;

        [JsonIgnore]
        public List<string[]> VariationPreviews { get { return JsonConvert.DeserializeObject<List<string[]>>(InfoString); } }

        [JsonProperty(PropertyName = "filesupdated")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool FilesUpdated { get; set; }

        [JsonProperty(PropertyName = "archived")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsArchived { get; set; }

        [JsonIgnore]
        public string DownloadURL {
            get {
                return $"https://3dsthem.es/downloadTheme.php?i={ID}&v=0";
            }
        }

        public string GetDownloadVariationURL(uint variation) {
            return $"https://3dsthem.es/downloadTheme.php?i={ID}&v={variation}";
        }

        public override string ToString() {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
