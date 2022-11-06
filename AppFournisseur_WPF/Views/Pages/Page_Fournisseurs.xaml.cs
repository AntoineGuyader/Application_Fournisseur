using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
            SuppliersGroupBy();
        }
        /// <summary>
        /// Tri les fournisseurs selon s'ils sont actifs, inactifs ou les deux
        /// </summary>
        private void SuppliersGroupBy()
        {
            string property = ComboBox_SuppliersGroupBy.SelectedValue.ToString();
            ObservableCollection<Fournisseur> allSuppliers = MV_Fournisseur.GetAllSuppliers();
            if (ListAllSuppliers != null)
            {
                ListAllSuppliers.VerticalContentAlignment = VerticalAlignment.Center;
                ListAllSuppliers.Items.DetachFromSourceCollection();
                if (property == "Actif")
                {
                    ListAllSuppliers.ItemsSource = allSuppliers.Where(fournisseur => fournisseur.inactif == false).ToList();
                }
                else
                {
                    if (property == "Inactif")
                    {
                        ListAllSuppliers.ItemsSource = allSuppliers.Where(fournisseur => fournisseur.inactif == true).ToList();
                    }
                    else
                    {
                        if (property == "Actif et Inactif")
                        {
                            ListAllSuppliers.ItemsSource = allSuppliers.OrderBy(fournisseur => fournisseur.inactif);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Utilise la fonction SupplierGroupBy pour modifier la liste des fourisseurs à chaque changement du combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuppliersGroupBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SuppliersGroupBy();
        }
    }
}
