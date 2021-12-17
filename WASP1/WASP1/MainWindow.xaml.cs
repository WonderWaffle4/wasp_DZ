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

namespace WASP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer timer = new DispatcherTimer();
        Thickness margin = new Thickness(0, 0, 0, 0);
        bool isWin = false;
        string[] phrases = new string[]
        {
            "Click me!",
            "I'm a Button",
            "Don't click me\nplease!",
            "You can't\ncatch me!",
            "Free ROBUX!\nClick to get!",
            "I'm a bad Button!",
            "I'm the best\nButton!",
            "Try it!",
            "There's no way\nyou can\ndo this!"
        };
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Start();
        }
        private void timer_Tick(object sender, object e)
        {
            button_Setup();
        }

        private void button_Setup()
        {
            Button button = new Button();
            ///button.Margin = margin;
            button.Height = 100;
            button.Width = 100;
            button.Click += button_Click;
            byte[] color = new byte[3];
            random.NextBytes(color);
            button.Background = new SolidColorBrush(Color.FromRgb(color[0], color[1], color[2]));
            button.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            button.Content = phrases[random.Next(0, 9)];
            button.MouseEnter += button_MouseEnter;
            grid.Children.Add(button);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!isWin)
            {
                MessageBox.Show("YOU WIN!", "Congratulations!", MessageBoxButton.OK, MessageBoxImage.Information);
                timer.Stop();
                isWin = true;
            } 
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = e.Source as Button;
            double left = random.Next(0, 650);
            double right = 650 - left;
            double top = random.Next(0, 450);
            double bottom = 450 - top;
            button.Margin = new Thickness(left, top, right, bottom);
        }
    }
}
