using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using MyFirstProject.Assets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using static MyFirstProject.Assets.FilePaths;

namespace MyFirstProject.Tools
{
    internal class Validators
    {
        
        public static bool IsEmailValid(string email)
        {
            string[] validTlds = new string[]
            {
                "com", "org", "net", "edu", "gov", "mil", "int", "fr", "de", "uk", "us", "ca", "au", "jp", "cn", "br", "in"
            };

            if (string.IsNullOrWhiteSpace(email))
                return true;

            // Utilisation d'une expression régulière pour vérifier le format de l'email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
                return false;

            // Extraction du TLD de l'email
            string domain = email.Substring(email.LastIndexOf('.') + 1);

            // Vérification si le TLD est dans la liste des TLD valides
            foreach (string tld in validTlds)
            {
                if (domain.Equals(tld, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        public static bool IsPasswordValid(string password)
        {
            return password.Length >= 8;
        }

        public static bool IsAgeValid(int age)
        {
            return age >= 18;
        }

        public static bool IsNameValid(string name)
        {
            return name.Length >= 3;
        }

        public static bool DoesAccountExist(string name, string email, string password)
        {
            Account newAccount = new Account(name, email, password);

            string json = File.ReadAllText(usersFilePath);

            var usersData = JsonConvert.DeserializeObject<Dictionary<string, List<Account>>>(json);
            List<Account> people = usersData?["users"] ?? new List<Account>();

            bool nameExists = people.Any(p => p.Name == newAccount.Name);
            bool emailExists = people.Any(p => p.Email == newAccount.Email);

            return nameExists && emailExists;
        }

        public static bool IsLoginValid(string login, string password)
        {
            string json = File.ReadAllText(usersFilePath);

            var usersData = JsonConvert.DeserializeObject<Dictionary<string, List<Account>>>(json);
            List<Account> people = usersData?["users"] ?? new List<Account>();

            return people.Any(p => (p.Email == login || p.Name == login) && p.Password == password);
        }

        public static List<string> IsRegistrationValid(string name, string email, string password, string secondPassword)
        {
            List<string> errors = new List<string>();

            if (!IsNameValid(name))
                errors.Add("Le pseudo doit contenir au moins 3 caractères.");
            if (!IsEmailValid(email) || string.IsNullOrWhiteSpace(email))
                errors.Add("L'email n'est pas valide.");
            if (!IsPasswordValid(password))
                errors.Add("Le mot de passe doit contenir au moins 8 caractères.");
            if (!IsPasswordSame(password, secondPassword))
                errors.Add("Les mots de passe ne correspondent pas.");
            if (DoesAccountExist(name, email, password))
                errors.Add("Le pseudo ou l'email est déjà pris.");

            return errors;
        }

        public static bool IsPasswordSame(string password, string secondPassword)
        {
            return password == secondPassword;
        }
    }
}
