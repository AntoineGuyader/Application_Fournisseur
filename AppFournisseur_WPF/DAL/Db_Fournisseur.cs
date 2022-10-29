using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFournisseur_WPF.Models;
using Microsoft.VisualBasic;

namespace AppFournisseur_WPF.DAL
{
    public class Db_Fournisseur
    {
        private SqlConnection _connection;
        public Db_Fournisseur()
        {
            Db_Connexion();
        }

        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            _connection = connexion.GetConnection();
        }

        public ObservableCollection<Fournisseur> AllSuppliers()
        {
            ObservableCollection<Fournisseur> collection = new ObservableCollection<Fournisseur>();
            _connection.Open();
            string query = "SELECT * FROM Fournisseurs";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Fournisseur fournisseur = new Fournisseur();
                fournisseur.id = reader.GetInt32(0);
                fournisseur.raison_social = reader.GetString(1);
                fournisseur.telephone = reader.GetString(2);
                fournisseur.email = reader.GetString(3);
                fournisseur.inactif = reader.GetBoolean(4);
                fournisseur.num_siren = reader.GetInt32(5);
                fournisseur.num_siret = reader.GetInt32(6);
                fournisseur.adresse = reader.GetInt32(7);
                collection.Add(fournisseur);
            }
            _connection.Close();
            return collection;
        }
        public Fournisseur OneFournisseur(int identifiant)
        {
            _connection.Open();
            Fournisseur fournisseur = new Fournisseur();
            string query = "SELECT * FROM Fournisseur WHERE id = @identifiant";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlParameter idFournisseur = cmd.Parameters.Add("@identifiant", SqlDbType.Int);
            idFournisseur.Value = identifiant;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fournisseur.id = reader.GetInt32(0);
                fournisseur.raison_social = reader.GetString(1);
                fournisseur.telephone = reader.GetString(2);
                fournisseur.email = reader.GetString(3);
                fournisseur.inactif = reader.GetBoolean(4);
                fournisseur.num_siren = reader.GetInt32(5);
                fournisseur.num_siret = reader.GetInt32(6);
                fournisseur.adresse = reader.GetInt32(7);
            }
            _connection.Close();
            return fournisseur;
        }
    }
}
