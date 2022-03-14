using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class History
    {
        public Bitmap Icon { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime DateVisited { get; set; }

    }
}
