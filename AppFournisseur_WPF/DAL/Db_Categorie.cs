using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.DAL
{
    public class Db_Categorie
    {
        private SqlConnection _connection;
        public Db_Categorie()
        {
            Db_Connexion();
        }

        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            _connection = connexion.GetConnection();
        }

        public List<Categorie> ListeCategories()
        {
            _connection.Open();
            List<Categorie> listeCategories = new List<Categorie>();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categorie";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Categorie categorie = new Categorie();
                categorie.id = int.Parse($"{reader[0]}");
                categorie.nom = $"{reader[1]}";
                categorie.tva = int.Parse($"{reader[2]}");

                listeCategories.Add(categorie);
            }

            _connection.Close();
            return listeCategories;
        }

        public Categorie UneCategorie(int identifiant)
        {
            _connection.Open();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categorie WHERE id = @id";
            SqlParameter idCategorie = cmd.Parameters.Add("@id", SqlDbType.Int);
            idCategorie.Value = identifiant;
            SqlDataReader reader = cmd.ExecuteReader();
            Categorie categorie = new Categorie();
            while (reader.Read())
            {
                categorie.id = int.Parse($"{reader[0]}");
                categorie.nom = $"{reader[1]}";
                categorie.tva = int.Parse($"{reader[2]}");
            }
            _connection.Close();
            return categorie;
        }
    }
}
