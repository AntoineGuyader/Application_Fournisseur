using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFournisseur_WPF.DAL;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.ModelView
{
    public  class MV_Pays
    {
        static Db_Pays db_pays = new Db_Pays();

        /// <summary>
        /// Renvoie la liste des pays
        /// </summary>
        /// <returns></returns>
        public static List<Pays> GetAllCountries()
        {
            List<Pays> list = db_pays.AllCountries();
            return list;
        }
        /// <summary>
        /// Renvoie un pays avec son identifiant
        /// </summary>
        /// <returns></returns>
        public static Pays GetOneCountry(int id)
        {
            Pays pays = db_pays.OneCountry(id);
            return pays;
        }
    }
}
