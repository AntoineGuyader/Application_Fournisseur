using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using AppFournisseur_WPF.DAL;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.ModelView
{
    public class MV_Fournisseur
    {
        static Db_Fournisseur db_fournisseur = new Db_Fournisseur();

        /// <summary>
        /// Méthode qui renvoie la liste de tous les fournisseurs
        /// </summary>
        /// <returns>ObservableCollection<Fournisseur></returns>
        public static ObservableCollection<Fournisseur> GetAllSuppliers()
        {
            return db_fournisseur.AllSuppliers();
        }
        /// <summary>
        /// Méthode qui renvoie un fournisseur sélectionné par son identifiant
        /// </summary>
        /// <param name="identifiant"></param>
        /// <returns> Fournisseur </returns>
        public static Fournisseur GetOneSupplier(int identifiant)
        {
            return db_fournisseur.OneFournisseur(identifiant);
        }
    }
}
