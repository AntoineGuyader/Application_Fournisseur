using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppFournisseur_WPF.Controllers
{
    public class Verification
    {
        private static string lowers = @"^[a-z]+$";
        // private static string letters = @"^[a-zA-Z]+$";  Sans whitespace
        private static string letters = @"^[a-zA-Z' ']+$";
        private static string integers = @"^[0-9]+$";
        private static string lettersAndNum = @"^[a-zA-Z0-9]+$";

        public static bool IntOnly(string word)
        {
            if(Regex.IsMatch(word, integers)) return true;
            else return false;
        }
        public static bool LettersOnly(string word)
        {
            if (Regex.IsMatch(word, letters)) return true;
            else return false;
        }



        // Méthodes du pendu 1V1
        public static bool lowersOnly(string word)
        {
            if (Regex.IsMatch(word, lowers)) return true;
            else return false;
        }

        public static bool intOnly(string word)
        {
            if (Regex.IsMatch(word, integers)) return true;
            else return false;
        }

        public static bool wordLength(string word, int min, int max)
        {
            if (word.Length < min || word.Length > max) return true;
            else return false;
        }
    }
}
