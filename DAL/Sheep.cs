using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Sheep : Animal
    {
        public Sheep() : base("Sheep", "Baa") { }

        public override int ProduceMilk()
        {
            return new Random().Next(0, 6); 
        }

        public override int GiveBirth()
        {
            return new Random().Next();
        }
    }
}
