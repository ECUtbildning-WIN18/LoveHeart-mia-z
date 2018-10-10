using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoveHeart
{
    class MenuHandler
    {
        public enum State { PreLogin, RMenu, Register, Search, Exit }
        public State state;

        public static bool exit;

        public MenuHandler()
        {
            state = State.PreLogin;
        }
        
        public void Run()
        {
            while (state != State.Exit)
            {
                switch (state)
                {
                    case State.PreLogin:
                        PreLogin pl = new PreLogin(this);
                        break;
                    case State.RMenu:
                        Console.WriteLine("Omg u logged in u did it!");
                        break;
                    case State.Exit:
                        Exit ex = new Exit(this);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
