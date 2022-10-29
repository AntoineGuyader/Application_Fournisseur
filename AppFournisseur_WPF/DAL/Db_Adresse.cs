﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Data;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.DAL
{
    public class Db_Adresse
    {
        private SqlConnection _connection;
        public Db_Adresse()
        {
            Db_Connexion();
        }

        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            _connection = connexion.GetConnection();
        }

        public List<Adresse> AllAdresses()
        {
            _connection.Open();
            List<Adresse> ListeAdresses = new List<Adresse>();

            SqlCommand requete = _connection.CreateCommand();
            requete.CommandText = "SELECT * FROM Adresse";

            SqlDataReader adresses = requete.ExecuteReader();
            while (adresses.Read())
            {
                Adresse uneAdresse = new Adresse();
                uneAdresse.id = int.Parse($"{adresses[0]}");
                uneAdresse.ville = $"{adresses[1]}";
                uneAdresse.code_postal = $"{adresses[2]}";
                uneAdresse.nom_rue = $"{adresses[3]}";
                uneAdresse.num_rue = int.Parse($"{adresses[4]}");
                // uneAdresse.num_rue = int.Parse($"{adresses[3]}");
                uneAdresse.complement_adresse = $"{adresses[5]}";
                uneAdresse.pays = int.Parse($"{adresses[6]}");

                ListeAdresses.Add(uneAdresse);
            }
            _connection.Close();
            return ListeAdresses;
        }
        public Adresse OneAdress(int id)
        {
            _connection.Open();
            string query = "SELECT * FROM Adresse WHERE id = @id_adresse";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlParameter idAdresse = cmd.Parameters.Add("@id_adresse", SqlDbType.Int);
            idAdresse.Value = id;
            SqlDataReader reader = cmd.ExecuteReader();

            Adresse adress = new Adresse();
            while (reader.Read())
            {
                adress.id = reader.GetInt32(0);
                adress.ville = reader.GetString(1);
                adress.code_postal = reader.GetString(2);
                adress.nom_rue = reader.GetString(3);
                adress.num_rue = reader.GetInt32(4);
                adress.complement_adresse = reader.GetString(5);
                adress.pays = reader.GetInt32(6);
            }
            _connection.Close();
            return adress;
        }

        public void AddAdress(Adresse adresse)
        {
            _connection.Open();
            string requete = "INSERT INTO Adresse (ville, nom_rue, num_rue, code_postal, pays, complement_adresse)" +
                            "VALUES (@ville, @nomRue, @numRue, @CP, @pays, @complement)";

            SqlCommand commande = new SqlCommand(requete, _connection);

            SqlParameter ville = commande.Parameters.Add("@ville", System.Data.SqlDbType.NVarChar);
            SqlParameter nomRue = commande.Parameters.Add("@nomRue", System.Data.SqlDbType.NVarChar);
            SqlParameter numRue = commande.Parameters.Add("@numRue", System.Data.SqlDbType.Int);
            SqlParameter CP = commande.Parameters.Add("@CP", System.Data.SqlDbType.NVarChar);
            SqlParameter pays = commande.Parameters.Add("@pays", System.Data.SqlDbType.Int);
            SqlParameter complement = commande.Parameters.Add("@complement", System.Data.SqlDbType.NVarChar);

            ville.Value = adresse.ville;
            nomRue.Value = adresse.nom_rue;
            numRue.Value = adresse.num_rue;
            CP.Value = adresse.code_postal;
            complement.Value = adresse.complement_adresse;
            pays.Value = adresse.pays;

            try
            {
                commande.ExecuteNonQuery();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ErrorCode.ToString());
            }
            this._connection.Close();
        }
        public void DeleteAdresse(int id)
        {
            _connection.Open();
            string query = "DELETE FROM Adresse WHERE id = @id_adresse";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlParameter idAdresse = cmd.Parameters.Add("@id_adresse", SqlDbType.Int);
            idAdresse.Value = id;
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
