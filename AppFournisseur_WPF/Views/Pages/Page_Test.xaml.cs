using System.Data;
using System.Collections.Generic;
using System.Windows.Controls;
using AppFournisseur_WPF.Models;
using AppFournisseur_WPF.ModelView;

namespace AppFournisseur_WPF.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour Page_Test.xaml
    /// </summary>
    public partial class Page_Test : Page
    {
        public Page_Test()
        {
            InitializeComponent();

            // ComboBoxtest.ItemsSource = MyTest();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MV_Adresse.DeleteAdress(4);
            // this.NavigationService.Navigate(new Page_Accueil());
        }
    }
}
