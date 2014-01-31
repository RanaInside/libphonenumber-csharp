using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System
{
    static class Profile158Extensions
    {
        public static Type GetTypeInfo(this Type type)
        {
            // original signature > TypeInfo GetTypeInfo(this Type type)
            return type;
        }

        public static AssemblyName GetName(this Assembly assembly)
        {
            var assemblyName = new AssemblyName(assembly.FullName);
            return assemblyName;
        }

        public static StringBuilder Insert(this StringBuilder stringBuilder, int index, int value)
        {
            // libphone is passing the number as integer to StringBuilder, and PLUS_SIGN as char
            // which is then received by this extension; one option was to change PLUS_SIGN to string,
            // but I feel this is safer;
            var str = (value == 43) ? "+" : Convert.ToString(value);
            return stringBuilder.Insert(index, str);
        }
    }
}

namespace PhoneNumbers
{
    public class SortedDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public new KeyCollection Keys
        {
            get
            {
                return new KeyCollection(this.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value));
            }
        }
    }
}


