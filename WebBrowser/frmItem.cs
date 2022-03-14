using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
            
        }
        public frmItem(History history)
        {
            InitializeComponent();
            pbxIcon.Image = history.Icon;
            LblTitle.Text = history.Title;
            lblUrl.Text = history.URL;
            LblHour.Visible = true;
            lblUrl.Visible = true;
            LblHour.Text = history.DateVisited.ToString("h:mm tt");
        }

        public frmItem(Favorite favorite)
        {
            InitializeComponent();
            LblHour.Visible = false;
            lblUrl.Visible = true;
            LblTitle.Text = favorite.Title;
            lblUrl.Text = favorite.URL;
            this.Width = 498;
            this.Height = 47;
        }
    }
}
