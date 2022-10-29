using AppFournisseur_WPF.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace DAL.Repository
{
    public class Db_Adresse
    {
        private SqlConnection _connection;
        public Db_Adresse()
        {
            this.Db_Connexion();
        }

        private void Db_Connexion()
        {
            Connexion connexion = new Connexion();
            this._connection = connexion.GetConnection();
        }

        public List<Adresse> listeAdresses()
        {
            List<Adresse> ListeAdresses = new List<Adresse>();

            SqlCommand requete = this._connection.CreateCommand();
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
            this._connection.Close();
            return ListeAdresses;
        }

        public void AjoutAdresse(Adresse adresse)
        {
            string requete = "INSERT INTO Adresse (ville, nom_rue, num_rue, code_postal, pays, complement_adresse)" +
                            "VALUES (@ville, @nomRue, @numRue, @CP, @pays, @complement)";

            SqlCommand commande = new SqlCommand(requete, this._connection);

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

                commande.ExecuteNonQuery();
/*            try
            {

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ErrorCode.ToString());
            }*/
            this._connection.Close();
        }
    }
}
