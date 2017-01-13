using Newtonsoft.Json;

namespace SharpThemes.Classes 
{
    class Theme 
    {
        public readonly int ID;
        public readonly string Name;
        public readonly string Description;
        public readonly string CreatedBy;
        public readonly int Downloads;
        public readonly bool IsNSFW;
        public readonly bool IsApproved;
        public readonly string BGM;
        public readonly bool HasBGM;
        public readonly int Type;
        public readonly string Tags;
        public readonly ThemeInfo Info;
        public readonly bool FilesUpdated;
        public readonly bool IsArchived;
        public readonly string Notif;
    }
}
