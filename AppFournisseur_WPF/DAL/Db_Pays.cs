using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using AppFournisseur_WPF.Models;
using System.Windows;

namespace AppFournisseur_WPF.DAL
{
    public class Db_Pays
    {
        private SqlConnection _connection;

        public Db_Pays()
        {
            Db_Connexion();
        }
        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            _connection = connexion.GetConnection();
        }

        public List<Pays> AllCountries()
        {
            _connection.Open();
            List<Pays> listePays = new List<Pays>();

            SqlCommand requete = _connection.CreateCommand();
            requete.CommandText = "SELECT * FROM Pays";

            SqlDataReader reader = requete.ExecuteReader();
            while (reader.Read())
            {
                Pays unPays = new Pays();
                unPays.id = int.Parse($"{reader[0]}");
                unPays.code = $"{reader[1]}";
                unPays.alpha2 = $"{reader[2]}";
                unPays.alpha3 = $"{reader[3]}";
                unPays.nom_fr = $"{reader[4]}";
                unPays.nom_en = $"{reader[5]}";

                listePays.Add(unPays);
            }

            _connection.Close();
            return listePays;
        }

        public Pays OneCountry(int idendifiant)
        {
            _connection.Open();
            string requete = "SELECT * FROM Pays WHERE id = @id_pays";
            SqlCommand commande = new SqlCommand(requete, _connection);
            SqlParameter idPays = commande.Parameters.Add("@id_pays", SqlDbType.Int);
            idPays.Value = idendifiant;
            SqlDataReader reader = commande.ExecuteReader();

            Pays unPays = new Pays();
            while (reader.Read())
            {
                unPays.id = int.Parse($"{reader[0]}");
                unPays.code = $"{reader[1]}";
                unPays.alpha2 = $"{reader[2]}";
                unPays.alpha3 = $"{reader[3]}";
                unPays.nom_fr = $"{reader[4]}";
                unPays.nom_en = $"{reader[5]}";
            }

            _connection.Close();
            return unPays;
        }
    }
}
