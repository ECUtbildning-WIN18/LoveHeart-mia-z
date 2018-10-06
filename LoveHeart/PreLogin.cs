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
            if (UserName == "")
            {
                ClearInside();
                WriteAtJustified("Nothing was entered, press enter to restart..", yMax / 2);
                Console.ReadLine();
                return;
            }
            PassWord = GetLoginInfo();
            if (UserName == "")
            {
                ClearInside();
                WriteAtJustified("Nothing was entered, press enter to restart..", yMax / 2);
                Console.ReadLine();
                return;
            }
            CheckInfo(UserName, PassWord);
        }

        public string GetLoginInfo()
        {
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                if (currentInput == Inputs.User)
                {
                    WriteAt(">", 2, 4);
                    Console.SetCursorPosition(12, 4);
                    currentInput = Inputs.Pass;
                    return Console.ReadLine();
                }
                else
                if (currentInput == Inputs.Pass)
                {
                    WriteAt(" ", 2, 4);
                    WriteAt(">", 2, 6);
                    Console.SetCursorPosition(12, 6);
                    return Console.ReadLine();
                }
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
