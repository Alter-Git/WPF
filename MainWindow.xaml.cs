using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Drawing;
using SkiaSharp;
using System.Globalization;
using System.Threading;

namespace MyScripts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tab_Explorer_Button_Scan_Click(object sender, RoutedEventArgs e)
        {
            string path = tab_explorer_text_path.Text.Trim();            
            if (path != null)
                listview_files.ItemsSource = MenuManager.GetDirectoryFiles(path);

        }

        private void Tab_Bitmaper_Button_Generate_Click(object sender, RoutedEventArgs e)
        {
            listbox_bitmaps.ItemsSource = MenuManager.GetListboxItems(20);
        }


    }
}
