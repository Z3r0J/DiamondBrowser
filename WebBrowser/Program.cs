using EasyTabs;
using System;
using System.Windows.Forms;

namespace WebBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppContainer container = new AppContainer();

            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new frmMain
                    {
                        Text = "Diamond Tab"
                    }
                }
                );

            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();

            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
