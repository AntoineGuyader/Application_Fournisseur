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
        ObservableCollection<Fournisseur> ListOfSuppliers { get; set; }
        public Page_Fournisseurs()
        {
            InitializeComponent();
            ListOfSuppliers = MV_Fournisseur.GetAllSuppliers();
            //AllSuppliers();
            //SuppliersGroupBy();

            ObservableCollection<Fournisseur> monTest = MV_Fournisseur.GetAllSuppliers();
            ListOfSuppliers = MV_Fournisseur.GetAllSuppliers();
            int zero = 0;
        }

        private void AllSuppliers()
        {
            ListAllSuppliers.ItemsSource = MV_Fournisseur.GetAllSuppliers();
            //var test = monTest
            // ListAllSuppliers.ItemsSource = MV_Fournisseur.GetAllSuppliers().OrderBy(fournisseur => fournisseur.inactif);
            // ListAllSuppliers.ItemsSource = MV_Fournisseur.GetAllSuppliers().Select(fournisseur => fournisseur.inactif == false);
            // ListAllSuppliers.ItemsSource = MV_Fournisseur.GetAllSuppliers().GroupBy(fournisseur => fournisseur.inactif = true);
            // ListAllSuppliers.ItemsSource = MV_Fournisseur.GetAllSuppliers().GroupBy(fournisseur => fournisseur.inactif = false);
            int zero = 0;
        }
        private void SuppliersGroupBy()
        {
            ListAllSuppliers.Items.GroupDescriptions.Clear();
            string property = ComboBox_SuppliersGroupBy.SelectedItem.ToString();

            //if (property == "Actif") ListAllSuppliers.


            
            int zero = 0;
        }
        private void SuppliersGroupBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
