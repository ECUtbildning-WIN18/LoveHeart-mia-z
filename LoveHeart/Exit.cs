using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class Exit : Draw
    {
        public Exit(MenuHandler menuHandler)
        {
            DrawBox();
        }

        public override void DrawBox()
        {
            base.DrawBox();
            WriteAtJustified($"Press return to exit the program..", 
                (new Func<int>(() =>
            {
                int jpos = Convert.ToInt32(Math.Floor((double)yMax / 2));
                return jpos;
            })()));
            
            Console.ReadLine();
        }
    }
}
