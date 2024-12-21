using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_UML2
{
    public interface Identifable
    {
        Guid Id { get; set; }
    }

    public interface Experienced
    {
        void ShareExperience();
    }

    public class Vaccine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        
    }

    public class PetInformation
    {
        public List<string> Traits { get; set; }
        public List<Vaccine> Vaccines { get; set; }
    }

    public class Animal
    {
        public string Type { get; set; }
        public string Breed { get; set; }

        public bool Carnivore { get; set; }

    }

    public class Owner : Experienced
    {
        public string Name { get; set; }

        public void ShareExperience()
        {
            Console.WriteLine($"{Name} kişisinin deneyimleri");

        }
    }

    public class Pet : Identifable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public Owner Owner { get; set; }
        public Animal Type { get; set; }
        public PetInformation PetInfo { get; set; }

        public void Feed()
        {
            if (Type.Carnivore)
                Console.WriteLine($"{Name} için et servisi yapıldı.");
            else
                Console.WriteLine($"{Name} için sebze servisi yapıldı.");
        }

        public bool IsHerbivore()
        {
            return !Type.Carnivore;
        }
    }


     class Program
     {
         static void Main(string[] args)
         {

         }
     }
}
