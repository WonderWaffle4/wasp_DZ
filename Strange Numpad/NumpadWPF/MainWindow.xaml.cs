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
        private readonly DispatcherTimer timer = new DispatcherTimer();
        private readonly DispatcherTimer buttonSwapper = new DispatcherTimer();
        private readonly Random random = new Random();
        private readonly Button[] buttonsCollection;
        private byte randomRange;
        private int buffer;
        private int swapBuffer;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(5);
            buttonSwapper.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_Tick;
            buttonSwapper.Tick += buttonSwapper_Tick;
            buttonSwapper.Start();
            buttonsCollection = new Button[10]
            {
               button0,
               button1,
               button2,
               button3,
               button4,
               button5,
               button6,
               button7,
               button8,
               button9
            };
        }

        private void timer_Tick(object sender, object e)
        {
            passwordBox.Text = "";
            UIAccess(true);
            timer.Stop();
            buttonSwapper.Start();
        }

        private void buttonSwapper_Tick(object sender, object e)
        {
            List<string> number = new List<string>(){ "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            randomRange = 10;
            foreach(Button button in buttonsCollection)
            {
                buffer = random.Next(0, randomRange);
                button.Content = number[buffer];
                button.Background = new SolidColorBrush(
                    Color.FromRgb(
                        Convert.ToByte(random.Next(128, 256)),
                        Convert.ToByte(random.Next(128, 256)),
                        Convert.ToByte(random.Next(128, 256))
                    )
                );
                number.Remove(number[buffer]);
                randomRange--;
            }
        }

        private void swapButtons(ref Button button)
        {
            do
            {
                swapBuffer = random.Next(0, 10);
            } while (buttonsCollection[swapBuffer].Content == button.Content);
            (button.Content, buttonsCollection[swapBuffer].Content) = (buttonsCollection[swapBuffer].Content, button.Content);
            (button.Background, buttonsCollection[swapBuffer].Background) = (buttonsCollection[swapBuffer].Background, button.Background);
        }

        private void Button_Click_X(object sender, RoutedEventArgs e)
        {
            passwordBox.Text = "";
            SolidColorBrush alphaZero = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            button0.Foreground = alphaZero;
            button1.Foreground = alphaZero;
            button2.Foreground = alphaZero;
            button3.Foreground = alphaZero;
            button4.Foreground = alphaZero;
            button5.Foreground = alphaZero;
            button6.Foreground = alphaZero;
            button7.Foreground = alphaZero;
            button8.Foreground = alphaZero;
            button9.Foreground = alphaZero;
            button0.Foreground = alphaZero;
            buttonOk.Foreground = alphaZero;
            buttonX.Foreground = alphaZero;
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
                buttonSwapper.Stop();
                timer.Start();
            }
        }

        private void On_Click(string option)
        {
            double left = random.Next(0, 71);
            double right = 70 - left;
            double top = random.Next(0, 256);
            double bottom = 255 - top;
            passwordBox.Margin = new Thickness(left, top, right, bottom);
            switch (option)
            {
                case "1":
                    passwordBox.AppendText("1");
                    break;
                case "2":
                    passwordBox.AppendText("2");
                    break;
                case "3":
                    passwordBox.AppendText("3");
                    break;
                case "4":
                    passwordBox.AppendText("4");
                    break;
                case "5":
                    passwordBox.AppendText("5");
                    break;
                case "6":
                    passwordBox.AppendText("6");
                    break;
                case "7":
                    passwordBox.AppendText("7");
                    break;
                case "8":
                    passwordBox.AppendText("8");
                    break;
                case "9":
                    passwordBox.AppendText("9");
                    break;
                case "0":
                    passwordBox.AppendText("0");
                    break;
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

        private void button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Button button = e.Source as Button;
            On_Click(button.Content.ToString());
        }

        private void button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = sender as Button;
            swapButtons(ref button);
        }

        
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  