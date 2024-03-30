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

namespace Exo1_JeuDeDeplacements
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

        private void top_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(bouboulerose, GetYPosition(-2));
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(bouboulerose, GetXPosition(2));
        }

        private void bottom_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(bouboulerose, GetYPosition(2));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double xBalle = Canvas.GetLeft(bouboulerose);
            Canvas.SetLeft(bouboulerose, GetXPosition(-2));
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            double xBalle = Canvas.GetLeft(bouboulerose);
            double yBalle = Canvas.GetTop(bouboulerose);

            switch(e.Key)
            {
                case Key.Up: yBalle = GetYPosition(-2); break;
                case Key.Down: yBalle = GetYPosition(2); break;
                case Key.Left: xBalle = GetXPosition(-2); break;
                case Key.Right: xBalle = GetXPosition(2); break;
            }

            Canvas.SetTop(bouboulerose, yBalle);
            Canvas.SetLeft(bouboulerose, xBalle);
        }

        private double GetXPosition(double x)
        {
            double newX = Canvas.GetLeft(bouboulerose) + x;

            if (newX <= 0) newX = 0;
            else if (newX >= 220) newX = 220;
            return newX;
        }

        private double GetYPosition(double y)
        {
            double newY = Canvas.GetTop(bouboulerose) + y;

            if (newY <= 0) newY = 0;
            else if (newY >= 200) newY = 200;
            return newY;
        }
    }
}
