using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TreeBuilder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private TreeViewModel treeViewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.treeViewModel = new TreeViewModel();

            MainWindow = new MainWindow(treeViewModel);
            MainWindow.Show();
        }
    }
}
