using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Db_Categorie
    {
        private SqlConnection _connection;
        public Db_Categorie()
        {
            this.Db_Connexion();
        }

        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            this._connection = connexion.GetConnection();
        }

        public List<Categorie> ListeCategories()
        {
            List<Categorie> listeCategories = new List<Categorie>();
            SqlCommand cmd = this._connection.CreateCommand();
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

            this._connection.Close();
            return listeCategories;
        }

        public Categorie UneCategorie(int identifiant)
        {
            SqlCommand cmd = this._connection.CreateCommand();
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
            this._connection.Close();
            return categorie;
        }
    }
}
