using SharpThemes;
using SharpThemes.Utilities;
using SharpThemes.Objects;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using System.Net;

namespace SharpThemesTesting 
{
    class Program
    {
        static void Main(string[] args) {
            var test = Task.Run(() => ThemeClient.Search()).Result;
            Console.WriteLine("Most recent themes:");
            foreach (Theme t in test.Themes)
            {
                Console.WriteLine($" - {t.Name} [Downloads: {t.Downloads}]");
                Console.WriteLine($"    - Download: {t.DownloadURL}");
                Console.WriteLine($"    - Preview: {t.PreviewImageURL}");
                Console.WriteLine($"    - Background Music: {t.BackgroundMusicURL}");
            }
            Console.Read();
        }
    }
}
