using AppFournisseur_WPF.Views.Pages;
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

namespace AppFournisseur_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RadioButton Btn_Index_MainMenu;
        Button MainMenuIndex_Btn;
        public MainWindow()
        {
            InitializeComponent();
            InitialDefault();
        }
        /// <summary>
        /// Bouton permettant de fermer l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Bouton permettant de valider une recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MainSearchBar(object sender, RoutedEventArgs e)
        {
            string test = mainPageSearchBar.Text;
            MessageBox.Show(test.ToString());
        }
        public void InitialDefault()
        {
            Btn_Index_MainMenu = Btn_Home;
            Btn_Index_MainMenu.IsChecked = true;
            MainFrame.Content = new Page_Accueil();
        }
        private void Main_Menu_Selection(object sender, RoutedEventArgs e)
        {
            if (Btn_Home.IsChecked == true) MainFrame.Content = new Page_Accueil();
            else
            {
                if (Btn_Command.IsChecked == true) MainFrame.Content = new Page_Test();
                else
                {
                    if (Btn_Suppliers.IsChecked == true) MainFrame.Content = new Page_Fournisseurs();
                    else
                    {
                        if (Btn_Articles.IsChecked == true) MainFrame.Content = new Page_Articles();
                        else
                        {
                            if (Btn_Adresse.IsChecked == true) MainFrame.Content = new Page_Adresse_Form();
                            else if (Btn_Test.IsChecked == true) MainFrame.Content = new Page_Test();
                        }
                    }
                }
            }
        }


        // public void ChangeIndex()
        public void Test()
        {
            MessageBox.Show("Test");
        }
    }
}


/*private void Btn_MainMenu_Click(object sender, RoutedEventArgs e)
{
    Button btn_clicked = e.Source as Button;
    int zero = 0;

    switch (btn_clicked.Name)
    {
        case "Btn_Articles":
            MainFrame.Content = new Page_Articles();
            break;
        case "Btn_Adresse":
            MainFrame.Content = new Page_Adresse_Form();
            break;
        case "Btn_Test":
            MainFrame.Content = new Page_Test();
            break;
        default:
            MainFrame.Content = new Page_Accueil();
            break;
    }
    MainMenuIndex_Btn.Style = (Style)Application.Current.Resources["Btn_Main_Menu"];
    // MainMenuIndex_Btn.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#272537");
    MainMenuIndex_Btn = btn_clicked;
    MainMenuIndex_Btn.Style = (Style)Application.Current.Resources["Btn_Main_Menu_Index"];
    // MainMenuIndex_Btn.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#22202f");
}*/