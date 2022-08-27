using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
        
        public int IceCreamCode(string iceCreamFlavour)
        {            
            return Array.IndexOf(IceCreamFlavours, iceCreamFlavour);
        }
    }
}
