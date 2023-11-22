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

namespace Exo2_JeuDeTir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlaceCibleArea();
        }

        private void PlaceCibleArea()
        {
            Random r = new Random();
            int randomX = r.Next(1, 220);
            int randomY = r.Next(1, 200);
            Canvas.SetLeft(Cible, 0);
            Canvas.SetTop(Cible, 0);
        }

        private void ShootButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckXAndYNotNull()) return;

            double x = double.Parse(xTb.Text);
            double y = double.Parse(yTb.Text);

            Point p1 = new Point(Canvas.GetLeft(Cible) + 20, Canvas.GetTop(Cible) + 10);
            Point p2 = new Point(Canvas.GetRight(Cible) + 40, Canvas.GetTop(Cible) - 10);

            Rect r = new Rect(p1, p2);

            if (r.Contains(new Point(x + 20, y + 10)))
            {
                Result.Content = "Bien joué !";
                ShootButton.IsEnabled = false;
                ReplayBtn.IsEnabled = true;
            }
            else Result.Content = "Loupé !";
        }

        private bool CheckXAndYNotNull()
        {
            if (xTb.Text.Length == 0 || yTb.Text.Length == 0)
            {
                MessageBox.Show("Veuillez renseigner les deux valeurs X et Y !", "Counter Strike 1.6", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        private void ReplayBtn_Click(object sender, RoutedEventArgs e)
        {
            xTb.Text = "";
            yTb.Text = "";
            ReplayBtn.IsEnabled = false;
            ShootButton.IsEnabled = true;

            PlaceCibleArea();
        }
    }
}
