using System;
using System.Collections.Generic;
using System.Text;

namespace BlowtorchesAndGunpowder
{
    public class LoggedInUser
    {
        public string Username;
        public string Playername;
        public string CurrentGamename;
        public LoggedInUser(string aUsername, string aPlayername, string aCurrentGamename)
        {
            Username = aUsername;
            Playername = aPlayername;
            CurrentGamename = aCurrentGamename;
        }
        public override string ToString()
        {
            if(CurrentGamename == "")
                return $"{Playername} ({Username})";
            else
                return $"{Playername} ({Username}) - Spelar just nu {CurrentGamename}";
        }
    }
}
