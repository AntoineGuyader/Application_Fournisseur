using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Connexion
    {
        public SqlConnection GetConnection()
        {
            // SqlConnection connection = new SqlConnection("Server=LAPTOP-EGCT5DQM\\SQL2019;Database=Fournisseur_BDD;Trusted_Connection=True;");
            SqlConnection connection = new SqlConnection("Server=DESKTOP-K1M664S\\SQL2019;Database=Fournisseur_BDD;Trusted_Connection=True;");
            connection.Open();
            return connection;
        }
    }
}