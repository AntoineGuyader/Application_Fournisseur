using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using AppFournisseur_WPF.Controllers;
using AppFournisseur_WPF.Models;
using AppFournisseur_WPF.ModelView;

namespace AppFournisseur_WPF.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour Page_Articles.xaml
    /// </summary>
    public partial class Page_Articles : Page
    {
        public Page_Articles()
        {
            InitializeComponent();
            ListViewArticles.ItemsSource = DataTableArticles().DefaultView;
        }
        public ObservableCollection<Produit_Ref> ListArticles()
        {
            ObservableCollection<Produit_Ref> list = MV_Article.GetAllArticles();
            return list;
        }
        public DataTable DataTableArticles()
        {
            DataTable dataTable = MV_Article.GetDataTableArticles();
            return dataTable;
        }

        private void Btn_Selection_Article_Click(object sender, RoutedEventArgs e)
        {
            // var article = ListViewArticles.SelectedItem;

            if(ListViewArticles.SelectedItems.Count != 1)
            {
                MessageBox.Show("Vous devez choisir un article.");
            }
            else
            {
                var id = ListViewArticles.SelectedItems[0] as DataRowView;
                Int32 identifiant = (Int32)id["Id"];

                this.NavigationService.Navigate(new Page_Article(identifiant));
            }



        }
    }
}
