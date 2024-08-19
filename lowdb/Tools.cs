using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lowdb;

public static class Tools
{

    public static string ToJson(this object o, bool prettyPrint = false)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = prettyPrint,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        return JsonSerializer.Serialize(o, options);
    }

}
