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
    /// Logique d'interaction pour Page_Accueil.xaml
    /// </summary>
    public partial class Page_Accueil : Page
    {
        public Page_Accueil()
        {
            InitializeComponent();
            ComboBoxAccueil.ItemsSource = Custom();
        }

        public List<string> Custom()
        {
            List<string> list = new List<string>();
            foreach (Adresse obj in MV_Adresse.GetAllAdresses())
            {
                list.Add(obj.code_postal);
            }
            return list;
        }
    }
}
