using System;
using System.Collections.Generic;
using System.Text;

namespace APARecipe.Services
{
    interface IJsonSerializerService
    {
        string SerializeObject<T>(T payload);
        T Deserialize<T>(string payload);
    }
}
