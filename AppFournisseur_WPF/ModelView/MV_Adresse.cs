using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFournisseur_WPF.DAL;
using AppFournisseur_WPF.Models;

namespace AppFournisseur_WPF.ModelView
{
    public class MV_Adresse
    {
        static Db_Adresse db_adresse = new Db_Adresse();
        
        public static void AddAdress(Adresse adresse)
        {
            db_adresse.AddAdress(adresse);
        }

        public static List<Adresse> GetAllAdresses()
        {
            List<Adresse> adresses = db_adresse.AllAdresses();
            return adresses;
        }
        public static Adresse GetOneAdress(int id)
        {
            Adresse adresse = db_adresse.OneAdress(id);
            return adresse;
        }
        public static void DeleteAdress(int id)
        {
            // db_adresse.DeleteAdresse(id);
            try
            {
                db_adresse.DeleteAdresse(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
