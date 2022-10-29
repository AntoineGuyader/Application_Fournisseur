using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFournisseur_WPF.Models
{
    public class Produit_Ref
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nom_ref;
        public string nom_ref
        {
            get { return _nom_ref; }
            set { _nom_ref = value; }
        }
        private float _prix_HT;
        public float prix_HT
        {
            get { return _prix_HT; }
            set { _prix_HT = value; }
        }
        private float _qte_stock;
        public float qte_stock
        {
            get { return _qte_stock; }
            set { _qte_stock = value; }
        }
        private float _qte_commande;
        public float qte_commande
        {
            get { return _qte_commande; }
            set { _qte_commande = value; }
        }
        private float _qte_alerte;
        public float qte_alerte
        {
            get { return _qte_alerte; }
            set { _qte_alerte = value; }
        }

        private int _fournisseur;
        public int fournisseur
        {
            get { return _fournisseur; }
            set { _fournisseur = value; }
        }

        private int _categorie;
        public int categorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }
        private int _unite_meusure;
        public int unite_mesure
        {
            get { return _unite_meusure; }
            set { _unite_meusure = value; }
        }
    }
}
