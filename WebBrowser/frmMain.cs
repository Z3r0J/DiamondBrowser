using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using System;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmMain : Form
    {
        private History History;
        private Favorite favorite;
        private bool IsFavorite = false;
        /*Desarrollado Por Jean Carlos Reyes Encarnacion
*/
        //Desarrollado Por Jean Carlos Reyes
        public frmMain()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public ChromiumWebBrowser chromeBrowser;
        public void InitializeChromium()
        {
            CefSettings cefSettings = new CefSettings();

            if (!Cef.IsInitialized)
            {
                Cef.Initialize(cefSettings);
            }

            chromeBrowser = new ChromiumWebBrowser("https://google.com");

            pnlBody.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
            HistoryData();
        }

        private void HistoryData()
        {
            History = new History();
            History.URL = chromeBrowser.Address;
            History.Icon = this.Icon.ToBitmap();
            History.DateVisited = DateTime.Now;
            History.Title = Text;
            ListHistoryFavorites.Instance.Histories.Add(History);
        }
        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                Text = e.Title;
                HistoryData();
                CambiarImagen();

            });
        }

        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                loader.Visible = e.IsLoading;
                txtUrl.Text = chromeBrowser.Address;
                SecurityIcon.Image = chromeBrowser.Address.StartsWith("https") ? imageList1.Images[0] : imageList1.Images[1];
            });
        }

        protected TitleBarTabs ParentTab
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUrl(txtUrl.Text.Trim());
            }

        }

        void LoadUrl(string url)
        {
            if (url.StartsWith("http") || url.Contains(":") || url.Contains(".") && !url.Contains(" "))
            {
                chromeBrowser.Load(url);
            }
            else
            {
                chromeBrowser.Load($"https://google.com/search?q={url}");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();

            settings.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            favorite = new Favorite();
            favorite.URL = chromeBrowser.Address;
            favorite.Icon = this.Icon.ToBitmap();
            favorite.Title = Text;

            if (IsFavorite)
            {
                ListHistoryFavorites.Instance.Favorites.RemoveAll(x => x.Title == Text);
                CambiarImagen();
            }
            else if (ListHistoryFavorites.Instance.Favorites.Contains(favorite) == true)
            {
                CambiarImagen();
            }
            else
            {
                ListHistoryFavorites.Instance.Favorites.Add(favorite);
                CambiarImagen();
            }
        }

        void CambiarImagen()
        {
            if (ListHistoryFavorites.Instance.Favorites.Count>0)
            {
                foreach (var item in ListHistoryFavorites.Instance.Favorites)
                {
                    if (item.URL.Equals(chromeBrowser.Address))
                    {
                        IsFavorite = true;
                        pictureBox1.Image = null;
                        pictureBox1.Image = item.URL == chromeBrowser.Address ? Properties.Resources.favorite : Properties.Resources.no_favorite;
                        break;
                    }
                    else
                    {
                        IsFavorite = false;
                        pictureBox1.Image = Properties.Resources.no_favorite;
                        continue;
                    }

                }
            }
            else
            {
                IsFavorite = false;
                pictureBox1.Image = Properties.Resources.no_favorite;
            }
            /*Desarrollado Por Jean Carlos Reyes Encarnacion
*/
            //Desarrollado Por Jean Carlos Reyes
        }
    }
}
