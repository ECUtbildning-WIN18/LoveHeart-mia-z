using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LoveHeart
{
    class FileHandler
    {
        public List<User> Users { get; set; }
        StreamReader Buffer { get; set; }

        public FileHandler()
        {
            Buffer = new StreamReader(@"db.json");
            Users = LoadUsers();
        }

        public List<User> LoadUsers()
        {
            string json = Buffer.ReadToEnd();
            List<User> db = new List<User>(JsonConvert.DeserializeObject<List<User>>(json));
            return db;
        }

        public void AddNewUser(User userToAdd)
        {
            Users.Add(userToAdd);
            //OLD METHOD - STRING BUFFER :ECH:
            //string fileToWrite = JsonConvert.SerializeObject(Users, Formatting.Indented);
            using (StreamWriter file = File.CreateText(@"db.json"))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(file, Users);
            }
        }

        public User LoginAuthenticator(string u, string p)
        {
            foreach (var user in Users)
            {
                if (u == user.FirstName)
                {
                    if (p == user.Password)
                    {
                        return user;
                    }
                }
            }
            return null;
        }
    }
}
