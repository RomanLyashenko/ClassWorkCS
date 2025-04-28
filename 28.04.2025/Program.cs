using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._2025
{

    public class Human
    {
        string name;
        string lastName;
        public void Human(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public void input()
        {
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Last name:");
            this.lastName = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Last name: {lastName}");
        }
    }

    public class Builder : Human 
    {
        string jobTitle;
        int salary;
        int yearsOfExperience;
        public void Builder(string name, string lastName, string jobTitle, int salary, int yearsOfExperience): base Human(string name, string lastName)
        {
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.yearsOfExperience = yearsOfExperience;
        }
        public void input()
        {
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Last name:");
            this.lastName = Console.ReadLine();
            Console.WriteLine("Job title:");
            this.jobTitle = Console.ReadLine();
            Console.WriteLine("Salary:");
            this.salary = Console.ReadLine();
            Console.WriteLine("Years of experience:");
            this.yearsOfExperience = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Job title: {jobTitle}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Years of experience: {yearsOfExperience}");
        }
    }

    public class Passport
    {
        string country;
        string name;
        string lastName;
        public void Passport(string country, string name, string lastName)
        {
            this.country = country;
            this.name = name;
            this.lastName = lastName;
        }
        public void input()
        {
            Console.WriteLine("Country:");
            this.country = Console.ReadLine();
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Last name:");
            this.lastName = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Country: {this.country}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Last name: {lastName}");
        }
    }

    public class ForeingPassport : Passport
    {
        int amountOfVisas;
        int number;

        public void ForeingPassport() : base Passport (string country, string name, string lastName)
        {
            this.amountOfVisas = amountOfVisas;
            this.number = number;
        }
        public void input()
        {
            Console.WriteLine("Country:");
            this.country = Console.ReadLine();
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Last name:");
            this.lastName = Console.ReadLine();
            Console.WriteLine("Amount of Visas:");
            this.amountOfVisas = Console.ReadLine();
            Console.WriteLine("Number of the foreing passport:");
            this.number = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Country: {this.country}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Amount of Visas: {amountOfVisas}");
            Console.WriteLine($"Number of the foreing passport: {number}");
        }
    }

    public class Animal
    {
        string name;
        int weight;
        public void Animal (string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }

    public class Tiger : Animal
    {
        string age;
        public void Tiger(string age) : base Animal(string name, int weight)
        {
            this.age = age;
        }
        public void input()
        {
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Weight:");
            this.weight = Console.ReadLine();
            Console.WriteLine("Age:");
            this.age = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    public class Сrocodile : Animal
    {
        string color;
        public void Сrocodile(string color) : base Animal(string name, int weight)
        {
            this.color = color;
        }
        public void input()
        {
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Weight:");
            this.weight = Console.ReadLine();
            Console.WriteLine("Color:");
            this.color = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Color: {color}");
        }
    }
    public class Kangaroo : Animal
    {
        string height;
        public void Kangaroo(string age) : base Animal(string name, int weight)
        {
            this.height = height;
        }
        public void input()
        {
            Console.WriteLine("Name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Weight:");
            this.weight = Console.ReadLine();
            Console.WriteLine("Height:");
            this.height = Console.ReadLine();
        }
        public void enter()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Height: {height}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger1 = new Tiger();
            Kangaroo kangaroo1 = new Kangaroo();
            Сrocodile crocodile1 = new Сrocodile();
            kangaroo1.input();
            kangaroo1.enter();
        }
    }
}
