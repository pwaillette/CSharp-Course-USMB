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

namespace Exo1_ConversionFahrenheitCelsius
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

        private void CtoF_Btn_Click(object sender, RoutedEventArgs e)
        {
            double celsius = double.Parse(String.IsNullOrEmpty(txtCelsius.Text) ? "0" : txtCelsius.Text); // Récupération du nombre de celsius (0 si vide)
            double faren = Math.Round(1.8 * celsius + 32, 2); // Calcul et arrondissement du résultat pour plus de propreté
            txtFahrenheit.Text = faren.ToString(); // Affichage du résultat
        }

        private void FtoC_Btn_Click(object sender, RoutedEventArgs e)
        {
            double farenheit = double.Parse(String.IsNullOrEmpty(txtFahrenheit.Text) ? "0" : txtFahrenheit.Text); // Récupération de la valeur fahrenheit (0 si vide)
            double celsius = Math.Round((farenheit - 32) / 1.8, 2); // Calcul et arrondissement du résultat pour plus de propreté
            txtCelsius.Text = celsius.ToString(); // Affichage du résultat
        }

        private void txtCelsius_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCelsius.Text = ""; // Réinitialisation des valeurs
            txtFahrenheit.Text = ""; // Réinitialisation des valeurs
        }

        private void txtFahrenheit_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCelsius.Text = ""; // Réinitialisation des valeurs
            txtFahrenheit.Text = ""; // Réinitialisation des valeurs
        }
    }
}
