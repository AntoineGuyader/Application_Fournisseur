using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFournisseur_WPF.Models
{
    public class Pays
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _code;
        public string code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _alpha2;
        public string alpha2
        {
            get { return _alpha2; }
            set { _alpha2 = value; }
        }
        private string _alpha3;
        public string alpha3
        {
            get { return _alpha3; }
            set { _alpha3 = value; }
        }
        private string _nom_fr;
        public string nom_fr
        {
            get { return _nom_fr; }
            set { _nom_fr = value; }
        }
        private string _nom_en;
        public string nom_en
        {
            get { return _nom_en; }
            set { _nom_en = value; }
        }

        public override string ToString()
        {
            return alpha3 + " : " + nom_fr;
        }
    }
}
