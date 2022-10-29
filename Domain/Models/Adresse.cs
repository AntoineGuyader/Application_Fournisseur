using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Adresse
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _ville;
        public string ville
        {
            get { return _ville; }
            set { _ville = value; }
        }
        private string _nom_rue;
        public string nom_rue
        {
            get { return _nom_rue; }
            set { _nom_rue = value; }
        }
        private int _num_rue;
        public int num_rue
        {
            get { return _num_rue; }
            set { num_rue = value; }
        }
        private string _code_postal;
        public string code_postal
        {
            get { return _code_postal; }
            set { _code_postal = value; }
        }
        private string? _complement_adresse;
        public string? complement_adresse
        {
            get { return _complement_adresse; }
            set { _complement_adresse = value; }
        }
        private int _pays;
        public int pays
        {
            get { return _pays; }
            set { _pays = value; }
        }
    }
}