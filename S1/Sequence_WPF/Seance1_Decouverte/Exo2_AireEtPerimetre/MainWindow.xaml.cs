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

namespace Exo2_AireEtPerimetre
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

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            double longueur = double.Parse(String.IsNullOrEmpty(Longueur.Text) ? "0" : Longueur.Text); // Récupération de la longueur (0 si vide)
            double largeur = double.Parse(String.IsNullOrEmpty(Largeur.Text) ? "0" : Largeur.Text); // Récupération de la largeur (0 si vide)

            double aire = Math.Round(longueur * largeur, 2); // Calcul de l'aire arrondie
            double permietre = Math.Round((longueur + largeur)*2, 2); // Calcul du pèrimètre arrondie

            int selectedItem = Box.SelectedIndex; // Récupération de l'index de l'item séléctionné
            string unity = Get_Unity(selectedItem); // Récupération de l'unité

            Aire.Content = "Aire : " + aire.ToString() + unity; // Mise à jour de la valeur de l'aire
            Perimeter.Content = "Périmètre : " +  permietre.ToString() + unity; // Mise à jour de la valeur du périmètre
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            Aire.Content = "Aire :"; // Réinitialisation des Labels.
            Perimeter.Content = "Périmètre :"; // Réinitialisation des Labels.
        }

        private string Get_Unity(int index)
        {
            switch (index)
            {
                case 0: return "mm"; // Renvoie du millimètre si le millimètre est sélectionné
                case 1: return "cm"; // Renvoie du centimètre si le centimètre est sélectionné
                case 2: return "m"; // Renvoie du mètre si le mètre est sélectionné
                case 3: return "km"; // Renvoie du kilomètre si le kilomètre est sélectionné
                default: return "m"; // Renvoie du mètre si aucun item n'est sélectionné
            }
        }

        private void Box_Initialized(object sender, EventArgs e)
        {
            Box.Items.Add("Millimètre"); // Ajout de l'unité centimètre
            Box.Items.Add("Centimètre"); // Ajout de l'unité centimètre
            Box.Items.Add("Mètre"); // Ajout de l'unité mètre
            Box.Items.Add("Kilomètre"); // Ajout de l'unité kilomètre
        }
    }
}
