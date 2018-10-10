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
        public static FileHandler fh;

        static void Main(string[] args)
        {
            Console.SetWindowSize(81, 26);
            fh = new FileHandler();
            MenuHandler mh = new MenuHandler();
            mh.Run();
        }
    }
}
