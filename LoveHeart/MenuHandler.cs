using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class MenuHandler
    {
        public enum State { PreLogin, LoggedIn, Register, Search, Exit }
        public State state;

        public static bool exit = false;

        public MenuHandler()
        {
            state = State.PreLogin;
        }

        public void EscapeListener()
        {

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
                    case State.LoggedIn:
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
