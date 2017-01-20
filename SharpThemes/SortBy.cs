using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpThemes.Objects
{
    public class SortBy {
        private string text = "sort:recent";

        public static readonly SortBy Downloads = new SortBy("sort:dl");
        public static readonly SortBy RecentlyUploaded = new SortBy("sort:recent");

        private SortBy(string text) {
            this.text = text;
        }

        public override string ToString() {
            return text.ToString();
        }
    }
}
