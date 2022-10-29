using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFournisseur_WPF.DAL;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.ModelView
{
    public class MV_Fournisseur
    {
        static Db_Fournisseur db_fournisseur = new Db_Fournisseur();

        public static Fournisseur GetOneSupplier(int identifiant)
        {
            return db_fournisseur.OneFournisseur(identifiant);
        }
    }
}
