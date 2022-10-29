using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Domain.Models;

namespace DAL.Repository
{
    public class Db_Pays
    {
        private SqlConnection _connection;

        public Db_Pays()
        {
            this.Db_Connexion();
        }
        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            this._connection = connexion.GetConnection();
        }

        public List<Pays> ListePays()
        {
            List<Pays> listePays = new List<Pays>();

            SqlCommand requete = this._connection.CreateCommand();
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
            this._connection.Close();
            return listePays;
        }

        public Pays DonneUnPays(int idendifiant)
        {
            string requete = "SELECT * FROM Pays WHERE id = @id_pays";
            SqlCommand commande = new SqlCommand(requete, this._connection);
            SqlParameter idPays = commande.Parameters.Add("@id_pays", SqlDbType.Int);
            idPays.Value = idendifiant;
            SqlDataReader reader = commande.ExecuteReader();

            Pays unPays = new Pays();
            while (reader.Read())
            {
                unPays.id = Int32.Parse($"{reader[0]}");
                unPays.code = $"{reader[1]}";
                unPays.alpha2 = $"{reader[2]}";
                unPays.alpha3 = $"{reader[3]}";
                unPays.nom_fr = $"{reader[4]}";
                unPays.nom_en = $"{reader[5]}";
            }

            this._connection.Close();
            return unPays;
        }
    }
}
