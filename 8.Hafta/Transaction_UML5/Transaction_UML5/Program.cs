using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_UML5
{

    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }

        public void Update()
        {
            Console.WriteLine($"Transaction {Id} güncellendi.");
        }
    }

    
    public class Reservation
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public List<string> List { get; set; } = new List<string>();

        public void Confirmation()
        {
            Console.WriteLine($"Reservation {Id} onaylandı.");
        }
    }

    
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Payment { get; set; }

        public void Update()
        {
            Console.WriteLine($"Customer {Name} güncellendi.");
        }
    }

    
    public class Car
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string OrderType { get; set; }

        public void ProcessDebit()
        {
            Console.WriteLine($"Car {Id} işlem yapıldı.");
        }
    }

    
    public class RentingOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ContactNum { get; set; }
        public string Password { get; set; }

        public void VerifyAccount()
        {
            Console.WriteLine($"Renting Owner {Name} hesabı doğrulandı.");
        }
    }

    
    public class Payment
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string Amount { get; set; }

        public void Add()
        {
            Console.WriteLine($"Payment {Id} eklendi.");
        }

        public void Update()
        {
            Console.WriteLine($"Payment {Id} güncellendi.");
        }
    }

    
    public class Rentals
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Price { get; set; }

        public void Add()
        {
            Console.WriteLine($"Rental {Id} eklendi.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
