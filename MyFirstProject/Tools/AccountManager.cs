using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MyFirstProject.Assets;
using Newtonsoft.Json;
using static MyFirstProject.Assets.FilePaths;

namespace MyFirstProject.Tools
{
    internal class AccountManager
    {
        public static bool CreateAccount(string username, string email, string password)
        {
            // Création du compte
            Account newAccount = new Account(username, email, password);
            Console.WriteLine("Compte créé avec succès.");
            SaveAccountToFile(newAccount);
            return true;
        }
        public static void SaveAccountToFile(Account account)
        {
            // Read existing JSON data
            string json = File.ReadAllText(usersFilePath);
            var usersData = JsonConvert.DeserializeObject<Dictionary<string, List<Account>>>(json) ?? new Dictionary<string, List<Account>>();

            // Add new account to the list
            if (!usersData.ContainsKey("users"))
            {
                usersData["users"] = new List<Account>();
            }
            usersData["users"].Add(account);

            // Serialize and save updated JSON data
            string updatedJson = JsonConvert.SerializeObject(usersData, Formatting.Indented);
            File.WriteAllText(usersFilePath, updatedJson);
        }



    }
}
