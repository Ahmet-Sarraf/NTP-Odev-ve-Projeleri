using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_UML1
{
    //Adres Sınıfı
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        // Bu metot Street ve City değişkenlerinin boş yada null olup olmamasını kontrol eder
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City);
        }

        //Bu metot değişken değerlerini yazdırır
        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    //Person sınıfının abstract tanınmasının sebebi doğrudan bu sınıftan nesne üretilmesi yerine alt sınıfları olan Student yada Proffesor sınıfının kullanılması
    public abstract class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        // Person sınıfının Adress sınıfı ile 0..1 ilişkisi olduğu içi tanımlanması zorunludur
        public Address LivesAt { get; set; }

        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} has purchased a parking pass.");
        }
    }

    public class Student : Person
    {
        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }

        public bool IsEligibleToEnroll(string a)
        {
            // AverageMark değişkeni 50 üstü olunca True döndürecek
            return AverageMark > 50;
        }

        public int GetSeminarsTaken()
        {
            return 0;
        }
    }

    public class Professor : Person
    {
        public int Salary { get; set; }
        public int StaffNumber { get; set; }
        public int YearsOfService { get; set; }
        public int NumberOfClasses { get; set; }

        //Student ve Professor arasnda 0..* ilişkisi olduğu için list yapısı kullanılı
        public List<Student> Supervisees { get; set; } = new List<Student>();

        public void SuperviseStudent(Student student)
        {
            if (Supervisees.Count < 5)
            {
                Supervisees.Add(student);
                Console.WriteLine($"{Name} is now supervising {student.Name}.");
            }
            else
            {
                Console.WriteLine($"{Name} cannot supervise more than 5 students.");
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            // addres nesnesi oluşturma
            Address address = new Address
            {
                Street = "123 Main St",
                City = "Springfield",
                State = "IL",
                PostalCode = 62701,
                Country = "USA"
            };

            // student nesnesi oluşturma
            Student student = new Student
            {
                Name = "John Doe",
                PhoneNumber = "123-456-7890",
                EmailAddress = "john.doe@example.com",
                LivesAt = address,
                StudentNumber = 1001,
                AverageMark = 85
            };

            // professor nesnesi oluşturma
            Professor professor = new Professor
            {
                Name = "Dr. Smith",
                PhoneNumber = "987-654-3210",
                EmailAddress = "dr.smith@example.com",
                LivesAt = address,
                Salary = 75000,
                StaffNumber = 5001,
                YearsOfService = 10,
                NumberOfClasses = 3
            };

            // 
            professor.SuperviseStudent(student);

            // Output details
            Console.WriteLine(student.LivesAt.OutputAsLabel());
            Console.WriteLine($"Is {student.Name} eligible to enroll? {student.IsEligibleToEnroll("Math 101")} ");
            Console.ReadKey();
        }
    }
    
}