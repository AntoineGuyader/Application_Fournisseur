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

using AppFournisseur_WPF.Models;
using AppFournisseur_WPF.ModelView;

namespace AppFournisseur_WPF.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour Page_Article.xaml
    /// </summary>
    public partial class Page_Article : Page
    {
        MainWindow MainWindow = (MainWindow)Application.Current.MainWindow;
        public Produit_Ref current_article;
        public Fournisseur fournisseur;
        public Page_Article(int identifiant)
        {
            InitializeComponent();
            current_article = CurrentArticle(identifiant);
        }
        public Produit_Ref CurrentArticle(int id)
        {
            Produit_Ref article = MV_Article.GetOneArticle(id);
            
            fournisseur = MV_Fournisseur.GetOneSupplier(article.fournisseur);

            return article;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Title_ArticlePage.Text = "Page du produit " + current_article.nom_ref;
            SupplierName.Content = fournisseur.raison_social;
        }

        private void Btn_ListArticle_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }


    }
}
