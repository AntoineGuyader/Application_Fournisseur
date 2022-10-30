using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using AppFournisseur_WPF.Models;
using System.Collections.ObjectModel;

namespace AppFournisseur_WPF.DAL
{
    public class Db_Produit_Ref
    {
        private SqlConnection _connection;

        public Db_Produit_Ref()
        {
            Db_Connexion();
        }
        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            _connection = connexion.GetConnection();
        }
        /// <summary>
        /// Renvoie la liste des articles
        /// </summary>
        /// <returns>ObservableCollection<Produit_Ref></returns>
        public ObservableCollection<Produit_Ref> AllArticles()
        {
            _connection.Open();
            ObservableCollection<Produit_Ref> list = new ObservableCollection<Produit_Ref>();
            string query = "SELECT * FROM Ensemble_Produits";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produit_Ref article = new Produit_Ref();
                article.id = reader.GetInt32(0);
                article.nom_ref = reader.GetString(1);
                article.prix_HT = (float)reader.GetDouble(2);
                article.qte_stock = (float)reader.GetDouble(3);
                article.qte_commande = (float)reader.GetDouble(4);
                article.qte_alerte = (float)reader.GetDouble(5);
                article.fournisseur = reader.GetInt32(6);
                article.categorie = reader.GetInt32(7);
                article.unite_mesure = reader.GetInt32(8);
                list.Add(article);
            }
            _connection.Close();
            return list;
        }
        /// <summary>
        /// Renvoie un article en fonction de son identifiant
        /// </summary>
        /// <param name="identifiant"></param>
        /// <returns>Produit_Ref</returns>
        public Produit_Ref OneArticle(int identifiant)
        {
            _connection.Open();
            Produit_Ref article = new Produit_Ref();
            string query = "SELECT * FROM Ensemble_produits WHERE id = @identifiant";
            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlParameter idArticle = cmd.Parameters.Add("@identifiant", SqlDbType.Int);
            idArticle.Value = identifiant;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                article.id = reader.GetInt32(0);
                article.nom_ref = reader.GetString(1);
                article.prix_HT = (float)reader.GetDouble(2);
                article.qte_stock = (float)reader.GetDouble(3);
                article.qte_commande = (float)reader.GetDouble(4);
                article.qte_alerte = (float)reader.GetDouble(5);
                article.fournisseur = reader.GetInt32(6);
                article.categorie = reader.GetInt32(7);
                article.unite_mesure = reader.GetInt32(8);
            }
            _connection.Close();
            return article;
        }
        /// <summary>
        /// Renvoie un datatable des produit avec sa catégorie et son unité de mesure
        /// </summary>
        /// <returns> DataTable </returns>
        public DataTable DataTableArticles()
        {
            _connection.Open();
            DataTable dtArticles = new DataTable();
            dtArticles.Columns.Add("Id", typeof(int));
            dtArticles.Columns.Add("Nom", typeof(string));
            dtArticles.Columns.Add("Prix_HT", typeof(float));
            dtArticles.Columns.Add("Qte_Stock", typeof(float));
            dtArticles.Columns.Add("Qte_Commande", typeof(float));
            dtArticles.Columns.Add("Qte_Alerte", typeof(float));
            dtArticles.Columns.Add("Categorie", typeof(string));
            dtArticles.Columns.Add("Unite", typeof(string));


            SqlCommand cmd = _connection.CreateCommand();
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

            _connection.Close();
            return dtArticles;
        }

        public DataTable ListeArticleTest()
        {
            _connection.Open();
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


            SqlCommand cmd = _connection.CreateCommand();
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
            _connection.Close();
            return dtArticles;
        }
    }
}
