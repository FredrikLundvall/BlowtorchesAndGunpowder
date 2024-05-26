using System;
using System.Collections.Generic;
using System.Text;

namespace BlowtorchesAndGunpowder
{
    public abstract class MessageBase
    {
        public readonly bool FromServer;

        public MessageBase(bool aFromServer)
        {
            FromServer = aFromServer;
        }

        public string GetAsJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ClientAction CreateFromJson(string aActionJson)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ClientAction>(aActionJson);
        }
    }
}
