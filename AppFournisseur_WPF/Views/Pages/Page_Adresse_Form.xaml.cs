using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Diagnostics;
using AppFournisseur_WPF.Controllers;
using AppFournisseur_WPF.ModelView;
using AppFournisseur_WPF.Models;
using System.Collections.ObjectModel;

namespace AppFournisseur_WPF.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour Page_Adresse_Form.xaml
    /// </summary>
    public partial class Page_Adresse_Form : Page
    {
        MainWindow MainWindow = (MainWindow)Application.Current.MainWindow;
        public Page_Adresse_Form()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FormPays.ItemsSource = MV_Pays.GetAllCountries();
            FormPays.SelectedIndex = 0;
        }
        private void Btn_Validation_Adresse_Click(object sender, RoutedEventArgs e)
        {
            Adresse adresse = new Adresse();

            if (Verification.LettersOnly(FormVille.Text))
            {
                adresse.ville = FormVille.Text;

                if (Verification.LettersOnly(FormNomRue.Text))
                {
                    adresse.nom_rue = FormNomRue.Text;

                    if (Verification.IntOnly(FormNumRue.Text))
                    {
                        adresse.num_rue = int.Parse(FormNumRue.Text);

                        if (Verification.IntOnly(FormCP.Text) && (FormCP.Text.Length == 5))
                        {
                            adresse.code_postal = FormCP.Text;
                            if (FormComplement.Text.Length > 0) adresse.complement_adresse = FormComplement.Text;

                            adresse.pays = FormPays.SelectedIndex + 1;

                            MV_Adresse.AddAdress(adresse);

                            MainWindow.InitialDefault();
                        }
                        else MessageBox.Show("Code postal invalide, entiers uniquement");
                        
                    }
                    else MessageBox.Show("Numéro de la rue est invalide, entiers uniquement");
                }
                else MessageBox.Show("Nom de la rue invalide, charactères uniquement");

            }
            else MessageBox.Show("Nom de la ville invalide, charactères uniquement");
        }
    }
}
