using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaRozszerzajaca
{
    static class StringExtensions
    {
        public static string Decorate(this string s)
        {
            return "!!! " + s + " !!!";
        }
    }
}
