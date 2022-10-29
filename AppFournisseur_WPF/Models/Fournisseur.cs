using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFournisseur_WPF.Models
{
    public class Fournisseur
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _raison_social;
        public string raison_social
        {
            get { return _raison_social; }
            set { _raison_social = value; }
        }
        private string _telephone;
        public string telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private bool _inactif;
        public bool inactif
        {
            get { return _inactif; }
            set { _inactif = value; }
        }
        private int _num_siren;
        public int num_siren
        {
            get { return _num_siren; }
            set { _num_siren = value; }
        }
        private int _num_siret;
        public int num_siret
        {
            get { return _num_siret; }
            set { _num_siret = value; }
        }
        private int _adresse;
        public int adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
    }
}
