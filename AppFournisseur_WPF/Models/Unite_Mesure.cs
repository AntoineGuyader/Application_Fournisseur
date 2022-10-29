using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFournisseur_WPF.Models
{
    public class Unite_Mesure
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nom_fr_unite;
        public string nom_fr_unite
        {
            get { return _nom_fr_unite; }
            set { _nom_fr_unite = value; }
        }
        private string _nom_en_unite;
        public string nom_en_unite
        {
            get { return _nom_en_unite; }
            set { _nom_en_unite = value; }
        }
        private string _symbole_unite;
        public string symbole_unite
        {
            get { return _symbole_unite; }
            set { _symbole_unite = value; }
        }
    }
}
