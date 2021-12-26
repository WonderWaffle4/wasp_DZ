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
using System.Windows.Threading;

namespace NumpadWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, object e)
        {
            passwordBox.Text = "";
            UIAccess(true);
            timer.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("3");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("4");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("5");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("6");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("7");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("8");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("9");
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            passwordBox.AppendText("0");
        }

        private void Button_Click_X(object sender, RoutedEventArgs e)
        {
            passwordBox.Text = "";
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Text == "332168")
            {
                UIAccess(false);
                passwordBox.Text = "Access Granted";
            }
            else
            {
                passwordBox.Text = "Error";
                UIAccess(false);
                timer.Start();
            }
        }

        private void UIAccess(bool access)
        {
            button0.IsEnabled = access;
            button1.IsEnabled = access;
            button2.IsEnabled = access;
            button3.IsEnabled = access;
            button4.IsEnabled = access;
            button5.IsEnabled = access;
            button6.IsEnabled = access;
            button7.IsEnabled = access;
            button8.IsEnabled = access;
            button9.IsEnabled = access;
            buttonOk.IsEnabled = access;
            buttonX.IsEnabled = access;
            passwordBox.IsEnabled = access;
        }

        private void passwordBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
