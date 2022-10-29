using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFournisseur_WPF.DAL;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.ModelView
{
    public class MV_Article
    {
        static Db_Produit_Ref db_produit_ref = new Db_Produit_Ref();
        
        public static ObservableCollection<Produit_Ref> GetAllArticles()
        {
            ObservableCollection<Produit_Ref> list = db_produit_ref.AllArticles();
            return list;
        }
        public static Produit_Ref GetOneArticle(int identifiant)
        {
            Produit_Ref article = db_produit_ref.OneArticle(identifiant);
            return article;
        }
        public static SortedDictionary<string, int> GetRelationsOfArticle(int identifiant)
        {
            SortedDictionary<string, int> relationships = new SortedDictionary<string, int>();
            return relationships;
        }

        public static DataTable GetDataTableArticles()
        {
            DataTable dataTable = db_produit_ref.DataTableArticles();
            return dataTable;
        }
    }
}
