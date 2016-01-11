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

namespace Hentai_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page1 addAnimePage;
        private static MainWindow mainWindow;
        private  AnimeList animeList;
    
        public MainWindow()
        {
            InitializeComponent();
            addAnimePage = new Page1();
            mainWindow = this;
            animeList = new AnimeList();
        }

        private void AddHentai_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(addAnimePage);
        }
        public static void GoToMainPage()
        {
            mainWindow.MainFrame.Content = null;
             
        }
        
        private void List_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(animeList);
        }

    }
}
