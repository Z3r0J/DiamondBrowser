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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        /*Desarrollado Por Jean Carlos Reyes Encarnacion
*/
        //Desarrollado Por Jean Carlos Reyes
        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            bunifuCustomLabel1.Text = "Historial de Diamond Browser";

            frmHistory history = new frmHistory();
            history.TopLevel = false;
            panel1.Controls.Add(history);
            panel1.Dock = DockStyle.Right;
            panel1.AutoScroll = true;
            history.Show();
        }
        /*Desarrollado Por Jean Carlos Reyes Encarnacion
*/
        //Desarrollado Por Jean Carlos Reyes
        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            bunifuCustomLabel1.Text = "Tus Paginas Favoritas";

            frmFavorite favorite = new frmFavorite();
            favorite.TopLevel = false;
            panel1.Controls.Add(favorite);
            panel1.Dock = DockStyle.Right;
            panel1.AutoScroll = true;
            favorite.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
