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

namespace Exo1_Formulaire
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

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckRequiredElements()) return;

            String text = "";
            text += "Nom : " + txNom.Text.ToString() + "\n";
            text += "Prénom : " + txPrenom.Text.ToString() + "\n";
            text += "Sexe : " + GetSexe() + "\n";
            text += "Date de naissance : " + GetBornDate() + "\n";
            text += "Adresse : " + txAdresse.Text.ToString() + "\n";
            text += "Code Postal : " + txCodePostal.Text.ToString() + "\n";
            text += "Ville : " + txVille.Text.ToString();
            text += "Pays : " + ((ComboBoxItem)this.cbPays.SelectedItem).Content;

            MessageBox.Show(text, "Informations");
        }

        private string GetBornDate()
        {
            String dateNaissance = "";
            if (dpDate.SelectedDate != null)
            {
                // Conversion de DateTime? (possiblement null) en DateTime (non null)
                DateTime dateAnni = ((DateTime)dpDate.SelectedDate);
                dateNaissance = dateAnni.ToShortDateString();
            }

            return dateNaissance;
        }

        private string GetSexe()
        {
            return (rbFemme.IsChecked == true) ? "Femme" : "Homme";
        }

        private bool CheckRequiredElements()
        {

            if (String.IsNullOrWhiteSpace(txNom.Text))
            {
                txNom.BorderBrush = Brushes.Red;
                return false;
            } 
            else txNom.BorderBrush = Brushes.Gray;

            if (String.IsNullOrWhiteSpace(txPrenom.Text))
            {
                txPrenom.BorderBrush = Brushes.Red;
                return false;
            } else txPrenom.BorderBrush = Brushes.Gray;

            if (String.IsNullOrWhiteSpace(txAdresse.Text))
            {
                txAdresse.BorderBrush = Brushes.Red;
                return false;
            }
            else txAdresse.BorderBrush = Brushes.Gray;

            if (String.IsNullOrWhiteSpace(txCodePostal.Text))
            {
                txCodePostal.BorderBrush = Brushes.Red;
                return false;
            }
            else txCodePostal.BorderBrush = Brushes.Gray;

            if (String.IsNullOrWhiteSpace(txVille.Text))
            {
                txVille.BorderBrush = Brushes.Red;
                return false;
            }
            else txVille.BorderBrush = Brushes.Gray;

            if (rbFemme.IsChecked == false && rbHomme.IsChecked == false)
            {
                lbSexe.Foreground = Brushes.Red;
                return false;
            }
            else lbSexe.Foreground = Brushes.Gray;

            if (dpDate.SelectedDate == null)
            {
                lbDateNaissance.Foreground = Brushes.Red;
                return false;
            }
            else lbDateNaissance.Foreground = Brushes.Gray;

            if (cbPays.SelectedItem == null)
            {
                lbPays.Foreground = Brushes.Red;
                return false;
            }
            else lbPays.Foreground = Brushes.Gray;

            if (cbCGV.IsChecked == false)
            {
                cbCGV.BorderBrush = Brushes.Red;
                return false;
            } else cbCGV.BorderBrush = Brushes.Gray;

            return true;
        }
    }
}
