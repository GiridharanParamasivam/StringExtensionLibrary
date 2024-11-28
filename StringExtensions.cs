using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionLibrary
{
    internal static class StringExtensions
    {
        public static bool StartsWithUpper(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            char firstChar = input[0];
            return char.IsUpper(firstChar);
        }
    }
}
