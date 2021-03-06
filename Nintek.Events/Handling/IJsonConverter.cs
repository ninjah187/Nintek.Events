using System;
using System.Collections.Generic;
using System.Text;

namespace Nintek.Events.Handling
{
    public interface IJsonConverter
    {
        string Serialize(object data);
        object Deserialize(string json, Type type);
    }
}
