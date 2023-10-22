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

namespace Work
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




        private void Click7(object sender, RoutedEventArgs e)
        {
            if(tb.Text == "0")
                tb.Text = "";
            tb.Text = "7";
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "8";
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "9";
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "4";
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "5";
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "6";
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "1";
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "2";
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "3";
        }

        private void Click0(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
                tb.Text = "";
            tb.Text = "0";
        }
    }
}
