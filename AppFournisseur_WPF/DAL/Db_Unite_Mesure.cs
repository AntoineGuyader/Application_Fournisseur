using AppFournisseur_WPF.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AppFournisseur_WPF.DAL
{
    public class Db_Unite_Mesure
    {
        private SqlConnection _connection;

        public Db_Unite_Mesure()
        {
            Db_Connexion();
        }
        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            _connection = connexion.GetConnection();
        }

        public List<Unite_Mesure> ListeUnitesMesure()
        {
            _connection.Open();
            List<Unite_Mesure> liste = new List<Unite_Mesure>();
            SqlCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Unite_Mesure";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Unite_Mesure unite = new Unite_Mesure();
                unite.id = int.Parse($"{reader[0]}");
                unite.nom_fr_unite = $"{reader[1]}";
                unite.nom_en_unite = $"{reader[2]}";
                unite.symbole_unite = $"{reader[3]}";

                liste.Add(unite);
            }
            _connection.Close();
            return liste;
        }
    }
}
