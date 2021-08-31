using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining2
{
    public class AwesomeSauce
    {
        public List<string> Sauces {get; set;}

        public AwesomeSauce()
        {
            Sauces = new List<string>(); //constructor to instantiate list
        }

        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }
    }
}
