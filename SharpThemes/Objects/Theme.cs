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
        private string m_Name;
        public string Name { get { return WebUtility.HtmlDecode(m_Name); } set { m_Name = value; } }

        [JsonProperty(PropertyName = "desc")]
        private string m_Description;
        public string Description { get { return WebUtility.HtmlDecode(m_Description); } set { m_Description = value; } }

        [JsonProperty(PropertyName = "by")]
        private string m_CreatedBy;
        public string CreatedBy { get { return WebUtility.HtmlDecode(m_CreatedBy); } set { m_CreatedBy = value; } }

        [JsonProperty(PropertyName = "dl")]
        public uint Downloads { get; set; }

        [JsonProperty(PropertyName = "nsfw")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsNSFW { get; set; }

        [JsonProperty(PropertyName = "approved")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsApproved { get; set; }

        [JsonProperty(PropertyName = "bgm")]
        private string m_BackgroundMusic;
        public string BackgroundMusic { get { return WebUtility.HtmlDecode(m_BackgroundMusic); } set { m_BackgroundMusic = value; } }

        [JsonProperty(PropertyName = "hasbgm")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool HasBackgroundMusic { get; set; }

        [JsonProperty(PropertyName = "type")]
        public uint Type { get; set; }

        [JsonProperty(PropertyName = "tags")]
        private string m_Tags;
        public string Tags { get { return WebUtility.HtmlDecode(m_Tags); } set { m_Tags = value; } }

        [JsonIgnore]
        public List<string> TagList {
            get {
                return Tags.Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            }
        }

        [JsonProperty(PropertyName = "info")]
        public string InfoString;
        public ThemeInfo Info { get { return JsonConvert.DeserializeObject<ThemeInfo>(WebUtility.HtmlDecode(InfoString)); } }

        [JsonProperty(PropertyName = "filesupdated")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool FilesUpdated { get; set; }

        [JsonProperty(PropertyName = "archived")]
        [JsonConverter(typeof(Utilities.BoolConverter))]
        public bool IsArchived { get; set; }
    }
}
