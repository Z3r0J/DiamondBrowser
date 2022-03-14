using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public sealed class ListHistoryFavorites
    {
        public static ListHistoryFavorites Instance { get; } = new ListHistoryFavorites();

        public List<History> Histories = new List<History>();
        public List<Favorite> Favorites = new List<Favorite>();

        private ListHistoryFavorites()
        {

        }
    }
}
