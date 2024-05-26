using System;
using System.Collections.Generic;
using System.Text;

namespace BlowtorchesAndGunpowder
{
    public class ClientAction : MessageBase
    {
        public bool PlayerShooting;

        public ClientAction(bool aPlayerShooting) : base(false)
        {
            PlayerShooting = aPlayerShooting;
        }
    }
}
