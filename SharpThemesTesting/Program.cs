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
            Console.Title = "SharpThemes Demo";
            Console.WriteLine(@"          _____ __                   ________                            ");
            Console.WriteLine(@"         / ___// /_  ____ __________/_  __/ /_  ___  ____ ___  ___  _____");
            Console.WriteLine(@"         \__ \/ __ \/ __ `/ ___/ __ \/ / / __ \/ _ \/ __ `__ \/ _ \/ ___/");
            Console.WriteLine(@"        ___/ / / / / /_/ / /  / /_/ / / / / / /  __/ / / / / /  __(__  ) ");
            Console.WriteLine(@"       /____/_/ /_/\__,_/_/  / .___/_/ /_/ /_/\___/_/ /_/ /_/\___/____/  ");
            Console.WriteLine(@"                            /_/ A demo application for SharpThemes       ");
            Console.WriteLine(@"--------------------------------------------------------------------------------");
            var test = Task.Run(() => ThemeClient.GetMostRecentThemes()).Result;
            Console.WriteLine("Most recent themes:");
            foreach (Theme t in test.Themes)
            {
                Console.WriteLine($" - {t.Name} [Downloads: {t.Downloads}]" + (t.IsNSFW ? " [NSFW]" : "") + $" by {t.CreatedBy}");
            }
            Console.Read();
        }
    }
}
