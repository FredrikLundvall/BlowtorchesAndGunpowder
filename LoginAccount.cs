using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlowtorchesAndGunpowder
{
    public class LoginAccount
    {
        public readonly string Username;
        public readonly string Password;
        public readonly string Playername;
        public LoginAccount(string aUsername, string aPassword, string aPlayername)
        {
            Username = aUsername;
            Password = aPassword;
            Playername = aPlayername;
        }
    }
}
