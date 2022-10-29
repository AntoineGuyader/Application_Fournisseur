using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFournisseur_WPF.Models
{
    public class Categorie
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nom;
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private int _tva;
        public int tva
        {
            get { return _tva; }
            set { _tva = value; }
        }
    }
}
