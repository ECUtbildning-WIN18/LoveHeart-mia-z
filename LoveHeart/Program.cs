using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(81, 26);
            MenuHandler mh = new MenuHandler();
            mh.Run();
        }
    }
}
