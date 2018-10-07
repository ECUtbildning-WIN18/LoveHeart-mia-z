using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class PreLogin : Draw
    {
        public enum Inputs { User, Pass }
        public Inputs currentInput = Inputs.User;

        public string UserName;
        public string PassWord;

        public MenuHandler MenuHandler;

        public PreLogin(MenuHandler menuHandler)
        {
            MenuHandler = menuHandler;

            DrawBox();

            UserName = GetLoginInfo();
            PassWord = GetLoginInfo();
            CheckInfo(UserName, PassWord);
            //In future there would be a method here that checks to see if the user exists in the system.
        }

        public string GetLoginInfo()
        {
            if (currentInput == Inputs.User)
            {
                WriteAt(">", 2, 4);
                Console.SetCursorPosition(12, 4);
                currentInput = Inputs.Pass;
                string s = Console.ReadLine();
                if (s == "")
                {
                    ClearInside();
                    WriteAtJustified("Nothing was entered, press enter to restart..", yMax / 2);
                    return "";
                }
                return s;
            }
            else
            if (currentInput == Inputs.Pass)
            {
                WriteAt(" ", 2, 4);
                WriteAt(">", 2, 6);
                Console.SetCursorPosition(12, 6);
                string s = Console.ReadLine();
                if (s == "")
                {
                    ClearInside();
                    WriteAtJustified("Nothing was entered, press enter to restart..", yMax / 2);
                    return "";
                }
                return s;
            }
            return "";
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
                    MenuHandler.state = MenuHandler.State.LoggedIn;
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
