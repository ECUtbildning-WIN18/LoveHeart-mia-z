using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class PreLogin : Draw
    {
        public enum Inputs { User, Pass, Check }
        public Inputs currentInput = Inputs.User;

        public string UserName = "";
        public string PassWord = "";

        public MenuHandler MenuHandler;

        public PreLogin(MenuHandler menuHandler)
        {
            MenuHandler = menuHandler;

            ClearInside();
            GetLoginInfo();
            if (currentInput == Inputs.Check)
            CheckInfo(UserName, PassWord);

            //In future there would be a method here that checks to see if the user exists in the system.
        }

        public void GetLoginInfo()
        {
            string sp, su;
            DrawBox();
            switch (currentInput)
            {
                case Inputs.User:
                    WriteAt(">", 2, 4);
                    Console.SetCursorPosition(12, 4);
                    su = Console.ReadLine();
                    if (su == "")
                    {
                        ClearInside();
                        WriteAtJustified("Nothing was entered, press enter to restart..", yMax / 2);
                        Console.ReadLine();
                        return;
                    }
                    UserName = su;
                    currentInput = Inputs.Pass;
                    goto case Inputs.Pass;

                case Inputs.Pass:
                    WriteAt(" ", 2, 4);
                    WriteAt(">", 2, 6);
                    Console.SetCursorPosition(12, 6);
                    sp = Console.ReadLine();
                    if (sp == "")
                    {
                        ClearInside();
                        WriteAtJustified("Nothing was entered, press enter to restart..", yMax / 2);
                        Console.ReadLine();
                        return;
                    }
                    PassWord = sp;
                    currentInput = Inputs.Check;
                    break;
            }
        }

        public bool CheckInfo(string userName, string passWord)
        {
            ClearInside();
            WriteAtJustified($"Log in user: {UserName}?", yMax / 2);
            WriteAtJustified($"(Y)es (N)o", (yMax / 2) + 1);
            ConsoleKey response = Console.ReadKey().Key;
            switch (response)
            {
                case ConsoleKey.Y:
                    MenuHandler.state = MenuHandler.State.RMenu;
                    break;
                default:
                    break;
            }
            return true;
        }

        public override void DrawBox()
        {
            base.DrawBox();
            WriteAtJustified("--Login Menu--", 1);
            WriteAt($"Username: ", 3, 4);
            WriteAt($"Password: ", 3, 6);
        }
    }
}
