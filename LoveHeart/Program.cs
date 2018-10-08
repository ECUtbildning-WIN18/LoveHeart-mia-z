using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoveHeart
{
    class Program
    {
        public List<User> users;

        static void Main(string[] args)
        {


            Console.SetWindowSize(81, 26);
            MenuHandler mh = new MenuHandler();
            mh.Run();
        }
    }
}
