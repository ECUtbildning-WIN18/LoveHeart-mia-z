using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    abstract class Draw
    {
        public const int xMax = 80;
        public const int yMax = 25;

        public static int InitialX;
        public static int InitialY;

        protected Draw()
        {
            Console.Clear();
            InitialX = Console.CursorTop;
            InitialY = Console.CursorLeft;
        }

        public virtual void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(InitialX + x, InitialY + y);
            Console.Write(s);
        }

        public virtual void WriteAtJustified(string s, int y)
        {
            int justifiedX = Convert.ToInt32(Math.Floor((double)(xMax - s.Length) / 2));
            Console.SetCursorPosition(InitialX + justifiedX, InitialY + y);
            Console.Write(s);
        }

        public virtual void DrawBox()
        {
            Console.Clear();
            int y = 0;
            for (int x = 0; x <  xMax; x++)
            {
                WriteAt("#", InitialX + x, 0);
                WriteAt("#", InitialX + x, yMax);
                if (y <= yMax)
                {
                    WriteAt("#", 0, y);
                    WriteAt("#", xMax, y);
                    y++;
                }
            }
        }

        public virtual void ClearInside()
        {
            for (int x = 1; x < xMax -1 ; x++)
            {
                for (int y = 1; y < yMax - 1; y++)
                {
                    WriteAt(" ", x, y);
                }
            }
        }
    }
}
