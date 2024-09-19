using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Goat : Animal
    {
        public Goat() : base("Goat", "Meh") { }

        public override int ProduceMilk()
        {
            return new Random().Next(0, 11); 
        }

        public override int GiveBirth()
        {
            return new Random().Next();
        }
    }
}
