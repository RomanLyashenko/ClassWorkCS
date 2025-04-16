using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._04._2025
{
    public class Worker
    {
        private string name;
        private string lastName;
        private string fathersName;
        private string dateOfBirth;
        private string phone;
        private string email;
        private string position;
        private string description;

        public void name1(string a)
        {
            this.name = a;
        }
        public void lastName1(string a)
        {
            this.lastName = a;
        }
        public void fathersName1(string a)
        {
            this.fathersName = a;
        }
        public void dateOfBirth1(string a)
        {
            this.dateOfBirth = a;
        }
        public void phone1(string a)
        {
            this.phone = a;
        }
        public void email1(string a)
        {
            this.email = a;
        }
        public void position1(string a)
        {
            this.position = a;
        }
        public void description1(string a)
        {
            this.description = a;
        }

        public void enter()
        {
            Console.WriteLine($"Фамилия: {this.lastName}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {fathersName}");
            Console.WriteLine($"Дата рождения: {dateOfBirth}");
            Console.WriteLine($"Номер телефона: {phone}");
            Console.WriteLine($"Почта: {email}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Служебные обязанности: {description}");
        }

        public void input()
        {
            Console.WriteLine("Фамилия:");
            this.lastName = Console.ReadLine();
            Console.WriteLine("Имя:");
            this.name = Console.ReadLine();
            Console.WriteLine("Отчество:");
            this.fathersName = Console.ReadLine();
            Console.WriteLine("Дата рождения:");
            this.dateOfBirth = Console.ReadLine();
            Console.WriteLine("Номер телефона:");
            this.phone = Console.ReadLine();
            Console.WriteLine("Почта:");
            this.email = Console.ReadLine();
            Console.WriteLine("Должность:");
            this.dateOfBirth = Console.ReadLine();
            Console.WriteLine("Обязанности:");
            this.description = Console.ReadLine();
        }
    }

    public class Plane
    {
        private string name;
        private string manufacturer;
        private int yearOfProduction;
        private string type;

        public void name1(string a)
        {
            this.name = a;
        }
        public void manufacturer1(string a)
        {
            this.manufacturer = a;
        }
        public void yearOfProduction1(int a)
        {
            this.yearOfProduction = a;
        }
        public void type1(string a)
        {
            this.type = a;
        }

        public void input()
        {
            Console.WriteLine("Название:");
            this.name = Console.ReadLine();
            Console.WriteLine("Производитель:");
            this.manufacturer = Console.ReadLine();
            Console.WriteLine("Год производства:");
            this.yearOfProduction =int.Parse(Console.ReadLine());
            Console.WriteLine("Тип самолета:");
            this.type = Console.ReadLine();
        }

        public void enter()
        {
            Console.WriteLine($"Название: {this.name}");
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Год производства: {yearOfProduction}");
            Console.WriteLine($"Тип самолета: {type}");
        }

        public void enter(string manufacturer, string yearOfProduction, string type)
        {
            Console.WriteLine($"Название: {this.name}");
        }
    }


    internal class Programm
    {
        static void Main(string[] args)
        {

            // task 1

            //Worker worker1 = new Worker();
            //worker1.input();
            //worker1.enter();

            // task 2

            //Plane plane1 = new Plane();
            //plane1.input();
            //plane1.enter();

            // task 3

            int max = 10;
            NewNamespace4.fibonacci num1 = new NewNamespace4.fibonacci();

            //num1.arr1(max);

            NewNamespace2.even num2 = new NewNamespace2.even();

            //num2.arr2(max);

            NewNamespace1.odd num3 = new NewNamespace1.odd();

            //num3.arr3(max);

            NewNamespace3.prime num4 = new NewNamespace3.prime();

            num4.arr4(max);
        }
    }
}
