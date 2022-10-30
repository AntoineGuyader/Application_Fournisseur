using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

using AppFournisseur_WPF.Models;
using AppFournisseur_WPF.ModelView;

namespace AppFournisseur_WPF.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour Page_Fournisseurs.xaml
    /// </summary>
    public partial class Page_Fournisseurs : Page
    {
        public Page_Fournisseurs()
        {
            InitializeComponent();
            AllSuppliers();
            //SuppliersGroupBy();

            ObservableCollection<Fournisseur> monTest = MV_Fournisseur.GetAllSuppliers();

            var query = monTest.Where(fournisseur => fournisseur.inactif == true);
        }

        private void AllSuppliers()
        {
            ListAllSuppliers.ItemsSource = MV_Fournisseur.GetAllSuppliers();
        }
        private void SuppliersGroupBy()
        {
            //ListAllSuppliers.Items.GroupDescriptions.Clear();
            string property = ComboBox_SuppliersGroupBy.SelectedValue.ToString();
            int un = 1 ;
            // ListAllSuppliers.Items.Clear();

            if (property == "Actif")
            {
                var activeSupppliers = MV_Fournisseur.GetAllSuppliers().Where(fournisseur => fournisseur.inactif == false).ToList();
                List<Fournisseur> list = activeSupppliers;
                int deux = 2;
                ListAllSuppliers.ItemsSource = activeSupppliers;
            }
            else
            {
                if (property == "Inactif")
                {
                    var inactiveSuppliers = MV_Fournisseur.GetAllSuppliers().Where(fournisseur => fournisseur.inactif == true);
                    MessageBox.Show("Fournisseurs inactifs");
                }
                else
                {
                    if (property == "Actif et Inactif")
                    {
                        var allSuppliers = MV_Fournisseur.GetAllSuppliers().OrderBy(fournisseur => fournisseur.inactif);
                        MessageBox.Show("Tous les fournisseurs");
                    }
                }
            }


            
            int zero = 0;
        }
        private void SuppliersGroupBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SuppliersGroupBy();
        }
    }
}
