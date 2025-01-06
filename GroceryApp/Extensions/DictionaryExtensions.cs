using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class DictionaryExtensions
{
    public static T ValueAs<T>(this IDictionary<string, object> dictionary, string key, T defaultValue = default)
    {
        return dictionary.ContainsKey(key) && dictionary[key] is T value
            ? value
            : defaultValue;
    }
}
