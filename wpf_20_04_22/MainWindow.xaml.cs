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

namespace wpf_20_04_22
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void thecactuscheck_checked(object sender, RoutedEventArgs e) 
        {
            thecactusrec.Visibility = Visibility.Visible;
        }
        private void thecactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            thecactusrec.Visibility = Visibility.Hidden;
        }
        private void bestcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            bestcactusrec.Visibility = Visibility.Visible;
        }
        private void bestcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            bestcactusrec.Visibility = Visibility.Hidden;
        }
        private void cactusescheck_checked(object sender, RoutedEventArgs e)
        {
            cactusesrec.Visibility = Visibility.Visible;
        }
        private void cactusescheck_unchecked(object sender, RoutedEventArgs e)
        {
            cactusesrec.Visibility = Visibility.Hidden;
        }
        private void icecreamcheck_checked(object sender, RoutedEventArgs e)
        {
            icecreamrec.Visibility = Visibility.Visible;
        }
        private void icecreamcheck_unchecked(object sender, RoutedEventArgs e)
        {
            icecreamrec.Visibility = Visibility.Hidden;
        }
        private void stockcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            stockcactusrec.Visibility = Visibility.Visible;
        }
        private void stockcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            stockcactusrec.Visibility = Visibility.Hidden;
        }
        private void paintingcactuscheck_checked(object sender, RoutedEventArgs e)
        {
            paintingcactusrec.Visibility = Visibility.Visible;
        }
        private void paintingcactuscheck_unchecked(object sender, RoutedEventArgs e)
        {
            paintingcactusrec.Visibility = Visibility.Hidden;
        }
    }
}
