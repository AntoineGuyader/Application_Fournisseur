using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace DAL.Repository
{
    public class Db_Produit_Ref
    {
        private SqlConnection _connection;

        public Db_Produit_Ref()
        {
            this.Db_Connexion();
        }
        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            this._connection = connexion.GetConnection();
        }

        /// <summary>
        /// Renvoie la liste de tous produits
        /// </summary>
        /// <returns> List<Produit_Ref> </returns>
        public List<Produit_Ref> ListeProduitsRef()
        {
            List<Produit_Ref> listeProduits = new List<Produit_Ref>();
            SqlCommand cmd = this._connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Ensemble_Produits";
            // cmd.CommandText = "SELECT * FROM Ensemble_Produits INNER JOIN Categorie ON Ensemble_Produits.categorie = Categorie.id INNER JOIN Unite_Mesure ON Ensemble_Produits.unite_mesure = Unite_Mesure.id";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produit_Ref produit = new Produit_Ref();
                produit.id = int.Parse($"{reader[0]}");
                produit.nom_ref = $"{reader[1]}";
                produit.prix_HT = float.Parse($"{reader[2]}");
                produit.qte_stock = float.Parse($"{reader[3]}");
                produit.qte_commande = float.Parse($"{reader[4]}");
                produit.qte_alerte = float.Parse($"{reader[5]}");
                produit.categorie = int.Parse($"{reader[6]}");
                produit.unite_meusure = int.Parse($"{reader[7]}");

                listeProduits.Add(produit);
            }
            this._connection.Close();
            return listeProduits;
        }
        /// <summary>
        /// Renvoie un datatable des produit avec sa catégorie et son unité de mesure
        /// </summary>
        /// <returns> DataTable </returns>
        public DataTable ListeArticle()
        {
            DataTable dtArticles = new DataTable();
            dtArticles.Columns.Add("Id", typeof(int));
            dtArticles.Columns.Add("Nom", typeof(string));
            dtArticles.Columns.Add("Prix_HT", typeof(decimal));
            dtArticles.Columns.Add("Qte_Stock", typeof(decimal));
            dtArticles.Columns.Add("Qte_Commande", typeof(decimal));
            dtArticles.Columns.Add("Qte_Alerte", typeof(decimal));
            dtArticles.Columns.Add("Categorie", typeof(string));
            dtArticles.Columns.Add("Unite", typeof(string));


            SqlCommand cmd = this._connection.CreateCommand();
            // cmd.CommandText = "SELECT * FROM Ensemble_Produits";
            cmd.CommandText = "SELECT P.id, P.nom_ref, P.prix_HT, P.qte_stock, P.qte_commande, P.qte_alerte, C.nom, UM.symbole_unite  " +
                "FROM Ensemble_Produits AS P " +
                "INNER JOIN Categorie AS C ON P.categorie = C.id " +
                "INNER JOIN Unite_Mesure AS UM ON P.unite_mesure = UM.id";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = dtArticles.NewRow();
                row[0] = reader[0];
                row[1] = reader[1];
                row[2] = reader[2];
                row[3] = reader[3];
                row[4] = reader[4];
                row[5] = reader[5];
                row[6] = reader[6];
                row[7] = reader[7];

                dtArticles.Rows.Add(row);
            }

            return dtArticles;
        }

        public DataTable ListeArticleTest()
        {
            DataTable dtArticles = new DataTable();
            dtArticles.Columns.Add("Id", typeof(int));
            dtArticles.Columns.Add("Nom Produit", typeof(string));
            dtArticles.Columns.Add("Prix HT", typeof(decimal));
            dtArticles.Columns.Add("Qte Stock", typeof(decimal));
            dtArticles.Columns.Add("Qte Commandé", typeof(decimal));
            dtArticles.Columns.Add("Qte Alerte", typeof(decimal));
            dtArticles.Columns.Add("Categorie", typeof(int));
            dtArticles.Columns.Add("Unite", typeof(int));
            dtArticles.Columns.Add("IdCat", typeof(int));
            dtArticles.Columns.Add("NomCat", typeof(string));
            dtArticles.Columns.Add("IdTVA", typeof(int));
            dtArticles.Columns.Add("IdUniteMesure", typeof(int));
            dtArticles.Columns.Add("NomUniteMeusre", typeof(string));
            dtArticles.Columns.Add("Symbole", typeof(string));


            SqlCommand cmd = this._connection.CreateCommand();
            // cmd.CommandText = "SELECT * FROM Ensemble_Produits";
            cmd.CommandText = "SELECT P.*, C.*, UM.id, UM.nom_fr_unite, UM.symbole_unite " +
                "FROM Ensemble_Produits AS P " +
                "INNER JOIN Categorie AS C ON P.categorie = C.id " +
                "INNER JOIN Unite_Mesure AS UM ON P.unite_mesure = UM.id";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = dtArticles.NewRow();
                row[0] = reader[0];
                row[1] = reader[1];
                row[2] = reader[2];
                row[3] = reader[3];
                row[4] = reader[4];
                row[5] = reader[5];
                row[6] = reader[6];
                row[7] = reader[7];
                row[8] = reader[8];
                row[9] = reader[9];
                row[10] = reader[10];
                row[11] = reader[11];
                row[12] = reader[12];
                row[13] = reader[13];

                dtArticles.Rows.Add(row);
            }

            return dtArticles;
        }
    }
}
