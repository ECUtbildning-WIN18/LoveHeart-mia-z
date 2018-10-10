using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoveHeart
{
    class Program
    {
        public static List<User> Users;

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"db.txt");
            string json = sr.ReadToEnd();
            Users = new List<User>(JsonConvert.DeserializeObject<List<User>>(json));

            foreach (User u in Users)
            {
                Console.WriteLine(u.FirstName);
            }
            Console.ReadLine();
            //Console.SetWindowSize(81, 26);
            //MenuHandler mh = new MenuHandler();
            //mh.Run();
        }
    }
}
