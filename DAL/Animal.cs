namespace DAL
{
    public class Animal
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int MilkProduced { get; set; }
        public int Offspring { get; set; }
        public string Sound { get; set; } 

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public virtual string MakeSound()
        {
            return Sound;
        }


        public virtual int ProduceMilk()
        {
            return 0;
        }

        public virtual int GiveBirth()
        {
            return 0;
        }
    }
}
