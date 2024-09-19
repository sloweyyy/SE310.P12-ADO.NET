using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cow : Animal
    {
        public Cow() : base("Cow", "Moo") { }

        public override int ProduceMilk()
        {
            return new Random().Next(0, 21); 
        }

        public override int GiveBirth()
        {
            return new Random().Next();
        }
    }

}
