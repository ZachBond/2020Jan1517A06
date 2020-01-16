using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InheritanceDemo.Animals;

namespace InheritanceDemo
{
    public class AnimalControlOfficer
    {
        private static Random _rnd = new Random();
        public int Quota { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Animal> Strays { get; private set; }
        public AnimalControlOfficer(int quota)
        {
            this.Quota = quota;
            Strays = new List<Animal>();
        }

        public void Patrol()
        {
            for (int counter = 0; counter < Quota; counter++)
            {
                Strays.Add(FindDog());
            }
        }
        private Dog FindDog()
        {
            // just randomly get a dog
            int aValue = _rnd.Next(4);
            Dog stray = null;
            switch (aValue)
            {
                case 0:
                    stray = new InheritanceDemo.Animals.Poodle();
                    break;
                case 1:
                    stray = new InheritanceDemo.Animals.BassetHound();
                    break;
                case 2:
                    stray = new InheritanceDemo.Animals.Rottweiller();
                    break;
                case 3:
                    stray = new InheritanceDemo.Animals.Chihuahua();
                    break;
                case 4:
                    stray = new InheritanceDemo.Animals.GermanShepherd();
                    break;
            }
            return stray;
        }
        public void Report()
        {
            foreach (Animal stray in Strays)
            {
                Console.WriteLine("Here's a " + stray.GetType().Name + ": " + stray.Speak());
            };
        }


    }
}
