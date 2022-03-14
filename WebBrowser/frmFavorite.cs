﻿using System;
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
    public partial class frmFavorite : Form
    {
        public frmFavorite()
        {
            InitializeComponent();
            AgregadoItem();
        }

        int poss = 10;
        /*Desarrollado Por Jean Carlos Reyes Encarnacion
*/
        //Desarrollado Por Jean Carlos Reyes
        public void AgregadoItem() {
            int number = ListHistoryFavorites.Instance.Histories.Count;
            Panel[] panels =  new Panel[number];
            frmItem[] items = new frmItem[number];
            int i = 0;

            foreach (var Favorites in ListHistoryFavorites.Instance.Favorites)
            {
                panels[i] = new Panel();
                items[i] = new frmItem(Favorites);
                items[i].TopLevel = false;
                panels[i].Width=498;
                panels[i].Height = 47;
                panels[i].BackColor = Color.Azure;
                panels[i].Dock = DockStyle.None;
                panels[i].Top = poss;
                poss = panels[i].Top + panels[i].Height + 10;
                items[i].Show();
                panels[i].Controls.Add(items[i]);
                panel1.AutoScroll = true;
                panel1.Controls.Add(panels[i]);
                i++;
            }
        }
    }
}
