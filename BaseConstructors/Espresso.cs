using System;
using System.Xml.Linq;

namespace BaseConstructors
{
    internal class Espresso : Coffee
    {
        public Espresso() 
        {
            // Use the default constructor to set default values.
            Cup = "Ikea";
            Capacity = 250;
        }

        public Espresso(string name, bool isFairTrade, int servingTemp, string bean, string roast, string countryOfOrigin, string cup, int capacity) : base(name, isFairTrade, servingTemp, bean, roast, countryOfOrigin) 
        {
            Cup = cup;
            Capacity = capacity;
        }

        public string Cup { get; set; }
        public int Capacity { get; set; }
    }
}
