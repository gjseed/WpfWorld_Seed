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

namespace WpfWorld_Seed
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

        private void buttonclick_p1(object sender, RoutedEventArgs e)
        {
            Main.Content = new First();
        }

        private void buttonclick_p2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Second();
        }

        private void buttonclick_p3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Third();
        }
    }
}
