using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaRozszerzajacaSygnatura
{
    static class StringExtensions
    {
        /* Nigdy sie nie wywola!!!

Jesli utworzymy metode rozszerzenia, ktora ma dokladnie taki sam podpis jak istniejaca metoda instancji w klasie, kompilator nie bedzie narzekal na nasza nowa metode. Ale jesli sprobujemy wywolac taka metode, to metoda oryginalnej instancji zostanie wywolana, zamiast nasza metoda rozszerzenia.
        */
        public static int CompareTo(this string s1, string s2)
        {
            return 0;
        }
    }
}
