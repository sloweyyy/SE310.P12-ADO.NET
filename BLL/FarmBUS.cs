using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class Farm
    {
        public List<Animal> Animals { get; set; }

        public Farm()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal, int count)
        {
            animal.Count = count;
            Animals.Add(animal);
        }

        public string GetAllAnimalSounds()
        {
            string sounds = "";
            foreach (var animal in Animals)
            {
                for (int i = 0; i < animal.Count; i++)
                {
                    sounds += animal.MakeSound() + "\n";
                }
            }

            return sounds;
        }


        public void CalculateMilkAndBirth(out int totalMilk, out int totalAnimals)
        {
            totalMilk = 0;
            totalAnimals = 0;

            foreach (var animal in Animals)
            {
                for (int i = 0; i < animal.Count; i++)
                {
                    totalMilk += animal.ProduceMilk();
                    totalAnimals += animal.GiveBirth();
                }
            }
        }
    }
}