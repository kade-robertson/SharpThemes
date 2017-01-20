using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpThemes
{
    public class TopList 
    {
        private string text = "?recent";

        public static readonly TopList MostPopular = new TopList("?popular");
        public static readonly TopList MostRecent = new TopList("?recent");

        private TopList(string text) {
            this.text = text;
        }

        public override string ToString() {
            return text.ToString();
        }
    }
}
